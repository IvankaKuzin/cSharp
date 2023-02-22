public class Point
{
    private int x; private int y;
    private int red, green, blue;

    public int CoordX
    {
        get { return x; }
        set { x = value; }
    }
    public int CoordY
    {
        get { return y; }
        set { y = value; }
    }
    public int ColirR
    {
        get { return red; }
        set
        {
            if (value >= 0 && value <= 255)
            {
                red = value;
            }
            else
            {
                red = 0;
                System.Console.WriteLine("Value color is  '< 0' or '> 255'");
            }
        }
    }
    public int ColirB
    {
        get { return blue; }
        set
        {
            if (value >= 0 && value <= 255)
            {
                blue = value;
            }
            else
            {
                blue = 0;
                System.Console.WriteLine("Value color is  '< 0' or '> 255'");
            }
        }
    }
    public int ColirG
    {
        get { return green; }
        set
        {
            if (value >= 0 && value <= 255)
            {
                green = value;
            }
            else
            {
                green = 0;
                System.Console.WriteLine("Value color is  '< 0' or '> 255'");
            }
        }
    }

    public Point(int X, int Y, int Red, int Green, int Blue)
    {
        CoordX = X;
        CoordY = Y;
        ColirR = Red;
        ColirG = Green;
        ColirB = Blue;

    }

    public void Show()
    {
        System.Console.WriteLine("Coordinates:\n" + CoordX + "," + CoordY + "\n");
        System.Console.WriteLine("Colors:\n" + "[" + ColirR + "," + ColirG + "," + ColirB + "]\n");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Point obj1 = new Point(5, 5, 0, 255, 0);
        obj1.Show();

        System.Console.WriteLine("Color change:");

        obj1.ColirR = 100;
        obj1.Show();
    }
}