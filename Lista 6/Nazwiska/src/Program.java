import java.io.File;
import java.io.FileNotFoundException;

public class Program {

	public static void main(String[] args) throws FileNotFoundException {
		File f = new File("nazwiska.txt");
		Bufor<String> buf = new Bufor<>(1000);
		Filter x = new Filter(buf, f);
		Sort y = new Sort(buf);
		Thread t1 = new Thread(x);
		Thread t2 = new Thread(y);
		t1.start();
		t2.start();
		try{
		t2.join();}
		catch (InterruptedException e) {
		} finally {
		}
	}

}