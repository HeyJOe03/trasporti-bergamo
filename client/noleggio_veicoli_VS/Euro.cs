using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noleggio_veicoli_VS
{
    class Euro
    {
        private readonly float value;

        public Euro(float value)
        {
            this.value = value;
        }
        public Euro() { this.value = 0f; }

        public override string ToString()
        {
            string text = "";
            string valueS = value.ToString();
            int x = valueS.IndexOf('.');
            //try
            //{
            //    valueS = valueS.Substring(0, x + 3);    //caso: 12.438
            //}
            //catch (Exception)
            //{
            //    try
            //    {
            //        valueS = valueS.Substring(0, x + 2);    //caso: 4.3
            //        valueS += '0';
            //    }
            //    catch (Exception)   //caso: 5
            //    {
            //        valueS += ".00";
            //    }
            //}
            //text += valueS;
            text += value.ToString();
            text += '€';
            return text;
        }
    }
}
