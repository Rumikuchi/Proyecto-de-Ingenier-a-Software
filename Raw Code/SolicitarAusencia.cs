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
    public partial class SolicitarAusencia : Form
    {
        public SolicitarAusencia()
        {
            InitializeComponent();
        }

        public string getMotivo()
        {
            return tbMotivo.Text;
        }

        public DateTime getFecha()
        {
            return monthCalendar1.SelectionRange.Start;
        }

        private void bSolicitar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
