package pakiet;

abstract class Wyrazenie{
	public int oblicz(){
		return 0;
	}
}
//
package pakiet;

abstract class Node extends Wyrazenie {
	Wyrazenie Left;
	Wyrazenie Right;
	Node(Wyrazenie L, Wyrazenie R){
		Left = L;
		Right = R;
	}
}


package pakiet;

class Dodaj extends Node {

	
	Dodaj(Wyrazenie L, Wyrazenie R){
		super(L, R);
	}
	public String toString(){
		return Left.toString() +"+"+ Right.toString();
	}
	public int oblicz(){
		return Left.oblicz() + Right.oblicz();
	}
		
	
}


package pakiet;

class Stala extends Wyrazenie{
	String nazwa;
	Stala(String x){
		this.nazwa = x;
	}
}
