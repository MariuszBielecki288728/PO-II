using System;

namespace Zadanie_1
{
    class IntStream
    {
        protected int val = 0;
        virtual public int next()
        {
            if (!eos())
                val++;
            return val;

        }
        virtual public bool eos()
        {
            if (val == int.MaxValue)
                return true;
            return false;
        }
        public void reset()
        {
            val = 0;
        }
    }


    class PrimeStream : IntStream
    {
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
        public override int next()
        {
            if (!eos())
                val++;

            while (!czyPierwsza(val))
                val++;
            return val;
        }
    }


    class RandomStream : IntStream
    {
        Random los = new Random();
        public override int next()
        {
            return los.Next();
        }

        public override bool eos()
        {
            return false;
        }
    }

    class RandomWordStream
    {
        char[] literki = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&".ToCharArray();
        PrimeStream I = new PrimeStream();
        RandomStream L = new RandomStream();
        int val;
        public string next()
        {
            val = I.next();
            string slowo = "";
            int x;
            for (int i = 0; i < val; i++)
            {
                x = L.next();
                slowo = slowo + literki[x % literki.Length];
            }
            return slowo;
        }
    }
}









/*
        public override bool eos()
        {
            int x = val;
            while (!czyPierwsza(x))
            {
                if (x == int.MaxValue)
                    return true;
                x++;

            }
            return false;

        }*/
