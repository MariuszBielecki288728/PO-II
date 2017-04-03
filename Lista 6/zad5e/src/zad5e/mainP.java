package zad5e;

public class mainP {

	int[] merge_sort(int[] tab, int start, int stop){
		int NewStop = stop/2;
		int Newstart = NewStop+1;
		merge_sort(tab, start, NewStop);
		merge_sort(tab, Newstart, stop);
		
		
	}
	public static void main(String[] args) {
		

	}

}
