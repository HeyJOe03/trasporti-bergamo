using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;


namespace noleggio_veicoli_VS
{
    public partial class veicoli_disponibili : Form
    {
        private string URLsearch;
        private string serverResponse = "";
        //private const string url = "https://www.google.com/maps/d/edit?mid=1zeyNvs0maJ7A1r9HMXDlso5MDxTgEbPd&usp=sharing";
        public veicoli_disponibili()
        {
            InitializeComponent();
            URLsearch = "http://localhost:3000/search/";

            string s = "";
           
            //serverSearchRequest("ebike");


            //try { BrowserMap.Navigate(url); } catch(Exception e) { String error = e.Message; }
        }


        

        private async void serverSearchRequest(string veicolo)
        {
            //string request = Program.DictionaryToString(richiesta);

            string request = "";

            try
            {
                using (var client = new HttpClient())
                {

                    var response = await client.PostAsync(
                           URLsearch + veicolo,
                         new StringContent(request, Encoding.UTF8, "application/json")
                    );
                    serverResponse = response.Content.ReadAsStringAsync().Result;

                    serverResponse = serverResponse.Substring(1, serverResponse.Length - 2);

                    string[] elements = serverResponse.Split('}');

                    for (int i = 0; i < elements.Length - 1; i++)
                    {

                        if (elements[i][0] == ',') elements[i] = elements[i].Substring(1, elements[i].Length - 1);
                        if (elements[i][elements[i].Length -1] != '}') elements[i] = elements[i] + "}";
                        //listBox1.Items.Add(elements[i]);
                        //listBox1.Items.Add("hello world");
                    }

                    
                    Dictionary<string, string> daJson = new Dictionary<string, string>();



                    for (int i = 0; i < elements.Length; i++)
                    {
                        daJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(elements[i]);
                        listBox1.Items.Add(veicolo + ":" + daJson["ID"]);
                    }



                }
            } catch (Exception e){
                label2.Text = e.Message;
            }
            
        }



        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void veicoliCHECK_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var checkBox in veicoliCHECK.CheckedItems)
            {

                switch (checkBox.ToString())
                {
                    case "auto elettrica":
                        serverSearchRequest("auto");
                        break;
                    case "bici":
                        serverSearchRequest("bici");
                        break;
                    case "e-bike":
                        serverSearchRequest("ebike");
                        break;
                    case "motorino elettrico":
                        serverSearchRequest("motorinoelettrico");
                        break;
                    case "monopattino elettrico":
                        serverSearchRequest("monopattinoelettrico");
                        break;
                    default:
                        listBox1.Items.Add("error");
                        break;

                }

                //serverSearchRequest(veicolo);
            }
        }
    }
}




 
    
