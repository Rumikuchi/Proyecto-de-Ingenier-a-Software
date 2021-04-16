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
    public partial class InfoEmpresa : Form
    {
        DateTime fecha;
        public Trabajador trabajador;
        public InfoEmpresa(Trabajador trabajador)
        {
            InitializeComponent();
            cargarInfo();
            this.trabajador = trabajador;
        }

        private void cargarInfo() {
            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql = "select * from Empresa";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                labelNombre.Text = dr.ItemArray[1].ToString();
                labelDireccion.Text = dr.ItemArray[2].ToString();
                labelCP.Text = dr.ItemArray[5].ToString();
                labelTelf.Text = dr.ItemArray[3].ToString();
                labelMail.Text = dr.ItemArray[4].ToString();

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            EditarEmpresa ventanaEditarEmpresa = new EditarEmpresa();
            DialogResult dres = ventanaEditarEmpresa.ShowDialog();

            if (dres == DialogResult.OK)
            {
                try
                {
                    string telefono = ventanaEditarEmpresa.getTelefono();
                    string mail = ventanaEditarEmpresa.getCorreo();
                    string nombre = ventanaEditarEmpresa.getNombre();
                    string direccion = ventanaEditarEmpresa.getDireccion();
                    string CP = ventanaEditarEmpresa.getCP();

                    string sql = "UPDATE Empresa " +
                             "SET nombre = '" + nombre + "' " + ",direccion = '" + direccion + "' " + ",numTelf = '" + telefono + "' " + ",mail = '" + mail + "' " +
                             ",CP = '" + CP + "';";
                    using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                    {

                        using (SqlCommand querySaveStaff = new SqlCommand(sql))
                        {
                            querySaveStaff.Connection = openCon;
                            openCon.Open();

                            querySaveStaff.ExecuteNonQuery();
                        }
                    }

                    fecha = DateTime.Now;
                    sql = "insert into Auditoria (queHizo, fecha, usuario) values ('Editó información de la empresa','" + fecha + "','" + trabajador.usuario + "')";
                    using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                    {

                        using (SqlCommand querySaveStaff = new SqlCommand(sql))
                        {
                            querySaveStaff.Connection = openCon;
                            openCon.Open();

                            querySaveStaff.ExecuteNonQuery();
                        }
                    }

                    cargarInfo();
                }
                catch (Exception ex)
                {
                    Error ventanaError = new Error();
                    ventanaError.ShowDialog();
                }
            }
        }
    }
}
