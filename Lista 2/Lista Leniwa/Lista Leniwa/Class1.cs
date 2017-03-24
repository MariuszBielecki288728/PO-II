using System;
using System.Collections.Generic;


namespace Lista_Leniwa
{
    class ListaLeniwa
    {
        List<int> parts;
        Random rnd = new Random();

        public ListaLeniwa()
        {
            parts = new List<int>();
        }

        public int size()
        {
            return parts.Count;
        }

        virtual protected int add()
        {
            return rnd.Next();
        }

        public int element(int i)
        {
            if (i < parts.Count)
                return parts[i - 1];
            else
            {
                while (i - 1 >= parts.Count)
                    parts.Add(add());
                return parts[i - 1];
            }
        }
    }

    class Pierwsze : ListaLeniwa
    {
        int val;

        bool czyPierwsza(int x)
        {
            if (x == 2)
                return true;
            if (x < 2 || x % 2 == 0)
                return false;
            for (int i = 3; i * i <= x + 1; i = i + 2)
                if (x % i == 0)
                    return false;
            return true;
        }

        int next()
        {
            val++;
            while (!czyPierwsza(val))
                val++;
            return val;
        }

        protected override int add()
        {
            return next();
        }

    }
    }
