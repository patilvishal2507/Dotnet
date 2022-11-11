using banner;

class Program
{
    
   
    public static void Main(string[] args)
    {
        int w = int.Parse(args [0]);
        int h = int.Parse(args [1]);
        int r = int.Parse(args [2]);
       Banner b =new Banner(w,h);
       CurvedBanner cb = new CurvedBanner(w, h, r);
 
        Console.WriteLine("The width of Banner is ={0}", w );
        Console.WriteLine("the height of Banner is ={0}", h);
        Console.WriteLine("the redius of CurvedBanner is ={0}", r);
       
        Console.WriteLine("Area of Banner is {0}", b.area ());
        Console.WriteLine("Area of CurvedBanner is ={0}" ,cb.area ());
    }


}