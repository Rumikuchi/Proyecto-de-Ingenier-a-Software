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
    public partial class Plantilla : Form
    {
        public Trabajador trabajador;

        public Plantilla(Trabajador trabajador)
        {
            InitializeComponent();
            cargarEmpleados();
            this.trabajador = trabajador;
        }


        DateTime fecha;
        private void Plantilla_Load(object sender, EventArgs e)
        {
            dataGridView.CellContentClick += new DataGridViewCellEventHandler(DataGridView_CellClick);
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int cIndex = e.ColumnIndex;

            if (cIndex == 3)//Servicio
            {
                bool activado = bool.Parse(dataGridView.Rows[index].Cells[cIndex].Value.ToString());
                if (activado == true)
                {
                    DialogResult dres = MessageBox.Show("¿Desea sacar de servicio al usuario?","Aceptar",MessageBoxButtons.YesNo);
                    if (dres == DialogResult.Yes) {
                        String codigo = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                        String sql = "Update personal Set servicio = '0' where codigo = " + codigo + ";";
                        using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                        {

                            using (SqlCommand querySaveStaff = new SqlCommand(sql))
                            {
                                querySaveStaff.Connection = openCon;
                                openCon.Open();

                                querySaveStaff.ExecuteNonQuery();
                            }
                        }

                        DateTime hInicio = DateTime.Now;
                        sql = "INSERT INTO Fichajes (codigoUser, Hora, fecha) values ('" + codigo + "','" + hInicio + "','" +hInicio + "') ";
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
                        sql = "insert into Auditoria (queHizo, fecha, usuario) values ('Sacó de servicio a un empleado','" + fecha + "','" + trabajador.usuario + "')";
                        using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                        {

                            using (SqlCommand querySaveStaff = new SqlCommand(sql))
                            {
                                querySaveStaff.Connection = openCon;
                                openCon.Open();

                                querySaveStaff.ExecuteNonQuery();
                            }
                        }

                        sql = "INSERT INTO Saldo_Tiempo (codigoPersonal, tiempoTrabajado, fecha) values ('" + codigo + "','14400','" + hInicio +"') ";
                        using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                        {

                            using (SqlCommand querySaveStaff = new SqlCommand(sql))
                            {
                                querySaveStaff.Connection = openCon;
                                openCon.Open();

                                querySaveStaff.ExecuteNonQuery();
                            }
                        }

                        cargarEmpleados();
                    } 

                } else
                {
                    DialogResult dres = MessageBox.Show("¿Desea poner de servicio al usuario?", "Aceptar", MessageBoxButtons.YesNo);
                    if (dres == DialogResult.Yes)
                    {
                        String codigo = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                        String sql = "Update personal Set servicio = '1' where codigo = " + codigo + ";";
                        using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                        {

                            using (SqlCommand querySaveStaff = new SqlCommand(sql))
                            {
                                querySaveStaff.Connection = openCon;
                                openCon.Open();

                                querySaveStaff.ExecuteNonQuery();
                            }
                        }

                        DateTime hInicio = DateTime.Now;
                        sql = "INSERT INTO Fichajes (codigoUser, Hora, fecha) values ('" + codigo + "','" + hInicio + "','" +hInicio + "') ";
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
                        sql = "insert into Auditoria (queHizo, fecha, usuario) values ('Puso de servicio a un empleado ','" + fecha + "','" + trabajador.usuario + "')";
                        using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                        {

                            using (SqlCommand querySaveStaff = new SqlCommand(sql))
                            {
                                querySaveStaff.Connection = openCon;
                                openCon.Open();

                                querySaveStaff.ExecuteNonQuery();
                            }
                        }

                        cargarEmpleados();
                    }

                }
            }
            else if (cIndex == 4)//Responsable
            {
                int activado = int.Parse(dataGridView.Rows[index].Cells[cIndex].Value.ToString());
                if (activado == 1)
                {
                    if (MinimoResponsables()) 
                    {
                        MessageBox.Show("Tiene que haber, como mínimo, un responsable.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else 
                    {
                        DialogResult dres = MessageBox.Show("¿Desea quitar de responsable al usuario?", "Confirmar", MessageBoxButtons.YesNo);
                        if (dres == DialogResult.Yes)
                        {
                            String codigo = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                            String sql = "Update personal Set IDCalendario = '0' where codigo = " + codigo + ";";
                            using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                            {

                                using (SqlCommand querySaveStaff = new SqlCommand(sql))
                                {
                                    querySaveStaff.Connection = openCon;
                                    openCon.Open();

                                    querySaveStaff.ExecuteNonQuery();
                                }
                            }
                            MessageBox.Show("Recuerde asignar un calendario a este usuario", "Recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            fecha = DateTime.Now;
                            sql = "insert into Auditoria (queHizo, fecha, usuario) values ('Quitó de responsable a un empleado','" + fecha + "','" + trabajador.usuario + "')";
                            using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                            {

                                using (SqlCommand querySaveStaff = new SqlCommand(sql))
                                {
                                    querySaveStaff.Connection = openCon;
                                    openCon.Open();

                                    querySaveStaff.ExecuteNonQuery();
                                }
                            }

                            cargarEmpleados();
                        }
                    }
                }
                else 
                {
                    DialogResult dres = MessageBox.Show("¿Desea poner de responsable al usuario?", "Confirmar", MessageBoxButtons.YesNo);
                    if (dres == DialogResult.Yes)
                    {
                        String codigo = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                        String sql = "Update personal Set IDCalendario = '-1' where codigo = " + codigo + ";";
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
                        sql = "insert into Auditoria (queHizo, fecha, usuario) values ('Puso de responsable a un empleado','" + fecha + "','" + trabajador.usuario + "')";
                        using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                        {

                            using (SqlCommand querySaveStaff = new SqlCommand(sql))
                            {
                                querySaveStaff.Connection = openCon;
                                openCon.Open();

                                querySaveStaff.ExecuteNonQuery();
                            }
                        }

                        cargarEmpleados();
                    }
                }
                
            }

        }

        private bool MinimoResponsables()
        {
            int cnt = 0;
            foreach (DataGridViewRow dr in dataGridView.Rows) {
                if (int.Parse(dr.Cells[4].Value.ToString()) == 1)
                {
                    cnt++;
                }
            }
            if(cnt > 1)
            {
                return false;
            }
            return true;
        }

        public class Empleado
        {
            public string dni;
            public string codigo;
            public string nombre;
            public string apellidos;
            public string telefono;
            public string mail;
            public string rango;
            public string IDCalendario;
            public string usuario;
            public string contraseña;


            public Empleado(string dni, string codigo,
                string nombre, string apellidos
                , string telefono, string mail
                , string rango, string IDCalendario
                , string usuario, string contraseña)
            {
                this.dni = dni;
                this.codigo = codigo;
                this.nombre = nombre;
                this.apellidos = apellidos;
                this.telefono = telefono;
                this.mail = mail;
                this.rango = rango;
                this.IDCalendario = IDCalendario;
                this.usuario = usuario;
                this.contraseña = contraseña;

            }
            public override string ToString()
            {
                return "Nombre: " + this.nombre + " " + this.apellidos + "  DNI: " + this.dni + "  Rango: " + this.rango + "  Teléfono: " + this.telefono;
            }

        }
        private void cargarEmpleados()
        {
            //lbEmpleados.Items.Clear();
            string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
            string sql = "select codigo, nombre, apellidos, servicio,  case when IDCalendario = -1 then 1 else 0 end as Responsable FROM Personal ORDER BY codigo";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = ds.Tables[0];


        }

        private void bAñadir_Click(object sender, EventArgs e)
        {
            AnadirEmpleado ventanaAnadirEmpleado = new AnadirEmpleado();
            DialogResult dr = ventanaAnadirEmpleado.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    string nombre = ventanaAnadirEmpleado.getNombre();
                    string apellidos = ventanaAnadirEmpleado.getApellidos();
                    string dni = ventanaAnadirEmpleado.getDNI();
                    string telefono = ventanaAnadirEmpleado.getTelefono();
                    string mail = ventanaAnadirEmpleado.getMail();
                    string rango = ventanaAnadirEmpleado.getRango();
                    string IDCalendario = ventanaAnadirEmpleado.getCalendario();
                    string usuario = ventanaAnadirEmpleado.getUsuario();
                    string contrasena = ventanaAnadirEmpleado.getContrasena();

                    String sql = "insert into Personal (dni, nombre, apellidos, telefono, mail, rango, IDCalendario, usuario, contraseña, servicio) values ('" + dni + "','" + nombre + "','"
                        + apellidos +"','" + telefono + "','" + mail + "','" + rango + "','" + IDCalendario + "','" + usuario + "','" + contrasena + "','0')";
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
                    sql = "insert into Auditoria (queHizo, fecha, usuario) values ('Añadió un empleado','" + fecha + "','" + trabajador.usuario + "')";
                    using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                    {

                        using (SqlCommand querySaveStaff = new SqlCommand(sql))
                        {
                            querySaveStaff.Connection = openCon;
                            openCon.Open();

                            querySaveStaff.ExecuteNonQuery();
                        }
                    }

                    cargarEmpleados();
                }
                catch
                {
                    Error ventanaError = new Error();
                    ventanaError.ShowDialog();
                }
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows != null)
            {
                ConfirmacionEliminar ventanaEliminar = new ConfirmacionEliminar();
                DialogResult dr = ventanaEliminar.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    try
                    {
                        String codigo = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                        String sql = "DELETE FROM Personal WHERE codigo =" + codigo ;
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
                        sql = "insert into Auditoria (queHizo, fecha, usuario) values ('Eliminó un empleado','" + fecha + "','" + trabajador.usuario + "')";
                        using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                        {

                            using (SqlCommand querySaveStaff = new SqlCommand(sql))
                            {
                                querySaveStaff.Connection = openCon;
                                openCon.Open();

                                querySaveStaff.ExecuteNonQuery();
                            }
                        }

                        cargarEmpleados();
                    }
                    catch
                    {
                        Error ventanaError = new Error();
                        ventanaError.ShowDialog();
                    }
                }
            }
        }

        private void bEditar_Click(object sender, EventArgs e)
        {

            if (dataGridView.SelectedRows != null)
            {
                String codigo = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                String sql = "Select * from personal where codigo = '" + codigo + "';";
                SqlConnection connection = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;");
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "Authors_table");
                connection.Close();

                Empleado empleado = null;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    empleado = new Empleado(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString(), dr.ItemArray[3].ToString(), dr.ItemArray[4].ToString()
                        , dr.ItemArray[5].ToString(), dr.ItemArray[6].ToString(), dr.ItemArray[7].ToString(), dr.ItemArray[8].ToString(), dr.ItemArray[9].ToString());
                }

                EditarEmpleado ventanaEditarEmpleado = new EditarEmpleado(empleado);
                DialogResult dres = ventanaEditarEmpleado.ShowDialog();

                if (dres == DialogResult.OK)
                {
                    try
                    {
                        string telefono = ventanaEditarEmpleado.getTelefono();
                        string mail = ventanaEditarEmpleado.getMail();
                        string rango = ventanaEditarEmpleado.getRango();
                        string IDCalendario = ventanaEditarEmpleado.getCalendario();
                        string usuario = ventanaEditarEmpleado.getUsuario();
                        string contrasena = ventanaEditarEmpleado.getContrasena();

                        sql = "UPDATE Personal " +
                                 "SET telefono = '" + telefono + "' " + ",mail = '" + mail + "' " + ",rango = '" + rango + "' " + ",IDCalendario = '" + IDCalendario + "' " +
                                 ",usuario = '" + usuario + "' " + ",contraseña = '" + contrasena + "' where codigo = '" + codigo + "';";
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
                        sql = "insert into Auditoria (queHizo, fecha, usuario) values ('Editó un empleado','" + fecha + "','" + trabajador.usuario + "')";
                        using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                        {

                            using (SqlCommand querySaveStaff = new SqlCommand(sql))
                            {
                                querySaveStaff.Connection = openCon;
                                openCon.Open();

                                querySaveStaff.ExecuteNonQuery();
                            }
                        }

                        cargarEmpleados();
                    }
                    catch (Exception ex)
                    {
                        Error ventanaError = new Error();
                        ventanaError.ShowDialog();
                    }
                }
            }            
        }

        private void lbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
