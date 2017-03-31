package pakiet;

import java.util.Hashtable;

public class MainClass {
	
	public static void main(String[] args) {
		Wyrazenie.numbers = new Hashtable<String, Integer>();
		Wyrazenie.numbers.put("x", 5);
		Wyrazenie wyrazenie = new Podziel(new Dodaj(new Stala(4), new Zmienna("x"))
				,new Pomnoz(new Stala(1), new Stala(3)));
		System.out.println(wyrazenie);
	}

}
