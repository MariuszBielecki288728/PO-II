/**
 * Created by manie on 02.04.2017.
 */
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