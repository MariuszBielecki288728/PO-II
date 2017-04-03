
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
