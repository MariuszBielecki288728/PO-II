using System;


namespace ClassLibrary1
{
    sealed class TimeNTon
    {
        static int N = 3;
        static TimeNTon[] istniejace;
        static TimeSpan[] times;
        static int licznik;


        TimeNTon()
        {
            Console.WriteLine("tworzę obiekt {0}", licznik);
        }

        static public TimeNTon instance()
        {
            //gdy wywołujemy po raz pierwszy
            if (istniejace == null)
            {
                istniejace = new TimeNTon[N];
                istniejace[0] = new TimeNTon();

                times = new TimeSpan[] {
                           new TimeSpan(0, 21, 15, 0, 0),
                           new TimeSpan(0, 22, 0, 0, 0), };
            }
            //zliczamy wywołania instance()
            licznik++;

            //liczymy i porównujemy czas
            TimeSpan t = DateTime.Now.TimeOfDay;

            int po = TimeSpan.Compare(t, times[0]);
            int przed = TimeSpan.Compare(t, times[1]);

            Console.WriteLine("Aktualny czas to {0}", t);

            //gdy po za ustalonymi godzinami
            if (!(po >= 0 && przed <= 0))
                return istniejace[0];

            //gdy w czasie ustalonych godzin
            for (int i = 0; i < N; i++)
            {
                if (istniejace[i] == null)
                {
                    istniejace[i] = new TimeNTon();

                    return istniejace[i];
                }
            }
            //gdy tablica jest zajęta
            Console.WriteLine("zwracam obiekt nr {0}", (licznik % N));
            return istniejace[licznik % N];



        }

    }
}
