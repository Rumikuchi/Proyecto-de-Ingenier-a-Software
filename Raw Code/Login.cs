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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            RecuperarContra ventanaRecuperar = new RecuperarContra();
            ventanaRecuperar.ShowDialog();
        }

        public string getName()
        {
            return textBox1.Text;
        }

        public string getPass()
        {
            return textBox2.Text;
        }

        private string IDCalendario;
        private string codigo;
        public String getCalendario() { 
            return IDCalendario;
        }

        public String getCodigo() {
            return codigo;
        }

        private void loginDataBase() {
            string Usuario = getName();
            string Contraseña = getPass();
            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql = "select usuario, contraseña, IDCalendario, codigo from Personal Where usuario ='" + Usuario + "' AND contraseña ='" + Contraseña +"'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            int Control = 0;
            

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Control = 1;
                if (Usuario == dr.ItemArray[0].ToString())
                {
                    if (Contraseña == dr.ItemArray[1].ToString())
                    {
                        IDCalendario = dr.ItemArray[2].ToString();
                        codigo = dr.ItemArray[3].ToString();
                        DialogResult = DialogResult.OK;
                        return;
                    }
                    else {
                        Incorrecto ventanaIncorrecto = new Incorrecto();
                        ventanaIncorrecto.ShowDialog();
                    }
                }
                else
                {
                    Incorrecto ventanaIncorrecto = new Incorrecto();
                    ventanaIncorrecto.ShowDialog();
                }
            }

            if (Control == 0) { 
                    Incorrecto ventanaIncorrecto = new Incorrecto();
                    ventanaIncorrecto.ShowDialog();
            }

        }

        private void bEntrar_Click(object sender, EventArgs e)
        {
            loginDataBase();            
        }
    }
}
