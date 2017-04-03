package pakiet;

import java.util.Hashtable;

public class Zmienna extends Wyrazenie  {
	String nazwa;
	public static  Hashtable<String, Integer> numbers;

	
	public Zmienna(String nazwa) {
		this.nazwa = nazwa;
	}
	public String toString(){
		return nazwa;
	}
	public int oblicz(){
		return numbers.get(nazwa);
	}
}
