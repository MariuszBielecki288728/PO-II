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
