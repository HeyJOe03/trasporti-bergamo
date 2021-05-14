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
        //private string nomeVeicolo;
        //private Auto rememberMeAuto;
        //private Bici rememberMeBici;
        //private EBike rememberMeEbike;
        //private Monopattino rememberMeMonopattino;
        //private MotorinoElettrico rememberMeMotorino;

        private readonly object rememberMe;

        public Noleggio(string nomeVeicolo)
        {
            InitializeComponent();

            //LBLinfo.Text = infoVeicolo;
            int x = nomeVeicolo.IndexOf(':');
            string IDstring = nomeVeicolo.Substring(x+1, nomeVeicolo.Length - x-1);
            string veicolo = nomeVeicolo.Substring(0, x);
            int.TryParse(IDstring, out int IDveicolo);

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
                    break;
                case "noleggio_veicoli_VS.EBike":
                    break;
                case "noleggio_veicoli_VS.Bici":
                    break;
                case "noleggio_veicoli_VS.Monopattino":
                    break;
            }
        }
    }
}
