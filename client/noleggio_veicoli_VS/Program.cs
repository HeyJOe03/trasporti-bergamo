using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noleggio_veicoli_VS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accedi());
            accesso = true;
            if(accesso) Application.Run(new veicoli_disponibili());

        }

        public static bool accesso = false;

        public static List<Auto> auto;
        public static List<Bici> bici;
        public static List<EBike> ebike;
        public static List<Monopattino> monopattino;
        public static List<MotorinoElettrico> motorino;
    }
}
