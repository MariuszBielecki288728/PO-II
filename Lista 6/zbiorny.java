public class Program {

    public static void main(String[] args) {
        Bufor<String> buf = new Bufor<>(100);
        Producent P = new Producent(buf);
        Konsument K = new Konsument(buf);
        Thread t1 = new Thread(P);
        Thread t2 = new Thread(K);
        t1.start();
        t2.start();



    }
// //////////////////////////////////////////////////////////
    import java.util.Vector;

    /**
     * Created by manie on 02.04.2017.
     */
    public class Bufor<T> {
        int rozmiar;
        int ile;
        int poczatek;
        Vector<T> buf;

        Bufor(int rozmiar){
            this.rozmiar = rozmiar;
            ile = 0;
            poczatek = 0;
            buf = new Vector<>(rozmiar);

        }
        synchronized boolean isFull(){
            return ile==rozmiar;
        }
        synchronized boolean isEmpty() {
            return ile==0;
        }
        synchronized void  put(T x){
            if (ile < rozmiar) {
                buf.add((poczatek + ile) % rozmiar, x);
                this.ile++;
            }
        }
        synchronized T get(){

                T x = buf.get(poczatek);
                poczatek = (poczatek + 1) % rozmiar;
                ile--;
                return x;

        }

    }

// ///////////////////////////////////////////////////////////////////
    public class Producent implements Runnable {
        Bufor<String> buf;
        String str;

        public Producent(Bufor<String> buf) {
            this.buf = buf;
            str = "";
        }

        @Override
        public void run() {
            int i=0;
            while (true) {
                while (!buf.isFull()) {
                    buf.put(str + i);
                    System.out.println("str:" +
                            this.str+i);
                    i++;
                }
                    try {
                    wait();

                    } catch (InterruptedException e) {}

            }
        }
    }




// ////////////////////////////////////////////////////////////////
    public class Konsument implements Runnable {
        Bufor<String> buf;

        public Konsument(Bufor<String> buf) {
            this.buf = buf;
        }

        @Override
        public void run() {
            while (true) {
                while (!buf.isEmpty()){
                    System.out.println(buf.get());

                    notifyAll();

                }
            }
        }
    }
