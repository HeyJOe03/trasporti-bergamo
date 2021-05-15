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
    public partial class Maps : Form
    {

        private readonly string url = "https://www.google.co.uk/maps/@";//@45.6921451,9.6858953,14.15z

        public Maps(double lat,double lon,double zoom)
        {
            InitializeComponent();

            url = url + lat.ToString().Replace(',','.') + ',' + lon.ToString().Replace(',', '.') + ',' + zoom.ToString().Replace(',','.') + 'z';

            try {
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.Navigate(url); 
            } catch(Exception) {
                return;
            }
        }
    }
}
