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

namespace Proyecto_Fichajes
{
    public partial class HorasDiaFichaje : Form
    {
        public HorasDiaFichaje()
        {
            InitializeComponent();
            cargarHoras();
        }
        private void cargarHoras()
        {
            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql = "select fecha, dbo.ConvertTimeToHHMMSS(SUM(tiempoTrabajado), 's') as tiempoTrabajado FROM Saldo_Tiempo " +
                "GROUP BY fecha;";
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
