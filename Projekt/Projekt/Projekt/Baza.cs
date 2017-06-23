using System;
using System.Collections.Generic;
using System.Linq;

namespace Projekt
{
    [Serializable()]
    public class Baza
    {
      
        public double Budżet { get; set; }
        private List<PozPlan> pozPlanowane;
        public List<PozPlan> PozPlanowane
        {
            get
            {
                return pozPlanowane;
            }
        }
        private List<PozPlan> pozHistoria;
        public List<PozPlan> PozHistoria
        {
            get
            {
                return pozHistoria;
            }
        }
        public Baza(double bud)
        {
            Budżet = bud;
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
            Budżet += poz.wysokość;
        }
        public void addPozPlan(PozPlan x)
        {
            pozPlanowane.Add(x);
        }

        public void delPozPlan(String nazwa, bool zhist)
        {
            if (zhist)
            {
                pozHistoria = pozHistoria.OrderByDescending(b => b.termin).ToList();
                foreach(PozPlan poz in pozHistoria)
                {
                    if (poz.nazwa == nazwa)
                    {
                        Budżet -= poz.wysokość;
                        pozHistoria.Remove(poz);
                        return;
                    }
                }
            }
            else
            {
                pozPlanowane =  pozPlanowane.Where(p => p.nazwa != nazwa).ToList();
            }
            
        }
    }
}
