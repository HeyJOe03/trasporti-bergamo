using System;
using System.Collections.Generic;

namespace noleggio_veicoli_VS
{
    ////////////////////////////////////////////////////////////////////////CLASSE VEICOLO-CLASSE VEICOLO-CLASSE VEICOLO////////////////////////////////////////////////////////////////////////
    public class Veicolo
    {
        protected int identificativo;
        protected string marca;
        protected int stato;
        protected string disponibilita;
        protected double latitudine;
        protected double longitudine;
        protected float costoMinuto;
        protected float costoOra;
        protected float costoGiorno;
        protected int posti;

        public Veicolo()
        {
            identificativo = -1;
            marca = "";
            stato = -1;
            disponibilita = "";
            latitudine = 0.0;
            longitudine = 0.0;
            costoMinuto = 0;
            posti = 0;
        }

        public Veicolo(Dictionary<string, string> d)
        {
            //veicolo_from_dictionary_base(d);
            Veicolo_from_dictionary(d);
        }

        //protected void veicolo_from_dictionary_base(Dictionary<string, string> D)
        //{
        //    //Dictionary<string, string> d = new Dictionary<string, string>();
          
        //}

        protected virtual void Veicolo_from_dictionary(Dictionary<string, string> D) {
            int.TryParse(D["ID"], out int id);
            this.identificativo = id; 
            this.marca = D["marca"];
            int.TryParse(D["stato"], out int s);
            this.stato = s;
            this.disponibilita = D["disponibilita"];
            double.TryParse(D["latitudine"], out double la);
            this.latitudine = la;
            double.TryParse(D["longitudine"], out double lo);
            this.longitudine = lo;
            float.TryParse(D["costoMinuto"], out float c);
            this.costoMinuto = c;
            float.TryParse(D["costoGiorno"], out float g);
            this.costoGiorno = g;
            float.TryParse(D["costoOra"], out float o);
            this.costoOra = o;
            int.TryParse(D["posti"], out int p);
            this.posti = p;
        }

        public Veicolo(int id,string mr,int st,string ds,double lt,double lg,float cm,int p)
        {
            identificativo = id;
            marca = mr;
            stato = st;
            disponibilita = ds;
            latitudine = lt;
            longitudine = lg;
            costoMinuto = cm;
            posti = p;
        }

        public int Identificativo
        {
            set{
                if(value != 0)
                {
                    identificativo = value;
                }
            }
            get{
                return identificativo;
            }
        }

        public string Marca
        {
            set
            {
                if (value is string)
                {
                    marca = value;
                }
            }
            get
            {
                return marca;
            }
        }

        public int Stato
        {
            set
            {
                if (value>=0)
                {
                    stato = value;
                }
            }
            get
            {
                return stato;
            }
        }

        public string Disponibiita
        {
            set
            {
                if (value is string)
                {
                    disponibilita = value;
                }
            }
            get
            {
                return disponibilita;
            }
        }

        public double Latitudine
        {
            set
            {
                if (value >= 0)
                {
                    latitudine = value;
                }
            }
            get
            {
                return latitudine;
            }
        }

        public double Longitudine
        {
            set
            {
                if (value >= 0)
                {
                    longitudine = value;
                }
            }
            get
            {
                return longitudine;
            }
        }

        public float CostoMinuto
        {
            set
            {
                if (value >= 0)
                {
                    costoMinuto = value;
                }
            }
            get
            {
                return costoMinuto;
            }
        }

        public float CostoOra
        {
            set
            {
                if (value >= 0)
                {
                    costoOra = value;
                }
            }
            get
            {
                return costoOra;
            }
        }

        public float CostoGiorno
        {
            set
            {
                if (value >= 0)
                {
                    costoGiorno = value;
                }
            }
            get
            {
                return costoGiorno;
            }
        }

        public int Posti
        {
            set
            {
                if (value >= 0)
                {
                    posti = value;
                }
            }
            get
            {
                return posti;
            }
        }

        public override string ToString()
        {
            string text = "";
            text = text +
                "ID: " + Identificativo.ToString() + "\n" + 
                "Marca: " + Marca + "\n" + 
                "Stato: " + Stato.ToString() + "\n" + 
                "Disponibilita: " + Disponibiita + "\n" + 
                "Longitudine: " + Longitudine.ToString() + "\n" + 
                "Latitudine: " + Latitudine.ToString() + "\n" + 
                "CostoMinuto: " + CostoMinuto.ToString() + "\n" +
                "CostoOra: " + costoOra.ToString() + "\n" +
                "CostoGiorno: " + costoGiorno.ToString() + "\n" +
                "Posti: " + posti.ToString() + "\n";                ;

            return text;
        }

    }
    ////////////////////////////////////////////////////////////////////////CLASSE BICI-CLASSE BICI-CLASSE BICI/////////////////////////////////////////////////////////////////////////////////
    public class Bici : Veicolo
    {
        protected string tipologia;
        protected char dimensione;
        protected bool seggiolino;
        protected bool casco;
        protected float costoSblocco;

        public Bici()
        {
            tipologia = "";
            dimensione = ' ';
            seggiolino = false;
            casco = false;
            costoSblocco = 0;
        }

        public Bici(Dictionary<string, string> S) : base(S) { }

        public Bici(int id, string mr, int st, string ds, double lt, double lg, float cm, int p, string tp, char dm, bool sg, bool cs, float cS) : base(id,mr,st,ds,lt,lg,cm,p)
        {
            tipologia = tp;
            dimensione = dm;
            seggiolino = sg;
            casco = cs;
            costoSblocco = cS;
        }

        protected override void Veicolo_from_dictionary(Dictionary<string, string> d)
        {
            base.Veicolo_from_dictionary(d);
            tipologia = d["tipologia"];
            char.TryParse(d["dimensione"],out char dim);
            dimensione = dim;
            bool.TryParse(d["seggiolino"], out bool s);
            seggiolino = s;
            bool.TryParse(d["casco"], out bool c);
            casco = c;
            int.TryParse(d["costoSblocco"], out int cs);
            costoSblocco = cs;
        }

        public string Tipologia
        {
            set
            {
                if (value is string)
                {
                    tipologia = value;
                }
            }
            get
            {
                return tipologia;
            }
        }

        public char Dimensione
        {
            set
            {
                if (value >= 0)
                {
                    dimensione = value;
                }
            }
            get
            {
                return dimensione;
            }
        }

        public bool Seggiolino
        {
            set
            {
                if (value == false || value == true)
                {
                    seggiolino = value;
                }
            }
            get
            {
                return seggiolino;
            }
        }

        public bool Casco
        {
            set
            {
                if (value == false || value == true)
                {
                    casco = value;
                }
            }
            get
            {
                return casco;
            }
        }

        public float CostoSblocco
        {
            set
            {
                if (value >= 0)
                {
                    costoSblocco = value;
                }
            }
            get
            {
                return costoSblocco;
            }
        }

        public override string ToString()
        {
            string text = base.ToString();
            text = text +
                "Tipologia: " + tipologia + '\n' +
                "Dimensione: " + dimensione + '\n' +
                "Seggiolino: " + seggiolino.ToString() + '\n' +
                "Casco: " + casco.ToString() + '\n' +
                "Costo sblocco: " + costoSblocco.ToString() + '\n'
                ;
            return text;
        }
    }
    ////////////////////////////////////////////////////////////////////////CLASSE EBIKE-CLASSEEBIKE-CLASSE EBIKE///////////////////////////////////////////////////////////////////////////////
    public class EBike : Bici
    {
        protected float caricaBatteria;

        public EBike()
        {
            caricaBatteria = 0;
        }

        public EBike(Dictionary<string, string> S) : base(S){
            
        }

        public EBike(int id, string mr, int st, string ds, double lt, double lg, float cm, int p, string tp, char dm, bool sg, bool cs, float cS, float cb) : base(id, mr, st, ds, lt, lg, cm, p,tp,dm,sg,cs,cS)
        {
            caricaBatteria = cb;
        }

        public float CaricaBatteria
        {
            set
            {
                if (value >= 0)
                {
                    caricaBatteria = value;
                }
            }
            get
            {
                return caricaBatteria;
            }
        }

        protected override void Veicolo_from_dictionary(Dictionary<string, string> d)
        {
            base.Veicolo_from_dictionary(d);
            float.TryParse(d["caricaBatteria"], out float cb);
            caricaBatteria = cb;
        }

        public override string ToString()
        {
            string text = base.ToString();
            text = text +
                "CaricaBatteria: " + caricaBatteria.ToString() +'\n'
                ;
            return text;
        }
    }
    ////////////////////////////////////////////////////////////////////CLASSE MONOPATTINO-CLASSE MONOPATTINO-CLASSE MONOPATTINO////////////////////////////////////////////////////////////////
    public class Monopattino : Veicolo
    {
        //protected int livelloBatteria;
        protected int batteriaMassima;
        //protected float costoOra;
        //protected float costoGiorno;
        protected bool segnaleAcustico;

        public Monopattino(Dictionary<string, string> S) : base(S) { }

        public Monopattino()
        {
            //livelloBatteria = 0;
            batteriaMassima = 0;
            //costoOra = 0;
            //costoGiorno = 0;
            segnaleAcustico = false;
        }

        public Monopattino(int id, string mr, int st, string ds, double lt, double lg, float cm, int p, int bm, bool sa) : base(id, mr, st, ds, lt, lg, cm, p)
        {
            //livelloBatteria = lb;
            batteriaMassima = bm;
            //costoOra = cO;
            //costoGiorno = cG;
            segnaleAcustico = sa;
        }

        public int BatteriaMassima
        {
            set
            {
                if (value >= 0)
                {
                    batteriaMassima = value;
                }
            }
            get
            {
                return batteriaMassima;
            }
        }

        public bool SegnaleAcustico
        {
            set
            {
                if (value == false || value == true)
                {
                    segnaleAcustico = value;
                }
            }
            get
            {
                return segnaleAcustico;
            }
        }

        protected override void Veicolo_from_dictionary(Dictionary<string, string> D)
        {
            base.Veicolo_from_dictionary(D);
            int.TryParse(D["batteriaMassima"], out int bm);
            this.batteriaMassima = bm;

            bool.TryParse(D["segnaleAcustico"], out bool s);
            this.segnaleAcustico = s;
        }

        public override string ToString()
        {
            string text = base.ToString();
            text = text +
                "Batteria massima: " + batteriaMassima.ToString() + '\n' +
                "Segnale acustico: " + segnaleAcustico.ToString() + '\n'
                ;
            return text;
        }
    }
    ////////////////////////////////////////////////////////////////CLASSE MOTORINOELETTRICO-CLASSE MOTORINOELETTRICO-CLASSE MOTORINOELETTRICO//////////////////////////////////////////////////
    public class MotorinoElettrico : Veicolo
    {
        protected string targa;
        protected int livelloBatteria;
        protected bool radio;
        //protected float costoH;
        //protected float costoD;

        public MotorinoElettrico(Dictionary<string, string> S) : base(S) { }

        public MotorinoElettrico()
        {
            targa = "";
            livelloBatteria = 0;
            radio = false;
            
        }

        public MotorinoElettrico(int id, string mr, int st, string ds, double lt, double lg, float cm, int p,string tg,int lB,bool rd) : base(id, mr, st, ds, lt, lg, cm, p)
        {
            targa = tg;
            livelloBatteria = lB;
            radio = rd;
            
        }

        public string Targa
        {
            set
            {
                if (value is string)
                {
                    targa = value;
                }
            }
            get
            {
                return targa;
            }
        }

        public int LivelloBatteria
        {
            set
            {
                if (value >= 0)
                {
                    livelloBatteria = value;
                }
            }
            get
            {
                return livelloBatteria;
            }
        }

        public bool Radio
        {
            set
            {
                if (value == false || value == true)
                {
                    radio = value;
                }
            }
            get
            {
                return radio;
            }
        }

        protected override void Veicolo_from_dictionary(Dictionary<string, string> D)
        {
            base.Veicolo_from_dictionary(D);
            this.Targa = D["targa"];
            bool.TryParse(D["radio"], out bool r);
            this.Radio = r;
            int.TryParse(D["livelloBatteria"], out int lb);
            this.livelloBatteria = lb;
        }

        public override string ToString()
        {
            string text =  base.ToString();
            text = text +
                "Targa: " + targa + "\n" +
                "Livello batteria: " + livelloBatteria.ToString() + "\n" +
                "Radio: " + radio.ToString() + '\n'; 
                ;
            return text;
        }
    }
    ////////////////////////////////////////////////////////////////////////CLASSE AUTO-CLASSE AUTO-CLASSE AUTO/////////////////////////////////////////////////////////////////////////////////
    public class Auto : Veicolo
    {
        protected string targa;
        protected int livelloBatteria;
        //protected float prezzoGiorno;
        //protected float prezzoOra;

        public Auto()
        {
            targa = "";
            livelloBatteria = 0;
            //prezzoGiorno = 0;
            //prezzoOra = 0;
        }

        public Auto(int id, string mr, int st, string ds, double lt, double lg, float cm, int p, string tg, int lB) : base(id, mr, st, ds, lt, lg, cm, p)
        {
            targa = tg;
            livelloBatteria = lB;
            //prezzoGiorno = pG;
            //prezzoOra = pO;
        }

        public Auto(Dictionary<string, string> S) : base(S) { }

        public string Targa
        {
            set
            {
                if (value is string)
                {
                    targa = value;
                }
            }
            get
            {
                return targa;
            }
        }

        public int LivelloBatteria
        {
            set
            {
                if (value >= 0)
                {
                    livelloBatteria = value;
                }
            }
            get
            {
                return livelloBatteria;
            }
        }

        protected override void Veicolo_from_dictionary(Dictionary<string, string> D)
        {
            base.Veicolo_from_dictionary(D);
            targa = D["targa"];
            int.TryParse(D["livelloBatteria"], out int lb);
            livelloBatteria = lb;
        }

        public override string ToString()
        {
            string text = base.ToString();
            text = text +
                "Targa: " + targa + "\n" +
                "LivelloBatteria: " + livelloBatteria.ToString() + "\n"
                ;
            return text;
        }
    }
}