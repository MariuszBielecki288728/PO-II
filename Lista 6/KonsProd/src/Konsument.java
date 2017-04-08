/**
 * Created by manie on 02.04.2017.
 */
public class Konsument implements Runnable {
	Bufor<String> buf;
	String get;

	public Konsument(Bufor<String> buf) {
		this.buf = buf;
	}

	@Override
	public void run() {
		while (true) {
			get = buf.get();
			if (get!=null) System.out.println(get);
			else break;

		}
		System.out.println("elo");
	}
}
