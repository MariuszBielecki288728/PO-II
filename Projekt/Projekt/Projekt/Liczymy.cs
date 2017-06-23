using System;

namespace Projekt
{
    public static class Liczymy
    {
        public static double bilansPlanowany(Baza baz)
        {
            double bil = 0;
            foreach (PozPlan poz in baz.PozPlanowane)
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
            foreach (PozPlan poz in baz.PozHistoria)
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
}
