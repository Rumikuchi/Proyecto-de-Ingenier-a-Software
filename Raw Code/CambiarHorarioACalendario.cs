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
    public partial class CambiarHorarioACalendario : Form
    {
        EditarCalendarios.Calendario Calendar;
        
        public CambiarHorarioACalendario(EditarCalendarios.Calendario Calendar)
        {
            InitializeComponent();
            this.Calendar = Calendar;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CambiarHorarioACalendario_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql = "select * from horario";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();

            controlHorario ch = new controlHorario();

            //Añadir Horario Vacío (Festivo)
            cbLunes.Items.Add(new Horario("-1", ""));
            cbMartes.Items.Add(new Horario("-1", ""));
            cbMiercoles.Items.Add(new Horario("-1", ""));
            cbJueves.Items.Add(new Horario("-1", ""));
            cbViernes.Items.Add(new Horario("-1", ""));
            cbSabado.Items.Add(new Horario("-1", ""));
            cbDomingo.Items.Add(new Horario("-1", ""));

            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                //Añadir Horarios de DB
                cbLunes.Items.Add(new Horario(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString()));
                cbMartes.Items.Add(new Horario(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString()));
                cbMiercoles.Items.Add(new Horario(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString()));
                cbJueves.Items.Add(new Horario(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString()));
                cbViernes.Items.Add(new Horario(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString()));
                cbSabado.Items.Add(new Horario(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString()));
                cbDomingo.Items.Add(new Horario(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString()));
            }

            //Buscamos el horario de cada día y si no tiene, seleccionamos el 0 por defecto.
            int cuentaLunes = 0;
            cbLunes.SelectedIndex = 0;
            foreach (Horario item in cbLunes.Items)
            {
                if (item.id == Calendar.lun) {
                    cbLunes.SelectedIndex = cuentaLunes;
                }
                cuentaLunes++;
            }

            int cuentaMartes = 0;
            cbMartes.SelectedIndex = 0;
            foreach (Horario item in cbMartes.Items)
            {
                if (item.id == Calendar.mar)
                {
                    cbMartes.SelectedIndex = cuentaMartes;
                }
                cuentaMartes++;
            }

            int cuentaMiercoles = 0;
            cbMiercoles.SelectedIndex = 0;
            foreach (Horario item in cbMiercoles.Items)
            {
                if (item.id == Calendar.mie)
                {
                    cbMiercoles.SelectedIndex = cuentaMiercoles;
                }
                cuentaMiercoles++;
            }

            int cuentaJueves = 0;
            cbJueves.SelectedIndex = 0;
            foreach (Horario item in cbJueves.Items)
            {
                if (item.id == Calendar.jue)
                {
                    cbJueves.SelectedIndex = cuentaJueves;
                }
                cuentaJueves++;
            }

            int cuentaViernes = 0;
            cbViernes.SelectedIndex = 0;
            foreach (Horario item in cbViernes.Items)
            {
                if (item.id == Calendar.vie)
                {
                    cbViernes.SelectedIndex = cuentaViernes;
                }
                cuentaViernes++;
            }

            int cuentaSabado = 0;
            cbSabado.SelectedIndex = 0;
            foreach (Horario item in cbSabado.Items)
            {
                if (item.id == Calendar.sab)
                {
                    cbSabado.SelectedIndex = cuentaSabado;
                }
                cuentaSabado++;
            }
            
            int cuentaDomingo = 0;
            cbDomingo.SelectedIndex = 0;
            foreach (Horario item in cbDomingo.Items)
            {
                if (item.id == Calendar.dom)
                {
                    cbDomingo.SelectedIndex = cuentaDomingo;
                }
                cuentaDomingo++;
            }

        }

        class Horario {
            public string id;
            public string descripcion;

            public Horario(string id, string descripcion) {

                this.id = id;
                this.descripcion = descripcion;
            }
            public override string ToString()
            {
                return descripcion;
            }
        }

        public string getHoraLun()
        {
            return (cbLunes.SelectedItem as Horario).id;
        }

        public string getHoraMar()
        {
            return (cbMartes.SelectedItem as Horario).id;
        }

        public string getHoraMie()
        {
            return (cbMiercoles.SelectedItem as Horario).id;
        }

        public string getHoraJue()
        {
            return (cbJueves.SelectedItem as Horario).id;
        }

        public string getHoraVie()
        {
            return (cbViernes.SelectedItem as Horario).id;
        }

        public string getHoraSab()
        {
            return (cbSabado.SelectedItem as Horario).id;
        }

        public string getHoraDom()
        {
            return (cbDomingo.SelectedItem as Horario).id;
        }

        private void cbLunes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
