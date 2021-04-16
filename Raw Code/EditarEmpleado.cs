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
    public partial class EditarEmpleado : Form
    {
        Plantilla.Empleado empleado;

        public EditarEmpleado(Plantilla.Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;

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


        private void cargarInfo()
        {
            labelNombre.Text = empleado.nombre;
            labelApellidos.Text = empleado.apellidos;
            tbTelf.Text = empleado.telefono;
            tbMail.Text = empleado.mail;
            tbRango.Text = empleado.rango;
            tbUsuario.Text = empleado.usuario;
            tbContra.Text = empleado.contraseña;

            cbCalendario.SelectedIndex = 0;
            foreach (Calendario item in cbCalendario.Items)
            {
                if (item.id == empleado.IDCalendario)
                {
                    cbCalendario.SelectedItem = item;
                }
            }
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
            if (empleado.IDCalendario == "-1")
            {
                return "-1";
            }
            else
            {
                return (cbCalendario.SelectedItem as Calendario).id;
            }
        }
        public string getUsuario()
        {
            return tbUsuario.Text;
        }
        public string getContrasena()
        {
            return tbContra.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void EditarEmpleado_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql = "select * from calendario";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();

            //Añadir Calendario Vacío
            cbCalendario.Items.Add(new Calendario("", ""));


            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                //Añadir Calendarios de DB
                cbCalendario.Items.Add(new Calendario(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString()));

            }

            cargarInfo();
   

        }

        private void cbCalendario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
