import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Filter implements Runnable {
	Bufor<String> buf;
	Scanner in;
	String line;
	Filter(Bufor<String> b, File f) throws FileNotFoundException{
		buf = b;
		in = new Scanner(f);
	}
	@Override
	public void run() {
		while(in.hasNextLine()){
			line = in.nextLine();
			//System.out.println(line);
			if (check(line)){
				buf.put(line);
				
			}
		}
		in.close();
		buf.ustaw();
		
		System.out.println("koniec");
	}
	
	
	
	
	
	private boolean check(String line2) {
		return line2.length()<10;
	}
}