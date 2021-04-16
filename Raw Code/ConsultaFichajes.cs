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
    public partial class ConsultaFichajes : Form
    {
        public Trabajador trabajador;
        public ConsultaFichajes(Trabajador trabajador)
        {
            InitializeComponent();
            this.trabajador = trabajador;
            cargarEmpleados();
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

        private void cargarEmpleados()
        {
            if (trabajador.isAdmin)
            {
                string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
                string sql = "select P.codigo, P.nombre, P.apellidos, F.fecha FROM Personal P, Fichajes F " +
                    "WHERE P.codigo = F.codigoUser ORDER BY Fecha desc;";
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
                label2.Visible = false;
                cbUsuario.Visible = false;
                string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
                string sql = "select P.codigo, P.nombre, P.apellidos, F.fecha FROM Personal P, Fichajes F " +
                    "WHERE P.codigo = F.codigoUser AND P.codigo = '" + trabajador.codigo + "' ORDER BY Fecha desc";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "Authors_table");
                connection.Close();

                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = ds.Tables[0];
            }

            string connectionString2 = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql2 = "select fecha FROM Fichajes Group BY Fecha;";
            SqlConnection connection2 = new SqlConnection(connectionString2);
            SqlDataAdapter dataadapter2 = new SqlDataAdapter(sql2, connection2);
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


            string sql3 = "select nombre FROM Personal;";
            SqlConnection connection3 = new SqlConnection(connectionString2);
            SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection2);
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
            if (trabajador.isAdmin)
            {
                if (cbFecha.SelectedIndex != 0)
                {
                    cbUsuario.SelectedIndex = 0;
                    string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
                    string sql = "select * FROM Fichajes F, Personal P WHERE fecha = '" + (cbFecha.SelectedItem as Fecha).ToString() + "' AND P.codigo = F.codigoUser ORDER BY Fecha desc;";
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
            else {
                if (cbFecha.SelectedIndex != 0)
                {
                    cbUsuario.SelectedIndex = 0;
                    string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
                    string sql = "select * FROM Fichajes F, Personal P WHERE fecha = '" + (cbFecha.SelectedItem as Fecha).ToString() + "' AND P.codigo = F.codigoUser AND P.codigo = '" + trabajador.codigo + "'" +
                        " ORDER BY Fecha desc;";
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

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUsuario.SelectedIndex != 0)
            {
                cbFecha.SelectedIndex = 0;
                string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
                string sql = "select * FROM Fichajes F, Personal P WHERE nombre = '" + (cbUsuario.SelectedItem as Usuario).ToString() + "' AND P.codigo = F.codigoUser ORDER BY Fecha desc;";
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
