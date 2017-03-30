package pakiet;

public class Stala extends Wyrazenie{
	int x;
	Stala(int x){
		this.x = x;
	}
	public String toString(){
		return ""+x;
	}
	public int oblicz(){
		return this.x;
	}
}
