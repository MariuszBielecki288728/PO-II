using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new oknoGlowne());
        }
    }

    [Serializable()]
    public class Baza
    {
        string nazwaBudżetu;
        public List<PozPlan> pozPlanowane { get; set; }
        public List<PozPlan> pozHistoria { get; set; }
        public Baza(string nazwa)
        {
            nazwaBudżetu = nazwa;
            pozPlanowane = new List<PozPlan>();
            pozHistoria  = new List<PozPlan>();
        }

    }

    public class PozPlan
    {
        public string nazwa { get; }
        public DateTime termin { get; set; }     // termin akcji
        public int mscInterv { get; }      //co ile msc
        public bool czyPłatność { get; }
        public double wysokość { get; }
        public bool czyWykon { get; set; }
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
    }
}
