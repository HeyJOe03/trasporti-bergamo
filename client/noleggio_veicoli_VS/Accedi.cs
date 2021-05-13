using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noleggio_veicoli_VS
{
    public partial class Accedi : Form
    {
        public Accedi()
        {
            InitializeComponent();
            posizioneAccedi();
        }

        private void RBaccedi_CheckedChanged(object sender, EventArgs e)
        {
            posizioneAccedi();
        }

        private void RBregistrati_CheckedChanged(object sender, EventArgs e)
        {
            posizioneRegistrati();
        }

        private void posizioneAccedi()
        {
            TXBdocumento.Visible = false;
            CalendarNascita.Visible = false;
            LBLdocumento.Visible = false;
        }

        private void posizioneRegistrati()
        {
            TXBdocumento.Visible = true;
            CalendarNascita.Visible = true;
            LBLdocumento.Visible = true;
        }

    }
}
