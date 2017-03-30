package pakiet;

public class Zmienna extends Wyrazenie  {
	String nazwa;
	
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
