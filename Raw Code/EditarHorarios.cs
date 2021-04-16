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
    public partial class EditarHorarios : Form
    {
        private const string NORMAL = "normal";
        private const string EDICION = "edicion";

        private string currentState;
        public EditarHorarios()
        {
            InitializeComponent();
        }

        private void EditarHorarios_Load(object sender, EventArgs e)
        {
            currentState = NORMAL;
            cargarHorarios();
            lbHorarios.SelectedIndex = 0;
        }

        private void cargarHorarios()
        {
            lbHorarios.Items.Clear();
            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql = "select * from horario";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();

            controlHorario ch = new controlHorario();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                lbHorarios.Items.Add(new Horario(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString()));
            }

            lbHorarios.SelectedIndex = 0;
        }

        private void setEstado(string estado) {
            currentState = estado;

            if (estado == EDICION)
            {
                lbTramos.Size = new Size(450, 400);
                bAceptar.Visible = true;
                bCancelar.Visible = true;

                bAnadir.Visible = false;
                bEliminar.Visible = false;
                bEditar.Visible = false;

                lbHorarios.Enabled = false;
                bTrAnadir.Visible = true;
                bTrEliminar.Visible = true;
            }
            else {
                lbTramos.Size = new Size(450, 420);
                bAceptar.Visible = false;
                bCancelar.Visible = false;

                bAnadir.Visible = true;
                bEliminar.Visible = true;
                bEditar.Visible = true;

                lbHorarios.Enabled = true;
                bTrAnadir.Visible = false;
                bTrEliminar.Visible = false;
            }

        }

        private void lbHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTramos.Items.Clear();
            //Nos conectamos a bdd
            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql = "select * from Tramos_Horarios where id=" + ((sender as ListBox).SelectedItem as Horario).id;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();

            controlHorario ch = new controlHorario();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                lbTramos.Items.Add(new Tramos(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString(), dr.ItemArray[3].ToString()));
            }
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            setEstado(EDICION);
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            setEstado(NORMAL);

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            setEstado(NORMAL);

        }

        class Horario
        {
            public string id;
            public string desc;

            public Horario(string id, string desc) {
                this.id = id;
                this.desc = desc;
            }

            public override string ToString()
            {
                return this.desc;
            }

        }

        class Tramos
        {
            public string id;
            public string Hora_Entrada;
            public string Hora_Salida;
            public string IDTramo;

            public Tramos(string id, string Hora_Entrada, string Hora_Salida, string IDTramo)
            {
                this.id = id;
                this.Hora_Entrada = Hora_Entrada;
                this.Hora_Salida = Hora_Salida;
                this.IDTramo = IDTramo;
            }

            public override string ToString()
            {
                return this.Hora_Entrada + " - " + this.Hora_Salida;
            }

        }

        private void bAnadir_Click(object sender, EventArgs e)
        {
            AnadirNuevoHorario ventanaAnadirHorario = new AnadirNuevoHorario();
            DialogResult dr = ventanaAnadirHorario.ShowDialog();

            if (dr == DialogResult.OK) {
                try
                {
                    string resultado = ventanaAnadirHorario.getText();

                    String sql = "insert into horario (descripcion) values ('" + resultado + "')";
                    using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                    {

                        using (SqlCommand querySaveStaff = new SqlCommand(sql))
                        {
                            querySaveStaff.Connection = openCon;
                            openCon.Open();

                            querySaveStaff.ExecuteNonQuery();
                        }
                    }

                    cargarHorarios();
                }
                catch {
                    Error ventanaError = new Error();
                    ventanaError.ShowDialog();
                }
            }
            
        }

        private void bTrAnadir_Click(object sender, EventArgs e)
        {
            AnadirTramo ventanaAnadirTramo = new AnadirTramo();
            DialogResult dr = ventanaAnadirTramo.ShowDialog();

            if (dr == DialogResult.OK) {
                try
                {
                    string horaEntrada = ventanaAnadirTramo.getHoraEntrada();
                    string horaSalida = ventanaAnadirTramo.getHoraSalida();
                    String sql = "insert into Tramos_Horarios (ID, [Hora Entrada], [Hora Salida]) values ('" + (lbHorarios.SelectedItem as Horario).id + "', '"+ horaEntrada +" ','"+ horaSalida +"')";
                    using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                    {

                        using (SqlCommand querySaveStaff = new SqlCommand(sql))
                        {
                            querySaveStaff.Connection = openCon;
                            openCon.Open();

                            querySaveStaff.ExecuteNonQuery();
                        }
                    }
                    int x = lbHorarios.SelectedIndex;
                    cargarHorarios();
                    lbHorarios.SelectedIndex = x;

                }
                catch (Exception ex){
                    Error ventanaError = new Error();
                    ventanaError.ShowDialog();
                }
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            ConfirmacionEliminar ventanaEliminar = new ConfirmacionEliminar();
            DialogResult dr = ventanaEliminar.ShowDialog();

            if (dr == DialogResult.OK)
            {
                try
                {
                    String sql = "Delete FROM Horario WHERE ID = " + (lbHorarios.SelectedItem as Horario).id;
                    using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                    {

                        using (SqlCommand querySaveStaff = new SqlCommand(sql))
                        {
                            querySaveStaff.Connection = openCon;
                            openCon.Open();

                            querySaveStaff.ExecuteNonQuery();
                        }
                    }

                    cargarHorarios();
                }
                catch
                {
                    Error ventanaError = new Error();
                    ventanaError.ShowDialog();
                }
            }
        }

        private void lbTramos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bTrEliminar_Click(object sender, EventArgs e)
        {
            ConfirmacionEliminar ventanaEliminar = new ConfirmacionEliminar();
            DialogResult dr = ventanaEliminar.ShowDialog();

            if (dr == DialogResult.OK)
            {
                try
                {
                    String sql = "Delete FROM Tramos_horarios WHERE IDTramo = " + (lbTramos.SelectedItem as Tramos).IDTramo;
                    using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                    {

                        using (SqlCommand querySaveStaff = new SqlCommand(sql))
                        {
                            querySaveStaff.Connection = openCon;
                            openCon.Open();

                            querySaveStaff.ExecuteNonQuery();
                        }
                    }
                    int x = lbHorarios.SelectedIndex;
                    cargarHorarios();
                    lbHorarios.SelectedIndex = x;
                }
                catch
                {
                    Error ventanaError = new Error();
                    ventanaError.ShowDialog();
                }
            }
        }
    }
}
