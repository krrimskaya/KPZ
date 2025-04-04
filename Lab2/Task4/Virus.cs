using System;
using System.Collections.Generic;

public class Virus : ICloneable
{
    public string Name { get; set; }
    public string Type { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }
    public List<Virus> Children { get; set; }

    // Конструктор для ініціалізації віруса
    public Virus(string name, string type, double weight, int age)
    {
        Name = name;
        Type = type;
        Weight = weight;
        Age = age;
        Children = new List<Virus>();
    }

    // Метод для клонування віруса та його дітей
    public object Clone()
    {
        // Створення поверхневого копіювання
        Virus clone = (Virus)this.MemberwiseClone();

        // Клонуємо дітей віруса
        clone.Children = new List<Virus>();
        foreach (var child in this.Children)
        {
            clone.Children.Add((Virus)child.Clone());
        }

        return clone;
    }

    // Додавання дитини до віруса
    public void AddChild(Virus child)
    {
        Children.Add(child);
    }

    // Виведення інформації про вірус та його дітей
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Type: {Type}, Weight: {Weight}kg, Age: {Age} years.");
        Console.WriteLine("Children:");
        foreach (var child in Children)
        {
            child.ShowInfo();
        }
    }
}
