/**
 * Created by manie on 02.04.2017.
 */
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

}