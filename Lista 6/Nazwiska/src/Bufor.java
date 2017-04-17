import java.util.Collections;
import java.util.Vector;

/**
 * Created by manie on 02.04.2017.
 */
public class Bufor<T> {
	public boolean czyProdZakon;
	int rozmiar;
	int ile;
	//int poczatek;
	Vector<T> buf;

	Bufor(int rozmiar) {
		this.rozmiar = rozmiar;
		ile = 0;
		//poczatek = 0;
		//buf = new Vector<>(Collections.nCopies(rozmiar, null));
		buf = new Vector<>(rozmiar);
	}

	/*synchronized boolean czyProdZakon() {
		return czyProdZakon;
	}

	synchronized void ZakonProd() {
		czyProdZakon = true;
	}
	*/
	synchronized void ustaw(){
		this.czyProdZakon=true;
		notify();
	}
	synchronized void put(T x) {
		while (ile == rozmiar) {
			try {
				wait();
			} catch (InterruptedException e) {
			} finally {
			}
		}
		//buf.set((poczatek + ile) % rozmiar, x);
		buf.add(x);
		this.ile++;
		notify();

	}

	synchronized T get() {
		while (ile == 0) {
			if(czyProdZakon){
				return null;
			}
			try {
				wait();
			} catch (InterruptedException e) {
			} finally {
			}
			
		}
		T x = buf.remove(0);//buf.get(poczatek);
		//poczatek = (poczatek + 1) % rozmiar;
		ile--;
		notify();
		return x;

	}

}