using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Fichajes
{
    public partial class VentanaPrincipal : Form
    {

        public VentanaPrincipal()
        {
            InitializeComponent();
            cargarNombreEmpresa();
        }

        DateTime diaAus;
        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            DialogResult dr = login.ShowDialog();
            if (dr == DialogResult.OK)
            {
                cargarTrabajador(login);
            }
            else
            {
                Application.Exit();
                return;
            }
            if (trabajador.isAdmin)
            {
                cargarHorarios();
                cargarCalendarios();
                OpcionesAdmin.Visible = true;
            }
            else
            {
                cargarHorarios();
                cargarCalendariosTrabajador();
            }

        }

        public class Trabajador
        {
            public string usuario;
            public string contrasena;
            public string calendario;
            public string codigo;
            public bool isAdmin;

            public Trabajador(string usuario, string contrasena, string calendario, string codigo)
            {
                this.usuario = usuario;
                this.contrasena = contrasena;
                this.calendario = calendario;
                this.codigo = codigo;
                if (this.calendario == "-1")
                {
                    isAdmin = true;
                }
                else {
                    isAdmin = false;
                }
            }

            public override string ToString()
            {
                return this.calendario;
            }

        }

        public Trabajador trabajador;

        private void cargarTrabajador(Login login){
            string Usuario = login.getName();
            string Contrasena = login.getPass();
            string calendario = login.getCalendario();
            string codigo = login.getCodigo();
            trabajador = new Trabajador(Usuario, Contrasena, calendario, codigo);
        }

        private void cargarCalendarios()
        {
            flowLayoutPanel2.Controls.Clear();
            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql2 = "select id, descripción," +
                "(select descripcion from horario where id = Calendario.lunes) Lunes," +
                "(select descripcion from horario where id = Calendario.martes) Martes," +
                "(select descripcion from horario where id = Calendario.miércoles) Miércoles," +
                "(select descripcion from horario where id = Calendario.jueves) Jueves," +
                "(select descripcion from horario where id = Calendario.viernes) Viernes," +
                "(select descripcion from horario where id = Calendario.sábado) Sábado," +
                "(select descripcion from horario where id = Calendario.domingo) Domingo " +
                "from Calendario";
            SqlConnection connection2 = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter2 = new SqlDataAdapter(sql2, connection2);
            DataSet ds2 = new DataSet();
            connection2.Open();
            dataadapter2.Fill(ds2, "Authors_table");
            connection2.Close();
            String IDCalenActual = "";

            controlFechas cf = new controlFechas();
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {

                if (IDCalenActual == "")
                {
                    cf.label1.Text = dr.ItemArray[1].ToString();

                }
                else if (IDCalenActual != dr.ItemArray[0].ToString())
                {
                    flowLayoutPanel2.Controls.Add(cf);
                    cf = new controlFechas();
                    cf.label1.Text = dr.ItemArray[1].ToString();;
                }

                if (dr.ItemArray[2].ToString() == "")
                {
                    cf.FestivoLun.Visible = true;
                }
                else
                {
                    Label lun = new Label();
                    lun.Text = dr.ItemArray[2].ToString();
                    cf.FLPHoraLun.Controls.Add(lun);
                    string sql3 = "select Calendario.id, Calendario.descripción, Ausencias.Fecha, Personal.nombre, Personal.apellidos, " +
                    " (select descripcion from horario where id = Calendario.lunes) Lunes " +
                    " from Calendario, Ausencias, Personal" +
                    " Where Calendario.ID = Ausencias.IDCalendario AND Personal.IDCalendario = Ausencias.IDCalendario AND Personal.codigo = Ausencias.CodigoPersonal";
                    SqlConnection connection3 = new SqlConnection(connectionString);
                    SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection3);
                    DataSet ds3 = new DataSet();
                    connection3.Open();
                    dataadapter3.Fill(ds3, "Authors_table");
                    connection3.Close();
                    foreach (DataRow dr2 in ds3.Tables[0].Rows) {
                        diaAus = Convert.ToDateTime(dr2.ItemArray[2].ToString());
                        if (diaAus.DayOfWeek == DayOfWeek.Monday) {
                            if (dr.ItemArray[0].ToString() == dr2.ItemArray[0].ToString())
                            {
                                if (DateTime.Now <= diaAus)
                                {
                                    Label ausLun = new Label();
                                    ausLun.AutoSize = true;
                                    ausLun.Text = dr2.ItemArray[3].ToString() + " " + dr2.ItemArray[4].ToString() + Environment.NewLine + Convert.ToDateTime(dr2.ItemArray[2]).ToString("dd/MM/yy");
                                    cf.FLPAusLun.Controls.Add(ausLun);
                                }
                            }
                        }
                    }

                }

                if (dr.ItemArray[3].ToString() == "")
                {
                    cf.FestivoMar.Visible = true;
                }
                else
                {
                    Label mar = new Label();
                    mar.Text = dr.ItemArray[3].ToString();
                    cf.FLPHoraMar.Controls.Add(mar);
                    string sql3 = "select Calendario.id, Calendario.descripción, Ausencias.Fecha, Personal.nombre, Personal.apellidos, " +
                    " (select descripcion from horario where id = Calendario.lunes) Lunes " +
                    " from Calendario, Ausencias, Personal" +
                    " Where Calendario.ID = Ausencias.IDCalendario AND Personal.IDCalendario = Ausencias.IDCalendario AND Personal.codigo = Ausencias.CodigoPersonal";
                    SqlConnection connection3 = new SqlConnection(connectionString);
                    SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection3);
                    DataSet ds3 = new DataSet();
                    connection3.Open();
                    dataadapter3.Fill(ds3, "Authors_table");
                    connection3.Close();
                    foreach (DataRow dr2 in ds3.Tables[0].Rows)
                    {
                        diaAus = Convert.ToDateTime(dr2.ItemArray[2].ToString());
                        if (diaAus.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            if (dr.ItemArray[0].ToString() == dr2.ItemArray[0].ToString())
                            {
                                if (DateTime.Now <= diaAus)
                                {
                                    Label ausLun = new Label();
                                    ausLun.AutoSize = true;
                                    ausLun.Text = dr2.ItemArray[3].ToString() + " " + dr2.ItemArray[4].ToString() + Environment.NewLine + Convert.ToDateTime(dr2.ItemArray[2]).ToString("dd/MM/yy");
                                    cf.FLPAusMar.Controls.Add(ausLun);
                                }
                            }
                        }
                    }
                }

                if (dr.ItemArray[4].ToString() == "")
                {
                    cf.FestivoMie.Visible = true;
                }
                else
                {
                    Label mie = new Label();
                    mie.Text = dr.ItemArray[4].ToString();
                    cf.FLPHoraMie.Controls.Add(mie);
                    string sql3 = "select Calendario.id, Calendario.descripción, Ausencias.Fecha, Personal.nombre, Personal.apellidos, " +
                    " (select descripcion from horario where id = Calendario.lunes) Lunes " +
                    " from Calendario, Ausencias, Personal" +
                    " Where Calendario.ID = Ausencias.IDCalendario AND Personal.IDCalendario = Ausencias.IDCalendario AND Personal.codigo = Ausencias.CodigoPersonal";
                    SqlConnection connection3 = new SqlConnection(connectionString);
                    SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection3);
                    DataSet ds3 = new DataSet();
                    connection3.Open();
                    dataadapter3.Fill(ds3, "Authors_table");
                    connection3.Close();
                    foreach (DataRow dr2 in ds3.Tables[0].Rows)
                    {
                        diaAus = Convert.ToDateTime(dr2.ItemArray[2].ToString());
                        if (diaAus.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            if (dr.ItemArray[0].ToString() == dr2.ItemArray[0].ToString())
                            {
                                if (DateTime.Now <= diaAus)
                                {
                                    Label ausLun = new Label();
                                    ausLun.AutoSize = true;
                                    ausLun.Text = dr2.ItemArray[3].ToString() + " " + dr2.ItemArray[4].ToString() + Environment.NewLine + Convert.ToDateTime(dr2.ItemArray[2]).ToString("dd/MM/yy");
                                    cf.FLPAusMie.Controls.Add(ausLun);
                                }
                            }
                        }
                    }
                }

                if (dr.ItemArray[5].ToString() == "")
                {
                    cf.FestivoJue.Visible = true;
                }
                else
                {
                    Label jue = new Label();
                    jue.Text = dr.ItemArray[5].ToString();
                    cf.FLPHoraJue.Controls.Add(jue);
                    string sql3 = "select Calendario.id, Calendario.descripción, Ausencias.Fecha, Personal.nombre, Personal.apellidos, " +
                    " (select descripcion from horario where id = Calendario.lunes) Lunes " +
                    " from Calendario, Ausencias, Personal" +
                    " Where Calendario.ID = Ausencias.IDCalendario AND Personal.IDCalendario = Ausencias.IDCalendario AND Personal.codigo = Ausencias.CodigoPersonal";
                    SqlConnection connection3 = new SqlConnection(connectionString);
                    SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection3);
                    DataSet ds3 = new DataSet();
                    connection3.Open();
                    dataadapter3.Fill(ds3, "Authors_table");
                    connection3.Close();
                    foreach (DataRow dr2 in ds3.Tables[0].Rows)
                    {
                        diaAus = Convert.ToDateTime(dr2.ItemArray[2].ToString());
                        if (diaAus.DayOfWeek == DayOfWeek.Thursday)
                        {
                            if (dr.ItemArray[0].ToString() == dr2.ItemArray[0].ToString())
                            {
                                if (DateTime.Now <= diaAus)
                                {
                                    Label ausLun = new Label();
                                    ausLun.AutoSize = true;
                                    ausLun.Text = dr2.ItemArray[3].ToString() + " " + dr2.ItemArray[4].ToString() + Environment.NewLine + Convert.ToDateTime(dr2.ItemArray[2]).ToString("dd/MM/yy");
                                    cf.FLPAusJue.Controls.Add(ausLun);
                                }
                            }
                        }
                    }
                }

                if (dr.ItemArray[6].ToString() == "")
                {
                    cf.FestivoVie.Visible = true;
                }
                else
                {
                    Label vie = new Label();
                    vie.Text = dr.ItemArray[6].ToString();
                    cf.FLPHoraVie.Controls.Add(vie);
                    string sql3 = "select Calendario.id, Calendario.descripción, Ausencias.Fecha, Personal.nombre, Personal.apellidos, " +
                    " (select descripcion from horario where id = Calendario.lunes) Lunes " +
                    " from Calendario, Ausencias, Personal" +
                    " Where Calendario.ID = Ausencias.IDCalendario AND Personal.IDCalendario = Ausencias.IDCalendario AND Personal.codigo = Ausencias.CodigoPersonal";
                    SqlConnection connection3 = new SqlConnection(connectionString);
                    SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection3);
                    DataSet ds3 = new DataSet();
                    connection3.Open();
                    dataadapter3.Fill(ds3, "Authors_table");
                    connection3.Close();
                    foreach (DataRow dr2 in ds3.Tables[0].Rows)
                    {
                        diaAus = Convert.ToDateTime(dr2.ItemArray[2].ToString());
                        if (diaAus.DayOfWeek == DayOfWeek.Friday)
                        {
                            if (dr.ItemArray[0].ToString() == dr2.ItemArray[0].ToString())
                            {
                                if (DateTime.Now <= diaAus)
                                {
                                    Label ausLun = new Label();
                                    ausLun.AutoSize = true;
                                    ausLun.Text = dr2.ItemArray[3].ToString() + " " + dr2.ItemArray[4].ToString() + Environment.NewLine + Convert.ToDateTime(dr2.ItemArray[2]).ToString("dd/MM/yy");
                                    cf.FLPAusVie.Controls.Add(ausLun);
                                }
                            }
                        }
                    }
                }

                if (dr.ItemArray[7].ToString() == "")
                {
                    cf.FestivoSab.Visible = true;
                }
                else
                {
                    Label sab = new Label();
                    sab.Text = dr.ItemArray[7].ToString();
                    cf.FLPHoraSab.Controls.Add(sab);
                    string sql3 = "select Calendario.id, Calendario.descripción, Ausencias.Fecha, Personal.nombre, Personal.apellidos, " +
                    " (select descripcion from horario where id = Calendario.lunes) Lunes " +
                    " from Calendario, Ausencias, Personal" +
                    " Where Calendario.ID = Ausencias.IDCalendario AND Personal.IDCalendario = Ausencias.IDCalendario AND Personal.codigo = Ausencias.CodigoPersonal";
                    SqlConnection connection3 = new SqlConnection(connectionString);
                    SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection3);
                    DataSet ds3 = new DataSet();
                    connection3.Open();
                    dataadapter3.Fill(ds3, "Authors_table");
                    connection3.Close();
                    foreach (DataRow dr2 in ds3.Tables[0].Rows)
                    {
                        diaAus = Convert.ToDateTime(dr2.ItemArray[2].ToString());
                        if (diaAus.DayOfWeek == DayOfWeek.Saturday)
                        {
                            if (dr.ItemArray[0].ToString() == dr2.ItemArray[0].ToString())
                            {
                                if (DateTime.Now <= diaAus)
                                {
                                    Label ausLun = new Label();
                                    ausLun.AutoSize = true;
                                    ausLun.Text = dr2.ItemArray[3].ToString() + " " + dr2.ItemArray[4].ToString() + Environment.NewLine + Convert.ToDateTime(dr2.ItemArray[2]).ToString("dd/MM/yy");
                                    cf.FLPAusSab.Controls.Add(ausLun);
                                }
                            }
                        }
                    }
                }

                if (dr.ItemArray[8].ToString() == "")
                {
                    cf.FestivoDom.Visible = true;
                }
                else
                {
                    Label dom = new Label();
                    dom.Text = dr.ItemArray[8].ToString();
                    cf.FLPHoraDom.Controls.Add(dom);
                    string sql3 = "select Calendario.id, Calendario.descripción, Ausencias.Fecha, Personal.nombre, Personal.apellidos, " +
                    " (select descripcion from horario where id = Calendario.lunes) Lunes " +
                    " from Calendario, Ausencias, Personal" +
                    " Where Calendario.ID = Ausencias.IDCalendario AND Personal.IDCalendario = Ausencias.IDCalendario AND Personal.codigo = Ausencias.CodigoPersonal";
                    SqlConnection connection3 = new SqlConnection(connectionString);
                    SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection3);
                    DataSet ds3 = new DataSet();
                    connection3.Open();
                    dataadapter3.Fill(ds3, "Authors_table");
                    connection3.Close();
                    foreach (DataRow dr2 in ds3.Tables[0].Rows)
                    {
                        diaAus = Convert.ToDateTime(dr2.ItemArray[2].ToString());
                        if (diaAus.DayOfWeek == DayOfWeek.Sunday)
                        {
                            if (dr.ItemArray[0].ToString() == dr2.ItemArray[0].ToString())
                            {
                                if (DateTime.Now <= diaAus)
                                {
                                    Label ausLun = new Label();
                                    ausLun.AutoSize = true;
                                    ausLun.Text = dr2.ItemArray[3].ToString() + " " + dr2.ItemArray[4].ToString() + Environment.NewLine + Convert.ToDateTime(dr2.ItemArray[2]).ToString("dd/MM/yy");
                                    cf.FLPAusDom.Controls.Add(ausLun);
                                }
                            }
                        }
                    }
                }

                IDCalenActual = dr.ItemArray[0].ToString();
            }

            if (ds2.Tables[0].Rows.Count > 0)
            {
                flowLayoutPanel2.Controls.Add(cf);
            }
        }

        private void cargarCalendariosTrabajador()
        {
            flowLayoutPanel2.Controls.Clear();
            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql2 = "select id, descripción," +
                "(select descripcion from horario where id = Calendario.lunes) Lunes," +
                "(select descripcion from horario where id = Calendario.martes) Martes," +
                "(select descripcion from horario where id = Calendario.miércoles) Miércoles," +
                "(select descripcion from horario where id = Calendario.jueves) Jueves," +
                "(select descripcion from horario where id = Calendario.viernes) Viernes," +
                "(select descripcion from horario where id = Calendario.sábado) Sábado," +
                "(select descripcion from horario where id = Calendario.domingo) Domingo " +
                "from Calendario " +
                "WHERE id = '" + (trabajador).calendario + "'";
            SqlConnection connection2 = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter2 = new SqlDataAdapter(sql2, connection2);
            DataSet ds2 = new DataSet();
            connection2.Open();
            dataadapter2.Fill(ds2, "Authors_table");
            connection2.Close();
            String IDCalenActual = "";

            controlFechas cf = new controlFechas();
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {

                if (IDCalenActual == "")
                {
                    cf.label1.Text = dr.ItemArray[1].ToString();

                }
                else if (IDCalenActual != dr.ItemArray[0].ToString())
                {
                    flowLayoutPanel2.Controls.Add(cf);
                    cf = new controlFechas();
                    cf.label1.Text = dr.ItemArray[1].ToString(); ;
                }

                if (dr.ItemArray[2].ToString() == "")
                {
                    cf.FestivoLun.Visible = true;
                }
                else
                {
                    Label lun = new Label();
                    lun.Text = dr.ItemArray[2].ToString();
                    cf.FLPHoraLun.Controls.Add(lun);
                    string sql3 = "select Calendario.id, Calendario.descripción, Ausencias.Fecha, Personal.nombre, Personal.apellidos, " +
                                        " (select descripcion from horario where id = Calendario.lunes) Lunes " +
                                        " from Calendario, Ausencias, Personal" +
                                        " Where Calendario.ID = Ausencias.IDCalendario AND Personal.IDCalendario = Ausencias.IDCalendario AND Personal.codigo = Ausencias.CodigoPersonal";
                    SqlConnection connection3 = new SqlConnection(connectionString);
                    SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection3);
                    DataSet ds3 = new DataSet();
                    connection3.Open();
                    dataadapter3.Fill(ds3, "Authors_table");
                    connection3.Close();
                    foreach (DataRow dr2 in ds3.Tables[0].Rows)
                    {
                        diaAus = Convert.ToDateTime(dr2.ItemArray[2].ToString());
                        if (diaAus.DayOfWeek == DayOfWeek.Monday)
                        {
                            if (dr.ItemArray[0].ToString() == dr2.ItemArray[0].ToString())
                            {
                                if (DateTime.Now <= diaAus)
                                {
                                    Label ausLun = new Label();
                                    ausLun.AutoSize = true;
                                    ausLun.Text = dr2.ItemArray[3].ToString() + " " + dr2.ItemArray[4].ToString() + Environment.NewLine + Convert.ToDateTime(dr2.ItemArray[2]).ToString("dd/MM/yy");
                                    cf.FLPAusLun.Controls.Add(ausLun);
                                }
                            }
                        }
                    }
                }

                if (dr.ItemArray[3].ToString() == "")
                {
                    cf.FestivoMar.Visible = true;
                }
                else
                {
                    Label mar = new Label();
                    mar.Text = dr.ItemArray[3].ToString();
                    cf.FLPHoraMar.Controls.Add(mar);
                    string sql3 = "select Calendario.id, Calendario.descripción, Ausencias.Fecha, Personal.nombre, Personal.apellidos, " +
                    " (select descripcion from horario where id = Calendario.lunes) Lunes " +
                    " from Calendario, Ausencias, Personal" +
                    " Where Calendario.ID = Ausencias.IDCalendario AND Personal.IDCalendario = Ausencias.IDCalendario AND Personal.codigo = Ausencias.CodigoPersonal";
                    SqlConnection connection3 = new SqlConnection(connectionString);
                    SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection3);
                    DataSet ds3 = new DataSet();
                    connection3.Open();
                    dataadapter3.Fill(ds3, "Authors_table");
                    connection3.Close();
                    foreach (DataRow dr2 in ds3.Tables[0].Rows)
                    {
                        diaAus = Convert.ToDateTime(dr2.ItemArray[2].ToString());
                        if (diaAus.DayOfWeek == DayOfWeek.Tuesday)
                        {
                            if (dr.ItemArray[0].ToString() == dr2.ItemArray[0].ToString())
                            {
                                if (DateTime.Now <= diaAus)
                                {
                                    Label ausLun = new Label();
                                    ausLun.AutoSize = true;
                                    ausLun.Text = dr2.ItemArray[3].ToString() + " " + dr2.ItemArray[4].ToString() + Environment.NewLine + Convert.ToDateTime(dr2.ItemArray[2]).ToString("dd/MM/yy");
                                    cf.FLPAusMar.Controls.Add(ausLun);
                                }
                            }
                        }
                    }
                }

                if (dr.ItemArray[4].ToString() == "")
                {
                    cf.FestivoMie.Visible = true;
                }
                else
                {
                    Label mie = new Label();
                    mie.Text = dr.ItemArray[4].ToString();
                    cf.FLPHoraMie.Controls.Add(mie);
                    string sql3 = "select Calendario.id, Calendario.descripción, Ausencias.Fecha, Personal.nombre, Personal.apellidos, " +
                    " (select descripcion from horario where id = Calendario.lunes) Lunes " +
                    " from Calendario, Ausencias, Personal" +
                    " Where Calendario.ID = Ausencias.IDCalendario AND Personal.IDCalendario = Ausencias.IDCalendario AND Personal.codigo = Ausencias.CodigoPersonal";
                    SqlConnection connection3 = new SqlConnection(connectionString);
                    SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection3);
                    DataSet ds3 = new DataSet();
                    connection3.Open();
                    dataadapter3.Fill(ds3, "Authors_table");
                    connection3.Close();
                    foreach (DataRow dr2 in ds3.Tables[0].Rows)
                    {
                        diaAus = Convert.ToDateTime(dr2.ItemArray[2].ToString());
                        if (diaAus.DayOfWeek == DayOfWeek.Wednesday)
                        {
                            if (dr.ItemArray[0].ToString() == dr2.ItemArray[0].ToString())
                            {
                                if (DateTime.Now <= diaAus)
                                {
                                    Label ausLun = new Label();
                                    ausLun.AutoSize = true;
                                    ausLun.Text = dr2.ItemArray[3].ToString() + " " + dr2.ItemArray[4].ToString() + Environment.NewLine + Convert.ToDateTime(dr2.ItemArray[2]).ToString("dd/MM/yy");
                                    cf.FLPAusMie.Controls.Add(ausLun);
                                }
                            }
                        }
                    }
                }

                if (dr.ItemArray[5].ToString() == "")
                {
                    cf.FestivoJue.Visible = true;
                }
                else
                {
                    Label jue = new Label();
                    jue.Text = dr.ItemArray[5].ToString();
                    cf.FLPHoraJue.Controls.Add(jue);
                    string sql3 = "select Calendario.id, Calendario.descripción, Ausencias.Fecha, Personal.nombre, Personal.apellidos, " +
                    " (select descripcion from horario where id = Calendario.lunes) Lunes " +
                    " from Calendario, Ausencias, Personal" +
                    " Where Calendario.ID = Ausencias.IDCalendario AND Personal.IDCalendario = Ausencias.IDCalendario AND Personal.codigo = Ausencias.CodigoPersonal";
                    SqlConnection connection3 = new SqlConnection(connectionString);
                    SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection3);
                    DataSet ds3 = new DataSet();
                    connection3.Open();
                    dataadapter3.Fill(ds3, "Authors_table");
                    connection3.Close();
                    foreach (DataRow dr2 in ds3.Tables[0].Rows)
                    {
                        diaAus = Convert.ToDateTime(dr2.ItemArray[2].ToString());
                        if (diaAus.DayOfWeek == DayOfWeek.Thursday)
                        {
                            if (dr.ItemArray[0].ToString() == dr2.ItemArray[0].ToString())
                            {
                                if (DateTime.Now <= diaAus)
                                {
                                    Label ausLun = new Label();
                                    ausLun.AutoSize = true;
                                    ausLun.Text = dr2.ItemArray[3].ToString() + " " + dr2.ItemArray[4].ToString() + Environment.NewLine + Convert.ToDateTime(dr2.ItemArray[2]).ToString("dd/MM/yy");
                                    cf.FLPAusJue.Controls.Add(ausLun);
                                }
                            }
                        }
                    }
                }

                if (dr.ItemArray[6].ToString() == "")
                {
                    cf.FestivoVie.Visible = true;
                }
                else
                {
                    Label vie = new Label();
                    vie.Text = dr.ItemArray[6].ToString();
                    cf.FLPHoraVie.Controls.Add(vie);
                    string sql3 = "select Calendario.id, Calendario.descripción, Ausencias.Fecha, Personal.nombre, Personal.apellidos, " +
                    " (select descripcion from horario where id = Calendario.lunes) Lunes " +
                    " from Calendario, Ausencias, Personal" +
                    " Where Calendario.ID = Ausencias.IDCalendario AND Personal.IDCalendario = Ausencias.IDCalendario AND Personal.codigo = Ausencias.CodigoPersonal";
                    SqlConnection connection3 = new SqlConnection(connectionString);
                    SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection3);
                    DataSet ds3 = new DataSet();
                    connection3.Open();
                    dataadapter3.Fill(ds3, "Authors_table");
                    connection3.Close();
                    foreach (DataRow dr2 in ds3.Tables[0].Rows)
                    {
                        diaAus = Convert.ToDateTime(dr2.ItemArray[2].ToString());
                        if (diaAus.DayOfWeek == DayOfWeek.Friday)
                        {
                            if (dr.ItemArray[0].ToString() == dr2.ItemArray[0].ToString())
                            {
                                if (DateTime.Now <= diaAus)
                                {
                                    Label ausLun = new Label();
                                    ausLun.AutoSize = true;
                                    ausLun.Text = dr2.ItemArray[3].ToString() + " " + dr2.ItemArray[4].ToString() + Environment.NewLine + Convert.ToDateTime(dr2.ItemArray[2]).ToString("dd/MM/yy");
                                    cf.FLPAusVie.Controls.Add(ausLun);
                                }
                            }
                        }
                    }
                }

                if (dr.ItemArray[7].ToString() == "")
                {
                    cf.FestivoSab.Visible = true;
                }
                else
                {
                    Label sab = new Label();
                    sab.Text = dr.ItemArray[7].ToString();
                    cf.FLPHoraSab.Controls.Add(sab);
                    string sql3 = "select Calendario.id, Calendario.descripción, Ausencias.Fecha, Personal.nombre, Personal.apellidos, " +
                    " (select descripcion from horario where id = Calendario.lunes) Lunes " +
                    " from Calendario, Ausencias, Personal" +
                    " Where Calendario.ID = Ausencias.IDCalendario AND Personal.IDCalendario = Ausencias.IDCalendario AND Personal.codigo = Ausencias.CodigoPersonal";
                    SqlConnection connection3 = new SqlConnection(connectionString);
                    SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection3);
                    DataSet ds3 = new DataSet();
                    connection3.Open();
                    dataadapter3.Fill(ds3, "Authors_table");
                    connection3.Close();
                    foreach (DataRow dr2 in ds3.Tables[0].Rows)
                    {
                        diaAus = Convert.ToDateTime(dr2.ItemArray[2].ToString());
                        if (diaAus.DayOfWeek == DayOfWeek.Saturday)
                        {
                            if (dr.ItemArray[0].ToString() == dr2.ItemArray[0].ToString())
                            {
                                if (DateTime.Now <= diaAus)
                                {
                                    Label ausLun = new Label();
                                    ausLun.AutoSize = true;
                                    ausLun.Text = dr2.ItemArray[3].ToString() + " " + dr2.ItemArray[4].ToString() + Environment.NewLine + Convert.ToDateTime(dr2.ItemArray[2]).ToString("dd/MM/yy");
                                    cf.FLPAusSab.Controls.Add(ausLun);
                                }
                            }
                        }
                    }
                }

                if (dr.ItemArray[8].ToString() == "")
                {
                    cf.FestivoDom.Visible = true;
                }
                else
                {
                    Label dom = new Label();
                    dom.Text = dr.ItemArray[8].ToString();
                    cf.FLPHoraDom.Controls.Add(dom);
                    string sql3 = "select Calendario.id, Calendario.descripción, Ausencias.Fecha, Personal.nombre, Personal.apellidos, " +
                    " (select descripcion from horario where id = Calendario.lunes) Lunes " +
                    " from Calendario, Ausencias, Personal" +
                    " Where Calendario.ID = Ausencias.IDCalendario AND Personal.IDCalendario = Ausencias.IDCalendario AND Personal.codigo = Ausencias.CodigoPersonal";
                    SqlConnection connection3 = new SqlConnection(connectionString);
                    SqlDataAdapter dataadapter3 = new SqlDataAdapter(sql3, connection3);
                    DataSet ds3 = new DataSet();
                    connection3.Open();
                    dataadapter3.Fill(ds3, "Authors_table");
                    connection3.Close();
                    foreach (DataRow dr2 in ds3.Tables[0].Rows)
                    {
                        diaAus = Convert.ToDateTime(dr2.ItemArray[2].ToString());
                        if (diaAus.DayOfWeek == DayOfWeek.Sunday)
                        {
                            if (dr.ItemArray[0].ToString() == dr2.ItemArray[0].ToString())
                            {
                                if (DateTime.Now <= diaAus)
                                {
                                    Label ausLun = new Label();
                                    ausLun.AutoSize = true;
                                    ausLun.Text = dr2.ItemArray[3].ToString() + " " + dr2.ItemArray[4].ToString() + Environment.NewLine + Convert.ToDateTime(dr2.ItemArray[2]).ToString("dd/MM/yy");
                                    cf.FLPAusDom.Controls.Add(ausLun);
                                }
                            }
                        }
                    }
                }

                IDCalenActual = dr.ItemArray[0].ToString();
            }

            if (ds2.Tables[0].Rows.Count > 0)
            {
                flowLayoutPanel2.Controls.Add(cf);
            }
        }


        private void cargarHorarios()
        {
            flowLayoutPanel1.Controls.Clear();
            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql = "SELECT * FROM Horario, Tramos_Horarios WHERE Tramos_Horarios.ID = Horario.ID Order BY Tramos_Horarios.IDTramo";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            string IDActual = "";

            controlHorario ch = new controlHorario();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                if (IDActual == "")
                {
                    ch.label1.Text = dr.ItemArray[1].ToString();
                }
                else if (IDActual != dr.ItemArray[0].ToString())
                {
                    flowLayoutPanel1.Controls.Add(ch);
                    ch = new controlHorario();
                    ch.label1.Text = dr.ItemArray[1].ToString();
                }

                Label l = new Label();
                l.Text = dr.ItemArray[3].ToString() + " - " + dr.ItemArray[4].ToString();
                ch.flowLayoutPanel1.Controls.Add(l);

                IDActual = dr.ItemArray[0].ToString();
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                flowLayoutPanel1.Controls.Add(ch);
            }
        }



        private void EditarCalendario_Click(object sender, EventArgs e)
        {
            EditarCalendarios ventanaCalendario = new EditarCalendarios();
            ventanaCalendario.ShowDialog();
            cargarCalendarios();
        }

        private void ConsultarHoras_Click(object sender, EventArgs e)
        {
            ConsultaHorasTrabajadas ventanaHorasTrabajadas = new ConsultaHorasTrabajadas(trabajador);
            ventanaHorasTrabajadas.ShowDialog();
        }

        private void CalculoHorasFichajes_Click(object sender, EventArgs e)
        {
            HorasDiaFichaje ventanaHorasAlDia = new HorasDiaFichaje();
            ventanaHorasAlDia.ShowDialog();
        }

        private void Fichar_Click(object sender, EventArgs e)
        {
            ModuloFichaje ventanaFichaje = new ModuloFichaje(trabajador);
            ventanaFichaje.ShowDialog();
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void GestionAusencias_Click(object sender, EventArgs e)
        {
            GestionAusencias ventanaAusencias = new GestionAusencias(trabajador);
            ventanaAusencias.ShowDialog();
            if (trabajador.isAdmin)
            {
                cargarCalendarios();
            }
            else {
                cargarCalendariosTrabajador();
            }
        }

        private void ConsultaFichajes_Click(object sender, EventArgs e)
        {
            ConsultaFichajes ventanaConsultaFichajes = new ConsultaFichajes(trabajador);
            ventanaConsultaFichajes.ShowDialog();
        }

        private void SaldoTiempo_Click(object sender, EventArgs e)
        {
            SaldoTiempo ventanaSaldoTiempo = new SaldoTiempo(trabajador);
            ventanaSaldoTiempo.ShowDialog();
        }

        private void EditarNotificaciones_Click(object sender, EventArgs e)
        {
            ConfigurarNotificaciones ventanaConfigurarNotificaciones = new ConfigurarNotificaciones();
            ventanaConfigurarNotificaciones.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditarPlantilla_Click(object sender, EventArgs e)
        {
            Plantilla ventanaPlantilla = new Plantilla(trabajador);
            ventanaPlantilla.ShowDialog();
        }

        private void EditarHorario_Click(object sender, EventArgs e)
        {
            EditarHorarios ventanaHorario = new EditarHorarios();
            ventanaHorario.ShowDialog();
            cargarHorarios();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        private void ConsultarAusencias_Click(object sender, EventArgs e)
        {
            ConsultaAusencias ventanaAusencias = new ConsultaAusencias(trabajador);
            ventanaAusencias.ShowDialog();
        }

        private void bAuditoria_Click(object sender, EventArgs e)
        {
            Auditoria ventanaAuditoria = new Auditoria();
            ventanaAuditoria.ShowDialog();
        }

        private void bInfoEmpresa_Click(object sender, EventArgs e)
        {
            InfoEmpresa ventanaInfo = new InfoEmpresa(trabajador);
            ventanaInfo.ShowDialog();
            cargarNombreEmpresa();
        }

        private void cargarNombreEmpresa()
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
                labelNombre.Text = dr.ItemArray[1].ToString();
            }

        }
    }
}
