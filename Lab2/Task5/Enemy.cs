using System;
using System.Collections.Generic;

public class Enemy
{
    public string Name { get; set; }
    public string Height { get; set; }
    public string Build { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Outfit { get; set; }
    public List<string> Inventory { get; set; }
    public List<string> EvilDeeds { get; set; }

    public Enemy()
    {
        Inventory = new List<string>();
        EvilDeeds = new List<string>();
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
        Console.WriteLine("Evil Deeds: " + string.Join(", ", EvilDeeds));
    }
}
