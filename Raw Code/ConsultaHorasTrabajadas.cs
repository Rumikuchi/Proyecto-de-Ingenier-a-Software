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
    public partial class ConsultaHorasTrabajadas : Form
    {
        public Trabajador trabajador;

        public ConsultaHorasTrabajadas(Trabajador trabajador)
        {
            InitializeComponent();
            this.trabajador = trabajador;
            cargarEmpleados();
            
        }

        

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cargarEmpleados()
        {
            if (trabajador.isAdmin)
            {
                string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
                string sql = "select P.codigo, P.nombre, P.apellidos, dbo.ConvertTimeToHHMMSS(SUM(tiempoTrabajado), 's') as tiempoTrabajado FROM Personal P, Saldo_Tiempo S " +
                    "WHERE P.codigo = S.codigoPersonal GROUP BY P.codigo, P.nombre, P.apellidos;";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "Authors_table");
                connection.Close();

                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = ds.Tables[0];
            }
            else
            {
                string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
                string sql = "select P.codigo, P.nombre, P.apellidos, dbo.ConvertTimeToHHMMSS(SUM(tiempoTrabajado), 's') as tiempoTrabajado FROM Personal P, Saldo_Tiempo S " +
                    "WHERE P.codigo = S.codigoPersonal AND P.codigo = '"+ trabajador.codigo +"' GROUP BY P.codigo, P.nombre, P.apellidos;";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "Authors_table");
                connection.Close();

                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = ds.Tables[0];
            }

        }

    }
}
