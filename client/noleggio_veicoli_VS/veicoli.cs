using System.Collections.Generic;

namespace Noleggio_Veicoli
{
    ////////////////////////////////////////////////////////////////////////CLASSE VEICOLO-CLASSE VEICOLO-CLASSE VEICOLO////////////////////////////////////////////////////////////////////////
    public class Veicolo
    {
        protected string identificativo;
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
            identificativo = "";
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
            this.identificativo = D["identificativo"];
            this.marca = D["marca"];
            int.TryParse(D["stato"], out int s);
            this.stato = s;
            this.disponibilita = D["disponibilita"];
            double.TryParse(D["latitudine"], out double la);
            this.latitudine = la;
            double.TryParse(D["longitudine"], out double lo);
            this.longitudine = lo;
            int.TryParse(D["costoMinuto"], out int c);
            this.costoMinuto = c;
            int.TryParse(D["posti"], out int p);
            this.posti = p;
        }

        public Veicolo(string id,string mr,int st,string ds,double lt,double lg,float cm,int p)
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

        public string Identificativo
        {
            set{
                if(value is string)
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

        public Bici(string id, string mr, int st, string ds, double lt, double lg, float cm, int p, string tp, char dm, bool sg, bool cs, float cS) : base(id,mr,st,ds,lt,lg,cm,p)
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
    }
    ////////////////////////////////////////////////////////////////////////CLASSE EBIKE-CLASSEEBIKE-CLASSE EBIKE///////////////////////////////////////////////////////////////////////////////
    public class EBike : Bici
    {
        protected float caricaBatteria;

        public EBike()
        {
            caricaBatteria = 0;
        }

        public EBike(string id, string mr, int st, string ds, double lt, double lg, float cm, int p, string tp, char dm, bool sg, bool cs, float cS, float cb) : base(id, mr, st, ds, lt, lg, cm, p,tp,dm,sg,cs,cS)
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
    }
    ////////////////////////////////////////////////////////////////////CLASSE MONOPATTINO-CLASSE MONOPATTINO-CLASSE MONOPATTINO////////////////////////////////////////////////////////////////
    public class Monopattino : Veicolo
    {
        //protected int livelloBatteria;
        protected int batteriaMassima;
        //protected float costoOra;
        //protected float costoGiorno;
        protected bool segnaleAcustico;

        public Monopattino()
        {
            //livelloBatteria = 0;
            batteriaMassima = 0;
            //costoOra = 0;
            //costoGiorno = 0;
            segnaleAcustico = false;
        }

        public Monopattino(string id, string mr, int st, string ds, double lt, double lg, float cm, int p, int bm, bool sa) : base(id, mr, st, ds, lt, lg, cm, p)
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
    }
    ////////////////////////////////////////////////////////////////CLASSE MOTORINOELETTRICO-CLASSE MOTORINOELETTRICO-CLASSE MOTORINOELETTRICO//////////////////////////////////////////////////
    public class MotorinoElettrico : Veicolo
    {
        protected string targa;
        protected int livelloBatteria;
        protected bool radio;
        //protected float costoH;
        //protected float costoD;

        public MotorinoElettrico()
        {
            targa = "";
            livelloBatteria = 0;
            radio = false;
            
        }

        public MotorinoElettrico(string id, string mr, int st, string ds, double lt, double lg, float cm, int p,string tg,int lB,bool rd) : base(id, mr, st, ds, lt, lg, cm, p)
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

        public Auto(string id, string mr, int st, string ds, double lt, double lg, float cm, int p, string tg, int lB) : base(id, mr, st, ds, lt, lg, cm, p)
        {
            targa = tg;
            livelloBatteria = lB;
            //prezzoGiorno = pG;
            //prezzoOra = pO;
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

        protected override void Veicolo_from_dictionary(Dictionary<string, string> D)
        {
            base.Veicolo_from_dictionary(D);
            targa = D["targa"];
            int.TryParse(D["livelloBatteria"], out int lb);
            livelloBatteria = lb;
        }
    }
}