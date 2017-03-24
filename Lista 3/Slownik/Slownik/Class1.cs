using System;

namespace Slownik
{

    class Słownik<K, V>
    {
        K key;
        V value;
        Słownik<K, V> next;
        public Słownik()
        {
            this.key = default(K);
            this.value = default(V);
            this.next = null;
        }
        Słownik(K key, V val)
        {
            this.key = key;
            this.value = val;
            this.next = null;
        }
        public void Dodaj(K key, V val)
        {
            Słownik<K, V> last = this;
            Słownik<K, V> self = this.next;
            while (self != null)
            {
                if (self.key.Equals(key))
                {
                    Console.WriteLine("Nie możesz użyc już istniejącego klucza!");
                    return;
                }
                last = self;
                self = self.next;
            }
            last.next = new Słownik<K, V>(key, val);
        }

        public V Wyszukaj(K elem_szukany)
        {
           // Słownik<K, V> last = this;
            Słownik<K, V> self = this.next;
              
            while (self != null)
            {
                if (self.key.Equals(elem_szukany))
                    return self.value;
                self = self.next;
            }
            return default(V);
        }
        public void Usun(K elem_szukany)
        {
            Słownik<K, V> self = this.next;
            Słownik<K, V> last = this;
            while (self != null)
            {
                if (self.key.Equals(elem_szukany))
                {
                    last.next = self.next;
                    return;
                }
                last = self;
                self = self.next;
                
            }
            Console.WriteLine("Nie znaleziono klucza");
        }
        public void Wydrukuj()
        {
            Słownik<K, V> self = this.next;
            if (self == null)
            {
                Console.WriteLine("Empty Dict");
                return;
            }
            while (self!= null)
            {
                Console.WriteLine("Key = {0}, value = {1}",self.key, self.value);

                self = self.next;
            }
        }

    }
}
