using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var button = new LightElementNode("button", isBlock: false, isSelfClosing: false);
        button.Children.Add(new LightTextNode("Натисни мене")); // Замість AddChild
        
        // + обробники подій
        button.AddEventListener("click", () => Console.WriteLine("Кнопку натиснуто!"));
        button.AddEventListener("mouseover", () => Console.WriteLine("Мишка над кнопкою!"));
        
        Console.WriteLine("Демонстрація Observer:");
        button.TriggerEvent("mouseover");
        button.TriggerEvent("click");
        
        Console.WriteLine("\nHTML кнопки:");
        Console.WriteLine(button.GetOuterHTML());
    }
}