using System;
using System.Collections;


namespace PrimeCollection
{
    class PrimeEnum : IEnumerator
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


        public PrimeEnum()
        {
            val = 0;
        }

        public bool MoveNext()
        {
            if (this.val == int.MaxValue) return false;
            else next();
            return true;
        }

        public object Current
        {
            get { return val; }
        }
        public void Reset()
        {
            val = 0;
        }
    }
    class PrimeCollection : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return new PrimeEnum();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrimeCollection x = new PrimeCollection();
            foreach(int val in x) Console.WriteLine(val);
        }
    }
}
