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
    public partial class AnadirEmpleado : Form
    {
        public AnadirEmpleado()
        {
            InitializeComponent();
        }

        public string getNombre()
        {
            return tbNombre.Text;
        }

        public string getApellidos()
        {
            return tbApellidos.Text;
        }

        public string getDNI()
        {
            return tbDNI.Text;
        }

        public string getTelefono()
        {
            return tbTelf.Text;
        }
        public string getMail()
        {
            return tbMail.Text;
        }
        public string getRango()
        {
            return tbRango.Text;
        }
        public string getCalendario()
        {
            return (cbCalendario.SelectedItem as Calendario).id;
        }
        public string getUsuario()
        {
            return tbUsuario.Text;
        }
        public string getContrasena()
        {
            return tbContra.Text;
        }

        class Calendario
        {
            public string id;
            public string descripcion;

            public Calendario(string id, string descripcion)
            {

                this.id = id;
                this.descripcion = descripcion;
            }
            public override string ToString()
            {
                return descripcion;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AnadirEmpleado_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql = "select * from calendario";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                //Añadir Calendarios de DB
                cbCalendario.Items.Add(new Calendario(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString()));

            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
