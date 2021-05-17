using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace noleggio_veicoli_VS
{
    public partial class Accedi : Form
    {

        private readonly string URLsearch = "http://localhost:3000/search/";
        private readonly string URLadd = "http://localhost:3000/add/";
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
            comboBox1.Visible = false;
            CalendarNascita.Visible = false;
            LBLdocumento.Visible = false;
        }

        private void posizioneRegistrati()
        {
            comboBox1.Visible = true;
            CalendarNascita.Visible = true;
            LBLdocumento.Visible = true;
        }

        private void BTNinvia_Click(object sender, EventArgs e)
        {
            if (RBaccedi.Checked == true) accediRequest();
            else registratiRequest();
        }

        private async void accediRequest() {
            if (TXBCF.Text == "") return;

            string request = "{\"CF\":\"" + TXBCF.Text + "\"}";

            using (var client = new HttpClient())
                {

                    var response = await client.PostAsync(
                           URLsearch + "utente",
                         new StringContent(request, Encoding.UTF8, "application/json")
                    );
                    serverResponse = response.Content.ReadAsStringAsync().Result;

                    serverResponse = serverResponse.Substring(1, serverResponse.Length - 2);//ESTRAE JSON


                    lblCF.Text = serverResponse;

                if (serverResponse == "\"error\":\"no elements\"")
                {
                    LBLerror.Text = "Registrati per poter accedere"; return;
                }

                else
                {
                    Program.accesso = true;
                    this.Close();
                }

                }
                
        }

        private async void registratiRequest() {
            string request = registraStringrRequest();

            using (var client = new HttpClient())
            {

                var response = await client.PostAsync(
                       URLadd + "utente",
                     new StringContent(request, Encoding.UTF8, "application/json")
                );
                serverResponse = response.Content.ReadAsStringAsync().Result;

                //LBLerror.Text = serverResponse;
                if (serverResponse == "{'message':'good state'}")
                {
                    LBLerror.Text = "Procedi con l'accesso";
                    RBaccedi.Checked = true;
                    RBregistrati.Checked = false;
                }
                else LBLerror.Text = "Errore nella registrazione";


                //Dictionary<string, string> daJson = new Dictionary<string, string>();
            }
        }

        private string registraStringrRequest()
        {
            string request =
                "{\"CF\":\"" + lblCF.Text +
                "\",\"documento\":\"" + comboBox1.Text +
                "\",\"giorno\":" + CalendarNascita.Value.Day +
                ",\"mese\":"+ CalendarNascita.Value.Month +
                ",\"anno\":" + CalendarNascita.Value.Year + "}";
            LBLerror.Text = request;
           
            return request;
        }
    }
}
