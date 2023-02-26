using System;

public class Point
{
    private int x, y;
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
    public int ColorR
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
    public int ColorB
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
    public int ColorG
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

    public Point()
    {
        x = 0;
        y = 0;
        red = 0;
        blue = 0;
        green = 0;
    }
    public Point(int X, int Y, int Red, int Green, int Blue)
    {
        CoordX = X;
        CoordY = Y;
        ColorR = Red;
        ColorG = Green;
        ColorB = Blue;

    }

    public void Show()
    {
        System.Console.WriteLine("Coordinates:\n" + CoordX + "," + CoordY);
        System.Console.WriteLine("Colors:\n" + "[" + ColorR + "," + ColorG + "," + ColorB + "]\n");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Point obj1 = new Point(39, 50, 0, 255, 0);
        obj1.Show();

        System.Console.WriteLine("Change:");
        obj1.ColorR = 38;
        obj1.Show();


    }
}