package pakiet;

import java.util.Hashtable;

public class MainClass {
	
	public static void main(String[] args) {
		Zmienna.numbers = new Hashtable<String, Integer>();
		Zmienna.numbers.put("x", 5);
		Wyrazenie wyrazenie = new Podziel(new Dodaj(new Stala(4), new Zmienna("x"))
				,new Pomnoz(new Stala(1), new Stala(3)));
		System.out.println(wyrazenie);
	}

}
