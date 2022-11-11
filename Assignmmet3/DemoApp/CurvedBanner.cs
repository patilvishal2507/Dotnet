namespace banner;

class CurvedBanner : Banner
{
    public int radius { get; set;}
     
     public CurvedBanner(int w, int h, int r) : base(w ,h)
     {
       
        radius = r;
     }
    public override double area()
    {
        return base.area () - 0.86 * radius * radius;
    }

}