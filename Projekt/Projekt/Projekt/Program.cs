using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;

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
        public double budżet { get; set; }
        public List<PozPlan> pozPlanowane { get; set; }
        public List<PozPlan> pozHistoria { get; set; }
        public Baza(string nazwa, double bud)
        {
            budżet = bud;
            nazwaBudżetu = nazwa;
            pozPlanowane = new List<PozPlan>();
            pozHistoria  = new List<PozPlan>();
        }
        public void refreshPlan()
        {
            foreach (PozPlan p in pozPlanowane)
            {
                if (p.termin < DateTime.Today)
                {
                    p.termin = p.termin.AddMonths(p.mscInterv);
                }
            }
        }
        public void addPozRzecz(PozPlan poz)
        {
            if (poz.mscInterv == 0)
            {
                pozPlanowane = pozPlanowane.Where(u => u.nazwa != poz.nazwa).ToList();
            }
            else
            {
                foreach (PozPlan i in pozPlanowane)
                {
                    if (i.nazwa == poz.nazwa)
                    {
                        i.termin = i.termin.AddMonths(i.mscInterv);
                    }
                }
            }
            pozHistoria.Add(poz);
            budżet += poz.wysokość;
        }
        public void addPozPlan(PozPlan x)
        {
            pozPlanowane.Add(x);
        }
    }

    public class WczytZapis
    {
        //public wczytajZPliku()
    }

    public class Liczymy
    {
        public static double bilansPlanowany(Baza baz)
        {
            double bil = 0;
            foreach (PozPlan poz in baz.pozPlanowane)
            {
                if (poz.termin.Month == DateTime.Today.Month
                    && poz.termin.Year == DateTime.Today.Year)
                {
                    bil += poz.wysokość;
                }

            }
            return bil+bilansRzeczywisty(baz);

        }
        public static double bilansRzeczywisty(Baza baz)
        {
            double bil = 0;
            foreach (PozPlan poz in baz.pozHistoria)
            {
                if (poz.termin.Month == DateTime.Today.Month
                    && poz.termin.Year == DateTime.Today.Year)
                {
                    bil += poz.wysokość;
                }

            }
            return bil;
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
