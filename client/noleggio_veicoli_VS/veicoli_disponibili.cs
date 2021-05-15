using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;


namespace noleggio_veicoli_VS
{
    public partial class veicoli_disponibili : Form
    {
        private readonly string URLsearch;
        private string serverResponse = "";
        public static bool noleggioState = true;

        public veicoli_disponibili()
        {
            InitializeComponent();
            URLsearch = "http://localhost:3000/search/";
        }
      
        private async void serverSearchRequest(string veicolo)
        {
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
                    }


                    Dictionary<string, string> daJson;// = new Dictionary<string, string>();
                    switch (veicolo)
                    {
                        case "auto":
                            Program.auto = new List<Auto>();
                            break;
                        case "bici":
                            Program.bici = new List<Bici>();
                            break;
                        case "ebike":
                            Program.ebike = new List<EBike>();
                            break;
                        case "motorinoelettrico":
                            Program.motorino = new List<MotorinoElettrico>();
                            break;
                        case "monopattinoelettrico":
                            Program.monopattino = new List<Monopattino>();
                            break;
                        default:
                            break;
                    }


                    for (int i = 0; i < elements.Length-1; i++)
                    {
                        daJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(elements[i]);


                    //BUGFIX per i tryparse
                        Dictionary<string, string> copy = new Dictionary<string,string>(daJson);
                        foreach (KeyValuePair<string,string> e in daJson)
                        {
                            copy[e.Key] = copy[e.Key].Replace('.',',');
                        }
                        daJson = copy;

                        string veicoloUserName = ""; 

                        switch (veicolo)
                        {
                            case "auto":
                                Program.auto.Add(new Auto(daJson));
                                veicoloUserName = "auto";
                                break;
                            case "bici":
                                Program.bici.Add(new Bici(daJson));
                                veicoloUserName = "bici";
                                break;
                            case "ebike":
                                Program.ebike.Add(new EBike(daJson));
                                veicoloUserName = "e-bike";
                                break;
                            case "motorinoelettrico":
                                Program.motorino.Add(new MotorinoElettrico(daJson));
                                veicoloUserName = "motorino elettrico";
                                break;
                            case "monopattinoelettrico":
                                Program.monopattino.Add(new Monopattino(daJson));
                                veicoloUserName = "monopattino elettrico";
                                break;
                            default:
                                break;
                        }


                        listBox1.Items.Add(veicoloUserName + ":" + daJson["ID"]);
                    }
                }
            } catch (Exception e){
                    label2.Text = e.Message;
        }

    }

        private void veicoliCHECK_SelectedIndexChanged(object sender, EventArgs e)
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

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string item_string = "";

            foreach (var item in listBox1.SelectedItems)
            {
                item_string = item.ToString();
                break; //solo 1 selezionato
            }

            //se viene chiuso il form lo obbliga a riaprirsi fino a quando il noleggio è attivo
            Noleggio formNoleggio = new Noleggio(item_string);
            while (noleggioState)
            {
                noleggioState = false;
                formNoleggio.ShowDialog();  //show dialog bloccante
            }

            //label2.Text = sender.GetType().ToString();
        }

    }
}




 
    
