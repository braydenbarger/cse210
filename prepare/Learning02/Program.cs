using System;
using System.Collections.Generic;

class Blind
{
    public int Width { get; set; }
    public int Height { get; set; }
    public string Color { get; set; }

    public Blind(int width, int height, string color)
    {
        Width = width;
        Height = height;
        Color = color;
    }

    public int Area()
    {
        return Width * Height;
    }
}

class House
{
    public string Owner { get; set; }
    private List<Blind> Blinds { get; set; }

    public House(string owner)
    {
        Owner = owner;
        Blinds = new List<Blind>();
    }

    public void AddBlind(Blind blind)
    {
        Blinds.Add(blind);
    }

    public int TotalBlindArea()
    {
        int totalArea = 0;
        foreach (var blind in Blinds)
        {
            totalArea += blind.Area();
        }
        return totalArea;
    }

    public void PrintHouseDetails()
    {
        Console.WriteLine($"House Details for Owner: {Owner}");
        Console.WriteLine("Blinds:");
        foreach (var blind in Blinds)
        {
            Console.WriteLine($"- Width: {blind.Width} inches, Height: {blind.Height} inches, Color: {blind.Color}");
        }
        Console.WriteLine($"Total Blind Area: {TotalBlindArea() / 144.0:F2} square feet");
    }
}

class Program
{
    static void Main()
    {
        House house = new House("Johnson Family");

        house.AddBlind(new Blind(60, 48, "White"));
        house.AddBlind(new Blind(72, 60, "Beige"));

        house.PrintHouseDetails();
    }
}
