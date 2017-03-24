using System;




namespace Gramatyki
{
    class Node
    {
        public string etykieta;
        public List dzieci;
        public Node(string s)
        {
            etykieta = s;
            dzieci = new List();
        }

    }

    class List
    {
        public Node val;
        public List next;
        public List()
        {
            val = null;
            next = null;
        }
        List(Node v)
        {
            val = v;
            next = null;
        }
        public void add(Node v)
        {
            List last = this;
            List self = this.next;
            while (self != null)
            {
                last = self;
                self = self.next;
            }
            last.next = new List(v);
        }
    }
    class Drzewo
    {
        string[] N;
        string[] T;
        string[][] P;
        string S;
        Node wezel;
        public Drzewo(string[] n, string[] t, string[][] p, string s)
        {
            N = (string[])n.Clone();
            T = (string[])t.Clone();
            P = (string[][])p.Clone();
            S = s;
            wezel = new Node(s);
        }

        public void dodaj(Node dziecko)
        {
            wezel.dzieci.add(dziecko);
        }

        void wydrukuj(Node node)
        {
            if (node.dzieci.next == null)
            {
                Console.WriteLine(node.etykieta);
                return;
            }
            else
            {
                List self = node.dzieci.next;

                while (self != null)
                {
                    wydrukuj(self.val);
                    self = self.next;
                }
            }

        }
        public void wydrukuj()
        {
            wydrukuj(wezel);
        }
        class Program
        {
            static void Main(string[] args)
            {
                string[] N = { "S", "T" };
                string[] T = { "1", "2", "3" };
                string[][] P = { new string[] { "S", "T", "S", "T" }, new string[] {"S", "" },
                                 new string[] {"T", "1"}, new string[] {"T", "2"}, new string[] {"T", "3"} };
                string S = "S";
            }
        }
    }
}
