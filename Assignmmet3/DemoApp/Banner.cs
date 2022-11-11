namespace banner;
class Banner
{
    public int width { get; set; }
    public int height { get; set; }

    
    public Banner(int h, int w)
    {
        width = w;
        height = h;

    }

    public virtual double area()
    {
        return width * height;
    }

}