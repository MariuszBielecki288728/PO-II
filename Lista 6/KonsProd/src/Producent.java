/**
 * Created by manie on 02.04.2017.
 */
public class Producent implements Runnable {
	Bufor<String> buf;
	String str;

	public Producent(Bufor<String> buf) {
		this.buf = buf;
		str = "";
	}

	@Override
	public void run() {
		//int i = 0;
		for (int i =0; i<10000; i++) {
			buf.put(str + i);
			System.out.println("str:" + this.str + i);
			i++;
		}
		buf.czyProdZakon=true;

	}
}