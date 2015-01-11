import java.util.Random;


public class SomeSimulation {
	public static void main(String[] args){

	      Random rand = new Random();
	      int result = rand.nextInt(2);
	      
	      if (result == 0){
	    	  System.out.println("ezi");
	      }
	      
	      else if (result == 1){
	    	  System.out.println("tura");
	      }
	      
	      else if (result == 2){
	    	  System.out.println("kalu4, oprai si randomizatora");
	      }
	}
}
