using System;

class Vehicle
{
    public string Make;
    public string Model;
    public int Year;
}

class Truck : Vehicle
{
    public void DisplayDetails()
    {
        Console.WriteLine($"Truck: {Make}, {Model}, {Year}");
    }
}

class Bus : Vehicle
{
    public void DisplayDetails()
    {
        Console.WriteLine($"Bus: {Make}, {Model}, {Year}");
    }
}

class Program2
{
    static void Main()
    {
        Truck t = new Truck();
        t.Make = "Maruti";
        t.Model = "LPT 1233";
        t.Year = 2022;
        t.DisplayDetails();

        Bus b = new Bus();
        b.Make = "Eicher";
        b.Model = "9400XL";
        b.Year = 2023;
        b.DisplayDetails();
    }
}