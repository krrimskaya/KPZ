using System;
using System.Collections.Generic;

public class Hero
{
    public string Name { get; set; }
    public string Height { get; set; }
    public string Build { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Outfit { get; set; }
    public List<string> Inventory { get; set; }
    public List<string> GoodDeeds { get; set; }

    public Hero()
    {
        Inventory = new List<string>();
        GoodDeeds = new List<string>();
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Height: {Height}");
        Console.WriteLine($"Build: {Build}");
        Console.WriteLine($"Hair Color: {HairColor}");
        Console.WriteLine($"Eye Color: {EyeColor}");
        Console.WriteLine($"Outfit: {Outfit}");
        Console.WriteLine("Inventory: " + string.Join(", ", Inventory));
        Console.WriteLine("Good Deeds: " + string.Join(", ", GoodDeeds));
    }
}
