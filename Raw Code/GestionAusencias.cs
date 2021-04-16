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
    public partial class GestionAusencias : Form
    {
        public Trabajador trabajador;
        DateTime fecha;
        public GestionAusencias(Trabajador trabajador)
        {
            InitializeComponent();
            this.trabajador = trabajador;
            cargarAusencias();
        }

        private void bSolicitar_Click(object sender, EventArgs e)
        {
            SolicitarAusencia ventanaSolAus = new SolicitarAusencia();
            DialogResult dres = ventanaSolAus.ShowDialog();

            if (dres == DialogResult.OK)
            {
                try
                {
                    string motivo = ventanaSolAus.getMotivo();
                    DateTime Fecha = ventanaSolAus.getFecha();
                    if (DateTime.Now > Fecha)
                    {
                        MessageBox.Show("No se puede solicitar una ausencia en días pasados.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        String sql = "Insert Into Ausencias (CodigoPersonal, IDCalendario, Causa, Fecha) values ('" + trabajador.codigo + "','" + trabajador.calendario + "','" + motivo + "','" + Fecha + "')";
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
                        sql = "insert into Auditoria (queHizo, fecha, usuario) values ('Pidió una ausencia','" + fecha + "','" + trabajador.usuario + "')";
                        using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                        {

                            using (SqlCommand querySaveStaff = new SqlCommand(sql))
                            {
                                querySaveStaff.Connection = openCon;
                                openCon.Open();

                                querySaveStaff.ExecuteNonQuery();
                            }
                        }
                    }
                    cargarAusencias();
                }

                catch (Exception ex)
                {
                    Error ventanaError = new Error();
                    ventanaError.ShowDialog();
                }
            }

        }

        private void bRetirar_Click(object sender, EventArgs e)
        {
            

            if (dataGridView.SelectedRows != null)
            {
                ConfirmacionEliminar ventanaEliminar = new ConfirmacionEliminar();
                DialogResult dr = ventanaEliminar.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    try
                    {
                        String fechaAus = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                        if (DateTime.Now > Convert.ToDateTime(dataGridView.SelectedRows[0].Cells[1].Value))
                        {
                            MessageBox.Show("No se puede eliminar una ausencia de días pasados.", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            String sql = "DELETE FROM Ausencias WHERE CodigoPersonal = '" + trabajador.codigo + "' AND Fecha = '" + fechaAus + "'";
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
                            sql = "insert into Auditoria (queHizo, fecha, usuario) values ('Eliminó una de sus ausencias','" + fecha + "','" + trabajador.usuario + "')";
                            using (SqlConnection openCon = new SqlConnection("Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;"))
                            {

                                using (SqlCommand querySaveStaff = new SqlCommand(sql))
                                {
                                    querySaveStaff.Connection = openCon;
                                    openCon.Open();

                                    querySaveStaff.ExecuteNonQuery();
                                }
                            }

                            cargarAusencias();
                        }
                    }
                    catch
                    {
                        Error ventanaError = new Error();
                        ventanaError.ShowDialog();
                    }
                }
            }
        }

        private void cargarAusencias()
        {

                string connectionString = "Server=DESKTOP-MU4EH1E;Database=FicharApp;User Id=admin;Password=123;";
                string sql = "select * FROM Ausencias " +
                    "WHERE CodigoPersonal = '" + trabajador.codigo + "'";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "Authors_table");
                connection.Close();

                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = ds.Tables[0];
            
        }

    }
}
