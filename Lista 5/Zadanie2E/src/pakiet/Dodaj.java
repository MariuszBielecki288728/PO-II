package pakiet;

public class Dodaj extends Node {

	
	Dodaj(Wyrazenie L, Wyrazenie R){
		super(L, R);
	}
	public String toString(){
		return "("+Left.toString() +"+"+ Right.toString()+")";
	}
	public int oblicz(){
		return Left.oblicz() + Right.oblicz();
	}
		
	
}