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
    public partial class EditarCalendarios : Form
    {
        private const string NORMAL = "normal";
        private const string EDICION = "edicion";

        private string currentState;

        public EditarCalendarios()
        {
            InitializeComponent();
        }

        private void EditarCalendarios_Load_1(object sender, EventArgs e)
        {
            currentState = NORMAL;
            cargarCalendarios();

        }

        public class Calendario
        {
            public string id;
            public string desc;
            public string horaLun;
            public string horaMar;
            public string horaMie;
            public string horaJue;
            public string horaVie;
            public string horaSab;
            public string horaDom;

            public string lun;
            public string mar;
            public string mie;
            public string jue;
            public string vie;
            public string sab;
            public string dom;

            public Calendario(string id, string desc,
                string lun, string horaLun
                , string mar, string horaMar
                , string mie, string horaMie
                , string jue, string horaJue
                , string vie, string horaVie
                , string sab, string horaSab
                , string dom, string horaDom)
            {
                this.id = id;
                this.desc = desc;
                this.horaLun = horaLun;
                this.horaMar = horaMar;
                this.horaMie = horaMie;
                this.horaJue = horaJue;
                this.horaVie = horaVie;
                this.horaSab = horaSab;
                this.horaDom = horaDom;

                this.lun = lun;
                this.mar = mar;
                this.mie = mie;
                this.jue = jue;
                this.vie = vie;
                this.sab = sab;
                this.dom = dom;

            }

            public override string ToString()
            {
                return "Calendario de " + this.desc + "  Lunes: " + this.horaLun + "  Martes: " + this.horaMar + "  Miércoles: " + this.horaMie + "  Jueves: " + this.horaJue +
                    "  Viernes: " + this.horaVie + "  Sábado: " + this.horaSab + "  Domingo: " + this.horaDom;
            }

        }

        
        private void cargarCalendarios()
        {
            lbCalendarios.Items.Clear();
            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql = "select id, descripción," +
                "lunes,(select descripcion from horario where id = Calendario.lunes) Lunes," +
                "martes,(select descripcion from horario where id = Calendario.martes) Martes," +
                "miércoles,(select descripcion from horario where id = Calendario.miércoles) Miércoles," +
                "jueves,(select descripcion from horario where id = Calendario.jueves) Jueves," +
                "viernes,(select descripcion from horario where id = Calendario.viernes) Viernes," +
                "Sábado,(select descripcion from horario where id = Calendario.sábado) Sábado," +
                "domingo,(select descripcion from horario where id = Calendario.domingo) Domingo " +
                "from Calendario";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                lbCalendarios.Items.Add(new Calendario(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString(), dr.ItemArray[3].ToString(), dr.ItemArray[4].ToString()
                    , dr.ItemArray[5].ToString(), dr.ItemArray[6].ToString(), dr.ItemArray[7].ToString(), dr.ItemArray[8].ToString(), dr.ItemArray[9].ToString(), dr.ItemArray[10].ToString(), dr.ItemArray[11].ToString()
                    , dr.ItemArray[12].ToString(), dr.ItemArray[13].ToString(), dr.ItemArray[14].ToString(), dr.ItemArray[15].ToString()));
            }

            lbCalendarios.SelectedIndex = 0;
        }


        private void lbCalendarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void bAñadir_Click(object sender, EventArgs e)
        {
            AnadirNuevoCalendario ventanaNuevoCalendario = new AnadirNuevoCalendario();
            DialogResult dr = ventanaNuevoCalendario.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    string resultado = ventanaNuevoCalendario.getText();

                    String sql = "insert into Calendario (descripción) values ('" + resultado + "')";
                    using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                    {

                        using (SqlCommand querySaveStaff = new SqlCommand(sql))
                        {
                            querySaveStaff.Connection = openCon;
                            openCon.Open();

                            querySaveStaff.ExecuteNonQuery();
                        }
                    }

                    cargarCalendarios();
                }
                catch
                {
                    Error ventanaError = new Error();
                    ventanaError.ShowDialog();
                }
            }

        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            CambiarHorarioACalendario ventanaCambiarHorario = new CambiarHorarioACalendario(lbCalendarios.SelectedItem as Calendario);
            DialogResult dr = ventanaCambiarHorario.ShowDialog();

            if (dr == DialogResult.OK)
            {
                try
                {
                    string horaLunes = ventanaCambiarHorario.getHoraLun();
                    string horaMartes = ventanaCambiarHorario.getHoraMar();
                    string horaMiercoles = ventanaCambiarHorario.getHoraMie();
                    string horaJueves = ventanaCambiarHorario.getHoraJue();
                    string horaViernes = ventanaCambiarHorario.getHoraVie();
                    string horaSabado = ventanaCambiarHorario.getHoraSab();
                    string horaDomingo = ventanaCambiarHorario.getHoraDom();


                    String sql = "UPDATE Calendario " +
                             "SET Lunes = '" +horaLunes+ "' " + ",Martes = '" + horaMartes + "' " + ",Miércoles = '" + horaMiercoles + "' " + ",Jueves = '" + horaJueves + "' " +
                             ",Viernes = '" + horaViernes + "' " + ",Sábado = '" + horaSabado + "' " + ",Domingo = '" + horaDomingo + "' " +
                             "WHERE ID = " + (lbCalendarios.SelectedItem as Calendario).id;
                    using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                    {

                        using (SqlCommand querySaveStaff = new SqlCommand(sql))
                        {
                            querySaveStaff.Connection = openCon;
                            openCon.Open();

                            querySaveStaff.ExecuteNonQuery();
                        }
                    }

                    cargarCalendarios();
                }
                catch (Exception ex)
                {
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
                    String sql = "Delete FROM Calendario WHERE ID = " + (lbCalendarios.SelectedItem as Calendario).id;
                    using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                    {

                        using (SqlCommand querySaveStaff = new SqlCommand(sql))
                        {
                            querySaveStaff.Connection = openCon;
                            openCon.Open();

                            querySaveStaff.ExecuteNonQuery();
                        }
                    }

                    cargarCalendarios();
                }
                catch
                {
                    Error ventanaError = new Error();
                    ventanaError.ShowDialog();
                }
            }
        }

        private void bHrAnadir_Click(object sender, EventArgs e)
        {
           
        }

        private void bAceptar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
