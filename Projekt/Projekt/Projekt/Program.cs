using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
        public static void zapisz(Baza baz, String filePath)
        {
            Stream stream = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, baz);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                if (null != stream)
                    stream.Close();
            }
        }
        public static Baza wczytaj(String filePath)
        {
            Stream stream = null;
            Baza baz = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(filePath, FileMode.Open);
                baz = (Baza)formatter.Deserialize(stream);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                if (null != stream)
                    stream.Close();
            }
            return baz;
        }
    }



    public class Kontakt
    {
        public static void facebook()
        {
            Process.Start("https://www.facebook.com/MariuszBielecki0");
        }
        public static void mail()
        {
            Process.Start("mailto:maniekb12@gmail.com");
        }
        public static void strona()
        {
            Process.Start("http://piwnicaprogramisty.pl");

        }
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


    [Serializable()]
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



    class MyViewMode
    {
        public DateTime Termin { get; set; }
        public string Nazwa { get; set; }
        public double Wartość { get; set; }
        public string Kategoria { get; set; }
    }
}
