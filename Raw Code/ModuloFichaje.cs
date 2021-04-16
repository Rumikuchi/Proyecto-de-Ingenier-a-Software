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
    public partial class ModuloFichaje : Form
    {
        private const string NORMAL = "normal";
        private const string SERVICIO = "servicio";


        private string currentState;
        int botonFichar = 0;
        int horario = 0;

        DateTime hInicio;
        DateTime hFin;
        TimeSpan tiempoTrabajado;
        DateTime horaFicharEntrada;

        public Trabajador trabajador;
        public ModuloFichaje(Trabajador trabajador)
        {
            InitializeComponent();
            this.trabajador = trabajador;

        }

        private void Fichar_Load(object sender, EventArgs e)
        {
            cargarHorario();
            comprobarEstadoFichaje();
        }

        private void setEstado(string estado)
        {
            currentState = estado;

            if (estado == SERVICIO)
            {
                turnoEmpieza.Visible = false;
                turnoFinaliza.Visible = true;
                horaEntrada.Visible = false;
                horaSalida.Visible = true;

                deServicio.Visible = true;
                tiempoServicio.Visible = true;
                tiempoServicio.Text = "00:00:00";

                timerSeg.Enabled = true;

            }
            else
            {
                turnoEmpieza.Visible = true;
                turnoFinaliza.Visible = false;
                horaEntrada.Visible = true;
                horaSalida.Visible = false;

                deServicio.Visible = false;
                tiempoServicio.Visible = false;

                timerSeg.Enabled = false;
            }

        }

        private void comprobarEstadoFichaje() {
            string sql = "SELECT servicio FROM personal WHERE usuario = '" + trabajador.usuario + "';";
            SqlConnection connection = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;");
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                bool estadoFicha = bool.Parse(dr.ItemArray[0].ToString());
                if (estadoFicha == false)
                {
                    setEstado(NORMAL);
                }
                else
                {
                    setEstado(SERVICIO);
                }
            }
        }

        private void Fichar_Click(object sender, EventArgs e)
        {
            if (currentState == NORMAL)
            {
                if (DateTime.Now.Hour >= int.Parse(horaEntrada.Text.Split(':')[0]))
                {
                    if (DateTime.Now.Hour >= int.Parse(horaEntrada.Text.Split(':')[1]))
                    {
                        String sql = "Update personal Set servicio = '1' where usuario = '" + trabajador.usuario + "';";
                        using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                        {

                            using (SqlCommand querySaveStaff = new SqlCommand(sql))
                            {
                                querySaveStaff.Connection = openCon;
                                openCon.Open();

                                querySaveStaff.ExecuteNonQuery();
                            }
                        }

                        hInicio = DateTime.Now;
                        sql = "INSERT INTO Fichajes (codigoUser, Hora, fecha) values ('"+trabajador.codigo+"','" + hInicio + "','" +hInicio + "') ";
                        using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                        {

                            using (SqlCommand querySaveStaff = new SqlCommand(sql))
                            {
                                querySaveStaff.Connection = openCon;
                                openCon.Open();

                                querySaveStaff.ExecuteNonQuery();
                            }
                        }

                        setEstado(SERVICIO);
                        noEntrar.Visible = false;
                    }
                    else
                    {
                        noEntrar.Visible = true;
                        botonFichar = 0;
                    }
                }
                else
                {
                    noEntrar.Visible = true;
                    botonFichar = 0;
                }
            }
            else if (currentState == SERVICIO)
            {
                if (DateTime.Now.Hour >= int.Parse(horaSalida.Text.Split(':')[0]))
                {
                    if (DateTime.Now.Hour >= int.Parse(horaSalida.Text.Split(':')[1]))
                    {
                        String sql = "Update personal Set servicio = '0' where usuario = '" + trabajador.usuario + "';";
                        using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                        {

                            using (SqlCommand querySaveStaff = new SqlCommand(sql))
                            {
                                querySaveStaff.Connection = openCon;
                                openCon.Open();

                                querySaveStaff.ExecuteNonQuery();
                            }
                        }

                        int cont = 0;
                        string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
                        string sql3 = "select * FROM Fichajes WHERE codigoUser = '" + trabajador.codigo +"' ORDER BY Hora desc";
                        SqlConnection connection3 = new SqlConnection(connectionString);
                        SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection3);
                        DataSet ds3 = new DataSet();
                        connection3.Open();
                        dataadapter3.Fill(ds3, "Authors_table");
                        connection3.Close();
                        foreach (DataRow dr2 in ds3.Tables[0].Rows)
                        {
                            if (cont == 0)
                            {
                                cont = 1;
                                horaFicharEntrada = Convert.ToDateTime(dr2.ItemArray[1].ToString());
                            }
                        }

                        setEstado(NORMAL);
                        botonFichar = 0;
                        hFin = DateTime.Now;
                        sql = "INSERT INTO Fichajes (codigoUser, Hora, fecha) values ('" + trabajador.codigo + "','" + hFin + "','" +hFin + "') ";
                        using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                        {

                            using (SqlCommand querySaveStaff = new SqlCommand(sql))
                            {
                                querySaveStaff.Connection = openCon;
                                openCon.Open();

                                querySaveStaff.ExecuteNonQuery();
                            }
                        }


                        tiempoTrabajado = hFin - horaFicharEntrada;
                        sql = "INSERT INTO Saldo_Tiempo (codigoPersonal, tiempoTrabajado, fecha) values ('" + trabajador.codigo + "','" + int.Parse(Math.Round(tiempoTrabajado.TotalSeconds).ToString()) + "','" + hInicio +"') ";
                        using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                        {

                            using (SqlCommand querySaveStaff = new SqlCommand(sql))
                            {
                                querySaveStaff.Connection = openCon;
                                openCon.Open();

                                querySaveStaff.ExecuteNonQuery();
                            }
                        }

                        noSalir.Visible = false;
                    }
                    else
                    {
                        noSalir.Visible = true;
                        botonFichar = 1;
                    }
                }
                else
                {
                    noSalir.Visible = true;
                    botonFichar = 1;
                }

            }

        }

        private void timerSeg_Tick(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;
            string sql = "SELECT hora FROM fichajes WHERE codigoUser = '" + trabajador.codigo + "' Order By Hora, Fecha Asc;";
            SqlConnection connection = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;");
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DateTime horaFichaje = DateTime.Parse(dr.ItemArray[0].ToString());
                TimeSpan diff = now - horaFichaje;
                var str = string.Format("{0:00}:{1:00}:{2:00}", diff.Hours, diff.Minutes, diff.Seconds);
                tiempoServicio.Text = str;
            }

        } 


        private void timerActual_Tick_1(object sender, EventArgs e)
        {
            horaActual.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void cargarHorario()
        {
            if (trabajador.isAdmin)
            {
                horaEntrada.Text = "00:00";
                horaSalida.Text = "00:00";
            }

            else { 
                string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
                switch (DateTime.Now.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        string sql = "SELECT * FROM Horario, Tramos_Horarios, Calendario WHERE Tramos_Horarios.ID = Horario.ID AND "+ trabajador.calendario +
                            " = Calendario.id AND Calendario.Lunes = Horario.ID Order BY Tramos_Horarios.IDTramo";
                        SqlConnection connection = new SqlConnection(connectionString);
                        SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                        DataSet ds = new DataSet();
                        connection.Open();
                        dataadapter.Fill(ds, "Authors_table");
                        connection.Close();
                        string IDActual = "";


                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            if (horario == 0)
                            {
                                horaEntrada.Text = dr.ItemArray[3].ToString();
                                horario++;
                            }
                            else
                            {
                                horaSalida.Text = dr.ItemArray[4].ToString();
                            }
                        }
                        break;
                
                    case DayOfWeek.Tuesday:
                        string sqlMar = "SELECT * FROM Horario, Tramos_Horarios, Calendario WHERE Tramos_Horarios.ID = Horario.ID AND " + trabajador.calendario +
                        " = Calendario.id AND Calendario.Martes = Horario.ID Order BY Tramos_Horarios.IDTramo";
                        SqlConnection connectionMar = new SqlConnection(connectionString);
                        SqlDataAdapter dataadapterMar = new SqlDataAdapter(sqlMar, connectionMar);
                        DataSet dsMar = new DataSet();
                        connectionMar.Open();
                        dataadapterMar.Fill(dsMar, "Authors_table");
                        connectionMar.Close();
                        string IDActualMar = "";

                        controlHorario chMar = new controlHorario();
                        foreach (DataRow dr in dsMar.Tables[0].Rows)
                        {
                            if (horario == 0)
                            {
                                horaEntrada.Text = dr.ItemArray[3].ToString();
                                horario++;
                            }
                            else
                            {
                                horaSalida.Text = dr.ItemArray[4].ToString();
                            }
                        }
                        break;

                    case DayOfWeek.Wednesday:
                        string sqlMie = "SELECT * FROM Horario, Tramos_Horarios, Calendario WHERE Tramos_Horarios.ID = Horario.ID AND " + trabajador.calendario +
                        " = Calendario.id AND Calendario.Miércoles = Horario.ID Order BY Tramos_Horarios.IDTramo";
                        SqlConnection connectionMie = new SqlConnection(connectionString);
                        SqlDataAdapter dataadapterMie = new SqlDataAdapter(sqlMie, connectionMie);
                        DataSet dsMie = new DataSet();
                        connectionMie.Open();
                        dataadapterMie.Fill(dsMie, "Authors_table");
                        connectionMie.Close();
                        string IDActualMie = "";

                        controlHorario chMie = new controlHorario();
                        foreach (DataRow dr in dsMie.Tables[0].Rows)
                        {
                            if (horario == 0)
                            {
                                horaEntrada.Text = dr.ItemArray[3].ToString();
                                horario++;
                            }
                            else
                            {
                                horaSalida.Text = dr.ItemArray[4].ToString();
                            }
                        }
                        break;

                    case DayOfWeek.Thursday:
                        string sqlJue = "SELECT * FROM Horario, Tramos_Horarios, Calendario WHERE Tramos_Horarios.ID = Horario.ID AND " + trabajador.calendario +
                        " = Calendario.id AND Calendario.Jueves = Horario.ID Order BY Tramos_Horarios.IDTramo";
                        SqlConnection connectionJue = new SqlConnection(connectionString);
                        SqlDataAdapter dataadapterJue = new SqlDataAdapter(sqlJue, connectionJue);
                        DataSet dsJue = new DataSet();
                        connectionJue.Open();
                        dataadapterJue.Fill(dsJue, "Authors_table");
                        connectionJue.Close();
                        string IDActualJue = "";

                        controlHorario chJue = new controlHorario();
                        foreach (DataRow dr in dsJue.Tables[0].Rows)
                        {
                            if (horario == 0)
                            {
                                horaEntrada.Text = dr.ItemArray[3].ToString();
                                horario++;
                            }
                            else
                            {
                                horaSalida.Text = dr.ItemArray[4].ToString();
                            }
                        }
                        break;


                    case DayOfWeek.Friday:
                        string sqlVie = "SELECT * FROM Horario, Tramos_Horarios, Calendario WHERE Tramos_Horarios.ID = Horario.ID AND " + trabajador.calendario +
                        " = Calendario.id AND Calendario.Viernes = Horario.ID Order BY Tramos_Horarios.IDTramo";
                        SqlConnection connectionVie = new SqlConnection(connectionString);
                        SqlDataAdapter dataadapterVie = new SqlDataAdapter(sqlVie, connectionVie);
                        DataSet dsVie = new DataSet();
                        connectionVie.Open();
                        dataadapterVie.Fill(dsVie, "Authors_table");
                        connectionVie.Close();
                        string IDActualVie = "";

                        controlHorario chVie = new controlHorario();
                        foreach (DataRow dr in dsVie.Tables[0].Rows)
                        {
                            if (horario == 0)
                            {
                                horaEntrada.Text = dr.ItemArray[3].ToString();
                                horario++;
                            }
                            else
                            {
                                horaSalida.Text = dr.ItemArray[4].ToString();
                            }
                        }
                        break;


                    case DayOfWeek.Saturday:
                        string sqlSab = "SELECT * FROM Horario, Tramos_Horarios, Calendario WHERE Tramos_Horarios.ID = Horario.ID AND " + trabajador.calendario +
                        " = Calendario.id AND Calendario.Sábado = Horario.ID Order BY Tramos_Horarios.IDTramo";
                        SqlConnection connectionSab = new SqlConnection(connectionString);
                        SqlDataAdapter dataadapterSab = new SqlDataAdapter(sqlSab, connectionSab);
                        DataSet dsSab = new DataSet();
                        connectionSab.Open();
                        dataadapterSab.Fill(dsSab, "Authors_table");
                        connectionSab.Close();
                        string IDActualSab = "";

                        controlHorario chSab = new controlHorario();
                        foreach (DataRow dr in dsSab.Tables[0].Rows)
                        {
                            if (horario == 0)
                            {
                                horaEntrada.Text = dr.ItemArray[3].ToString();
                                horario++;
                            }
                            else
                            { 
                                horaSalida.Text = dr.ItemArray[4].ToString();
                            }
                        }
                        break;


                    case DayOfWeek.Sunday:
                        string sqlDom = "SELECT * FROM Horario, Tramos_Horarios, Calendario WHERE Tramos_Horarios.ID = Horario.ID AND " + trabajador.calendario +
                        " = Calendario.id AND Calendario.Domingo = Horario.ID Order BY Tramos_Horarios.IDTramo";
                        SqlConnection connectionDom = new SqlConnection(connectionString);
                        SqlDataAdapter dataadapterDom = new SqlDataAdapter(sqlDom, connectionDom);
                        DataSet dsDom = new DataSet();
                        connectionDom.Open();
                        dataadapterDom.Fill(dsDom, "Authors_table");
                        connectionDom.Close();
                        string IDActualDom = "";

                        controlHorario chDom = new controlHorario();
                        foreach (DataRow dr in dsDom.Tables[0].Rows)
                        {
                            if (horario == 0)
                            {
                                horaEntrada.Text = dr.ItemArray[3].ToString();
                                horario++;
                            }
                            else
                            {
                                horaSalida.Text = dr.ItemArray[4].ToString();
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }


            }


        }


        private void horaActual_Click(object sender, EventArgs e)
        {

        }

    }
}
