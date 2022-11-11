using Math;
class Program
{
    public static void Main(string[]args)
    {

    int x = int.Parse(args[0]);
    int y = int.Parse(args[1]); 
    
    
    Boolean number = MathUtil.isEven(y);
    if (number == true)
      Console.WriteLine("the number is even:{0}",y);
    
    
    Boolean number1 = MathUtil.isOdd(x);
    if (number1 == true )
    Console.WriteLine("the number is even:{0}",x);
    else
    Console.WriteLine("the number is odd:{0}",x);

    
    Boolean number2 = MathUtil.isPrime(x);
    if (number2 == true)
    Console.WriteLine("the number is prime:{0}",x);
    else
    Console.WriteLine("the number is not prime:{0}",x);
    
    int number3 = MathUtil.countPrimes(x,y);
    Console.WriteLine("the total prime number is:{0} {1}",x,y);

    int number4 = MathUtil.reverse(x);
    Console.WriteLine("the reverse number is:{0} ",x);

    int number5 = MathUtil.digitCount(x);

    Console.WriteLine("the digit count is:{0} ",x);


}
}
