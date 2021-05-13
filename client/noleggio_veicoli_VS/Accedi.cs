using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace noleggio_veicoli_VS
{
    public partial class Accedi : Form
    {

        private string URLsearch = "http://localhost:3000/search/";
        private string serverResponse = "";

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

        private void BTNinvia_Click(object sender, EventArgs e)
        {
            if (RBaccedi.Checked == true) accediRequest();
            else registratiRequest();
        }


        private async void accediRequest() {

            string request = "{\"CF\":\"" + TXBCF.Text + "\"}";

            using (var client = new HttpClient())
                {

                    var response = await client.PostAsync(
                           URLsearch + "utente",
                         new StringContent(request, Encoding.UTF8, "application/json")
                    );
                    serverResponse = response.Content.ReadAsStringAsync().Result;

                    lblCF.Text = serverResponse;
                if(serverResponse == "{'error':'no elements'}")
                {
                    LBLerror.Text = "Registrati per poter accedere";
                }


                    Dictionary<string, string> daJson = new Dictionary<string, string>();
                }
                
        }
        private async void registratiRequest() {
        string request = "{\"CF\":\"" + TXBCF.Text + "\", }";

        using (var client = new HttpClient())
        {

            var response = await client.PostAsync(
                   URLsearch + "utente",
                 new StringContent(request, Encoding.UTF8, "application/json")
            );
            serverResponse = response.Content.ReadAsStringAsync().Result;

            lblCF.Text = serverResponse;
            if (serverResponse == "{'error':'no elements'}")
            {
                LBLerror.Text = "Registrati per poter accedere";
            }


            Dictionary<string, string> daJson = new Dictionary<string, string>();
        }
    }
    }
}
