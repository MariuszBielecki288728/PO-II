package pakiet;

public class Odejmij extends Node {
	Odejmij(Wyrazenie L, Wyrazenie R){
		super(L, R);
	}
	public String toString(){
		return "("+Left.toString() +"-"+ Right.toString()+")";
	}
	public int oblicz(){
		return Left.oblicz() - Right.oblicz();
	}
		
	
}