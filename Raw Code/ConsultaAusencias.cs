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
    public partial class ConsultaAusencias : Form
    {
        public Trabajador trabajador;
        public ConsultaAusencias(Trabajador trabajador)
        {
            InitializeComponent();
            this.trabajador = trabajador;
            cargarAusencias();
        }

        private void cargarAusencias()
        {

            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql = "select * FROM Ausencias A, Personal P Where A.CodigoPersonal = P.codigo";
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
