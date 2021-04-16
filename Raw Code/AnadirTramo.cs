using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Fichajes
{
    public partial class AnadirTramo : Form
    {
        public AnadirTramo()
        {
            InitializeComponent();
        }

        private void Aplicar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public string getHoraEntrada()
        {
            return textBox1.Text;
        }

        public string getHoraSalida()
        {
            return textBox2.Text;
        }
    }
}
