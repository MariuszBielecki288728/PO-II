using System;

namespace Projekt
{
    [Serializable()]
    public class PozPlan
    {
        public string nazwa { get; }
        public DateTime termin { get; set; }     // termin akcji
        public int mscInterv { get; }      //co ile msc
        public bool czyPłatność { get; }
        public double wysokość { get; }
        public bool czyWykon { get; } //mbset
        public string kategoria { get; }
        
        public PozPlan(string naz, DateTime ter, int mscIn, bool czPl, double wys, bool czyWyk, string kat)
        {
            nazwa = naz;
            termin = ter;
            mscInterv = mscIn;
            czyPłatność = czPl;
            wysokość = wys;
            czyWykon = czyWyk;
            kategoria = kat;
        }
        public PozPlan copy()
        {
            return new PozPlan(nazwa, termin, mscInterv, czyPłatność, wysokość, czyWykon, kategoria);
        }
    }
}
