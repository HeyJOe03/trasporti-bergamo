using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
    ////////////////////////////////////////////////////////////////////CLASSE MONOPATTINO-CLASSE MONOPATTINO-CLASSE MONOPATTINO////////////////////////////////////////////////////////////////
    public class Monopattino : Veicolo
    {
        protected int livelloBatteria;
        protected int batteriaMassima;
        protected float costoOra;
        protected float costoGiorno;
        protected bool segnaleAcustico;

        public Monopattino()
        {
            livelloBatteria = 0;
            batteriaMassima = 0;
            costoOra = 0;
            costoGiorno = 0;
            segnaleAcustico = false;
        }

        public Monopattino(string id, string mr, int st, string ds, double lt, double lg, float cm, int p, int lb, int bm, float cO, float cG, bool sa) : base(id, mr, st, ds, lt, lg, cm, p)
        {
            livelloBatteria = lb;
            batteriaMassima = bm;
            costoOra = cO;
            costoGiorno = cG;
            segnaleAcustico = sa;
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
    }
    ////////////////////////////////////////////////////////////////CLASSE MOTORINOELETTRICO-CLASSE MOTORINOELETTRICO-CLASSE MOTORINOELETTRICO//////////////////////////////////////////////////
    public class MotorinoElettrico : Veicolo
    {
        protected string targa;
        protected int livelloBatteria;
        protected bool radio;
        protected float costoH;
        protected float costoD;

        public MotorinoElettrico()
        {
            targa = "";
            livelloBatteria = 0;
            radio = false;
            costoH = 0;
            costoD = 0;
        }

        public MotorinoElettrico(string id, string mr, int st, string ds, double lt, double lg, float cm, int p,string tg,int lB,bool rd,float cH, float cD) : base(id, mr, st, ds, lt, lg, cm, p)
        {
            targa = tg;
            livelloBatteria = lB;
            radio = rd;
            costoH = cH;
            costoD = cD;
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

        public float CostoH
        {
            set
            {
                if (value >= 0)
                {
                    costoH = value;
                }
            }
            get
            {
                return costoH;
            }
        }

        public float CostoD
        {
            set
            {
                if (value >= 0)
                {
                    costoD = value;
                }
            }
            get
            {
                return costoD;
            }
        }
    }
    ////////////////////////////////////////////////////////////////////////CLASSE AUTO-CLASSE AUTO-CLASSE AUTO/////////////////////////////////////////////////////////////////////////////////
    public class Auto : Veicolo
    {
        protected string targa;
        protected int livelloBatteria;
        protected float prezzoGiorno;
        protected float prezzoOra;

        public Auto()
        {
            targa = "";
            livelloBatteria = 0;
            prezzoGiorno = 0;
            prezzoOra = 0;
        }

        public Auto(Dictionary<string, string> d)
        {
            //this = new Auto(d["ID"], d[""], d[""], d[""], d[""], d[""], d[""], d[""], d[""], d[""], d[""], d[""]);
        }

        public Auto(string id, string mr, int st, string ds, double lt, double lg, float cm, int p, string tg, int lB, float pG, float pO) : base(id, mr, st, ds, lt, lg, cm, p)
        {
            targa = tg;
            livelloBatteria = lB;
            prezzoGiorno = pG;
            prezzoOra = pO;
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

        public float PrezzoGiorno
        {
            set
            {
                if (value >= 0)
                {
                    prezzoGiorno = value;
                }
            }
            get
            {
                return prezzoGiorno;
            }
        }

        public float PrezzoOra
        {
            set
            {
                if (value >= 0)
                {
                    prezzoOra = value;
                }
            }
            get
            {
                return prezzoOra;
            }
        }
    }
}