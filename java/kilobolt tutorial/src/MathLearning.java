
public class MathLearning {
	
	//class wide variables
	
	static double a = 10;
	static double b = 15;
	static double c = 22;
	
	// the counter variable
	static int counter = 0;
	
	public static void main(String[] args){
		
		// local variables only for the main method
		
		double result;
		double resultTwo;
		double resultThree;
		double resultFour;
		double resultFive;
		
		// some commands
		
		result = a + b;
		resultTwo = a- b;
		resultThree = a * c;
		resultFour  = c / b;
		resultFive  = c % b;
		
		printMe(result);
		printMe(resultTwo);
		printMe(resultThree);
		printMe(resultFour);
		printMe(resultFive);
		
	}
	
	public static void printMe(double output){
		
		//counter in action
		counter++;
		//just a printing method
		System.out.println("Result " + counter + " is " + output);
	}
}
