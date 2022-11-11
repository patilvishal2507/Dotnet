using Series;

class Program { 
	
	public static double compute(Sequence info, int count) {
		return info.sum(count) / count;
	}

	public static void Main(string[] args) {

		int n = int.Parse(args[0]);

		var a = new LinearSequence(2.0f,5.0f);
		var b = new PowerSequence(3.0f);

		Console.WriteLine(" First Linear Sequence Computation result = {0}",Program.compute(a,n));

		Console.WriteLine(" Second Linear Sequence Computation result = {0}",Program.compute(a,n));

		Console.WriteLine(" First Power Sequence Computation result ={0}",Program.compute(b,n));
		
		Console.WriteLine(" Second Power Sequence Computation result = {0}",Program.compute(b,n));

}

}