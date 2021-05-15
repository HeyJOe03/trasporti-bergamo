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
    public partial class Noleggio : Form
    {
        private readonly object rememberMe;
        private bool stopEvent = false;
        private TimeSpan timer = new TimeSpan(0,0,0,0);
        //private long timer = 0;

        public Noleggio(string nomeVeicolo)
        {
            InitializeComponent();
            //timer = new TimeSpan(0);
            //LBLinfo.Text = infoVeicolo;
            int x = nomeVeicolo.IndexOf(':');
            string IDstring = nomeVeicolo.Substring(x+1, nomeVeicolo.Length - x-1);
            string veicolo = nomeVeicolo.Substring(0, x);
            int.TryParse(IDstring, out int IDveicolo);

            if (veicoli_disponibili.noleggioState) BTNnoleggio.Text = "Avvia il noleggio";
            else BTNnoleggio.Text = "Termina il noleggio";

            switch (veicolo)
            {
                case "auto":
                    foreach(Auto a in Program.auto)
                    {
                        if(a.Identificativo == IDveicolo)
                        {
                            rememberMe = a;
                            break;
                        }
                    }
                    break;
                case "bici":
                    foreach (Bici a in Program.bici)
                    {
                        if (a.Identificativo == IDveicolo)
                        {
                            rememberMe = a;
                            break;
                        }
                    }
                    break;
                case "e-bike":
                    foreach (EBike a in Program.ebike)
                    {
                        if (a.Identificativo == IDveicolo)
                        {
                            rememberMe = a;
                            break;
                        }
                    }
                    break;
                case "motorino elettrico":
                    foreach (MotorinoElettrico a in Program.motorino)
                    {
                        if (a.Identificativo == IDveicolo)
                        {
                            rememberMe = a;
                            break;
                        }
                    }
                    break;
                case "monopattino elettrico":
                    foreach (Monopattino a in Program.monopattino)
                    {
                        if (a.Identificativo == IDveicolo)
                        {
                            rememberMe = a;
                            break;
                        }
                    }
                    break;
                default:
                    
                    break;
            }

            LBLinfo.Text = rememberMe.GetType().ToString();

            switch (rememberMe.GetType().ToString())
            {
                case "noleggio_veicoli_VS.Auto":
                    LBLinfo.Text = ((Auto)rememberMe).ToString();
                    break;
                case "noleggio_veicoli_VS.MotorinoElettrico":
                    LBLinfo.Text = ((MotorinoElettrico)rememberMe).ToString();
                    break;
                case "noleggio_veicoli_VS.EBike":
                    LBLinfo.Text = ((EBike)rememberMe).ToString();
                    break;
                case "noleggio_veicoli_VS.Bici":
                    LBLinfo.Text = ((Bici)rememberMe).ToString();
                    break;
                case "noleggio_veicoli_VS.Monopattino":
                    LBLinfo.Text = ((Monopattino)rememberMe).ToString();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lat = 0,lon = 0;

            switch (rememberMe.GetType().ToString())
            {
                case "noleggio_veicoli_VS.Auto":
                    lat = ((Auto)rememberMe).Latitudine;
                    lon = ((Auto)rememberMe).Longitudine;
                    break;
                case "noleggio_veicoli_VS.MotorinoElettrico":
                    lat = ((MotorinoElettrico)rememberMe).Latitudine;
                    lon = ((MotorinoElettrico)rememberMe).Longitudine;
                    break;
                case "noleggio_veicoli_VS.EBike":
                    lat = ((EBike)rememberMe).Latitudine;
                    lon = ((EBike)rememberMe).Longitudine;
                    break;
                case "noleggio_veicoli_VS.Bici":
                    lat = ((Bici)rememberMe).Latitudine;
                    lon = ((Bici)rememberMe).Longitudine;
                    break;
                case "noleggio_veicoli_VS.Monopattino":
                    lat = ((Monopattino)rememberMe).Latitudine;
                    lon = ((Monopattino)rememberMe).Longitudine;
                    break;
            }

            Maps a = new Maps(lat,lon, 14.5);
            a.ShowDialog();
        }

        private void BTNnoleggio_Click(object sender, EventArgs e)
        {
            if (BTNnoleggio.Text == "Avvia il noleggio")
            {
                stopEvent = false;
                veicoli_disponibili.noleggioState = true;

                ///timer
                timer1.Interval = 30;
                timer1.Enabled = true;
                timer1.Start();
                timer1.Tick += new EventHandler(OnTimedEvent);

                BTNnoleggio.Text = "Termina il noleggio";
            }
            else //termina il noleggio
            {
                stopEvent = true;
                veicoli_disponibili.noleggioState = false;
                BTNnoleggio.Text = "Avvia il noleggio";
            }
        }

        private void OnTimedEvent(object source, EventArgs e)
        {
            if (stopEvent)
            {
                timer1.Stop();
                timer1.Enabled = false;
            }
            else
            {
                //timer++;
                timer = timer.Add(new TimeSpan(0,0,1,12));
                LBLtime.Text = timer.ToString();

                Veicolo v = ((Veicolo)rememberMe);
                float spesa =   v.CostoGiorno * timer.Days + 
                                v.CostoMinuto * timer.Minutes + 
                                v.CostoOra * timer.Hours;

                LBLprice.Text = "Costo: " + (new Euro(spesa)).ToString();

            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (timer != new TimeSpan(0, 0, 0, 0)) veicoli_disponibili.noleggioState = true;
            //veicoli_disponibili.noleggioState = true;
        }
    }
}
