using System;
using System.Collections.Generic;

public class HtmlElementFactory
{
    // Словник для зберігання вже створених елементів HTML
    private Dictionary<string, LightElementNode> _elements = new Dictionary<string, LightElementNode>();

    public LightNode GetElement(string tagName, string innerText)
    {
        if (!_elements.ContainsKey(tagName))
        {
            var element = new LightElementNode(tagName);
            _elements[tagName] = element;
        }

        var node = _elements[tagName];
        
        node.Children.Clear();  
        node.Children.Add(new LightTextNode(innerText));  

        return node;
    }
}
