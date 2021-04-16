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
    public partial class EditarEmpresa : Form
    {
        public EditarEmpresa()
        {
            InitializeComponent();
            cargarInfo();
        }

        private void cargarInfo()
        {
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
                tbNombre.Text = dr.ItemArray[1].ToString();
                tbDireccion.Text = dr.ItemArray[2].ToString();
                tbCP.Text = dr.ItemArray[5].ToString();
                tbTelf.Text = dr.ItemArray[3].ToString();
                tbCorreo.Text = dr.ItemArray[4].ToString();
            }
        }

        public string getTelefono()
        {
            return tbTelf.Text;
        }

        public string getNombre()
        {
            return tbNombre.Text;
        }

        public string getDireccion()
        {
            return tbDireccion.Text;
        }

        public string getCP()
        {
            return tbCP.Text;
        }
        public string getCorreo()
        {
            return tbCorreo.Text;
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
