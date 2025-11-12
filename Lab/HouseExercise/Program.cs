using System;
public class HouseExcercise
{

    public int Year { get; private set; }
    public double Size { get; private set; }
    public HouseExcercise(int year, double size)

    {
        this.Year = year;
        this.Size = size;
    }
    private int HowOld()
    {
        int CurrentYear = DateTime.Now.Year;
        return CurrentYear - Year;
    }
    public bool CanBeSold()
    {
        int age = HowOld();
        return age > 15;
    }
    public void Display()
    {
        Console.WriteLine($"Build in the house : {Year}");
        Console.WriteLine($"Size: {Size} squarfeet");
        Console.WriteLine($"Canbe sold:{CanBeSold()}");
    }
    public static void Main()
    {
        Console.Write("Enter the year when house was built :");
        int Year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the size of house : ");
        double Size = Convert.ToDouble(Console.ReadLine());
        HouseExcercise house = new HouseExcercise(Year, Size);
        house.Display();




    }
}

        



