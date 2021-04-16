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
    public partial class Auditoria : Form
    {

        public Auditoria()
        {
            InitializeComponent();
            cargarAuditoria();
        }

        class Fecha
        {
            public string fecha;
            
            public Fecha(string fecha)
            {

                this.fecha = fecha;
                
            }
            public override string ToString()
            {
                return fecha;
            }
        }

        class Usuario
        {
            public string usuario;

            public Usuario(string usuario)
            {

                this.usuario = usuario;

            }
            public override string ToString()
            {
                return usuario;
            }
        }

        private void cargarAuditoria()
        {
            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql = "select * FROM Auditoria ORDER BY Fecha desc;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = ds.Tables[0];

            string sql2 = "select fecha FROM Auditoria Group BY Fecha;";
            SqlConnection connection2 = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter2 = new SqlDataAdapter(sql2, connection);
            DataSet ds2 = new DataSet();
            connection2.Open();
            dataadapter2.Fill(ds2, "Authors_table");
            connection2.Close();

            cbFecha.Items.Add(new Fecha(""));

            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                //Añadir Fechas de DB
                cbFecha.Items.Add(new Fecha(dr.ItemArray[0].ToString()));
            }


            string sql3 = "select usuario FROM Auditoria Group BY usuario;";
            SqlConnection connection3 = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection);
            DataSet ds3 = new DataSet();
            connection3.Open();
            dataadapter3.Fill(ds3, "Authors_table");
            connection3.Close();

            cbUsuario.Items.Add(new Usuario(""));

            foreach (DataRow dr in ds3.Tables[0].Rows)
            {
                //Añadir Usuarios de DB
                cbUsuario.Items.Add(new Usuario(dr.ItemArray[0].ToString()));
            }
        }

        private void cbFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFecha.SelectedIndex != 0)
            {
                cbUsuario.SelectedIndex = 0;
                string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
                string sql = "select * FROM Auditoria WHERE fecha = '" + (cbFecha.SelectedItem as Fecha).ToString() + "' ORDER BY Fecha desc;";
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


        private void cbUsuario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbUsuario.SelectedIndex != 0)
            {
                cbFecha.SelectedIndex = 0;
                string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
                string sql = "select * FROM Auditoria WHERE usuario = '" + (cbUsuario.SelectedItem as Usuario).ToString() + "' ORDER BY Fecha desc;";
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
