import java.util.LinkedList;

public class Sort implements Runnable {
	Bufor<String> buf;
	LinkedList<String> lista;
	String nazw;
	
	Sort(Bufor<String> b){
		buf = b;
		lista = new LinkedList<>();
	}
	public void print(){
		for (int i = 0; i<lista.size(); i++)
			System.out.print(lista.get(i));
	}
	@Override
	public void run() {
		lista.add(0, buf.get());
		
		while (true){
			//System.out.println(buf.czyProdZakon);
			nazw = buf.get();
			if (nazw==null) break;
			//System.out.println(nazw);
			for (int i = lista.size()-1; i>=0; i--){
				if ((lista.get(i).compareTo(nazw))<0)
				{
					lista.add(i+1, nazw);
					
					break;
				}
			}

		}
		System.out.println(lista);
		//System.out.println("koniec2");
		
	}
}