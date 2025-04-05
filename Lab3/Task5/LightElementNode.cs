using System;
using System.Collections.Generic;
using System.Linq;

public class LightElementNode : LightNode
{
    public string TagName { get; set; }
    public bool IsBlockElement { get; set; }  // Для блокових чи рядкових елементів
    public bool IsSelfClosing { get; set; }   // Для одиничних тегів, таких як <img />
    
    // для зберігання CSS класів
    public List<string> CSClasses { get; set; } = new List<string>(); 
    
    public List<LightNode> Children { get; set; } = new List<LightNode>();

    public LightElementNode(string tagName, bool isBlockElement = false, bool isSelfClosing = false)
    {
        TagName = tagName;
        IsBlockElement = isBlockElement;
        IsSelfClosing = isSelfClosing;
    }

    public override string GetOuterHTML()
    {
        if (IsSelfClosing)
        {
            return $"<{TagName} />";
        }
        else
        {
            string classAttribute = CSClasses.Count > 0 ? $" class=\"{string.Join(" ", CSClasses)}\"" : "";
            string childrenHTML = string.Join("", Children.Select(child => child.GetOuterHTML()));
            return $"<{TagName}{classAttribute}>{childrenHTML}</{TagName}>";
        }
    }

    public override string GetInnerHTML()
    {
        return string.Join("", Children.Select(child => child.GetInnerHTML()));
    }
}
