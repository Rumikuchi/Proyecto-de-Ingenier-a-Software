using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Fichajes.VentanaPrincipal;

namespace Proyecto_Fichajes
{
    public partial class SaldoTiempo : Form
    {
        public Trabajador trabajador;
        DateTime Trabajadas;
        DateTime Ausencias;
        TimeSpan Saldo;
        public SaldoTiempo(Trabajador trabajador)
        {
            InitializeComponent();
            this.trabajador = trabajador;
            cargarEmpleados();
        }
        private void cargarEmpleados()
        {
            
            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql = "select P.codigo, P.nombre, P.apellidos, dbo.ConvertTimeToHHMMSS(SUM(tiempoTrabajado), 's') as tiempoTrabajado FROM Personal P, Saldo_Tiempo S " +
                "WHERE P.codigo = S.codigoPersonal AND P.codigo = '" + trabajador.codigo + "' GROUP BY P.codigo, P.nombre, P.apellidos;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                labelHorasTrabajadas.Text = dr.ItemArray[3].ToString();
                int horas = int.Parse(dr.ItemArray[3].ToString().Split(':')[0]);
                int mins = int.Parse(dr.ItemArray[3].ToString().Split(':')[1]);
                int segs = int.Parse(dr.ItemArray[3].ToString().Split(':')[2]);
                Trabajadas = DateTime.Today + new TimeSpan(horas, mins, segs);

            }

            sql = "Select COUNT(A.fecha) as Ausencias from Ausencias A WHERE A.CodigoPersonal = '" + trabajador.codigo + "'";
            dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds2 = new DataSet();
            connection.Open();
            dataadapter.Fill(ds2, "Authors_table");
            connection.Close();

            foreach (DataRow dr2 in ds2.Tables[0].Rows)
            {
                
                int aus = int.Parse(dr2.ItemArray[0].ToString()) * 8;
                Ausencias = DateTime.Today + new TimeSpan(aus, 0, 0);
                labelHorasAusencias.Text = aus.ToString().PadLeft(2,'0') + ":00:00";
            }
            
            Saldo = Trabajadas - Ausencias;
            labelSaldoTiempo.Text = Math.Round(Saldo.TotalHours) + ":" + Saldo.Minutes + ":" + Saldo.Seconds;
        }
    }

}
