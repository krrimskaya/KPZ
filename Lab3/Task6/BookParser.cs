using System;
using System.Collections.Generic;

public class BookParser
{
    private HtmlElementFactory _htmlElementFactory;

    public BookParser()
    {
        _htmlElementFactory = new HtmlElementFactory();
    }

    public List<LightNode> ParseBookText(string[] lines)
    {
        List<LightNode> htmlElements = new List<LightNode>();

        foreach (var line in lines)
        {
            LightNode node;

            if (line.Length < 20)
            {
                node = _htmlElementFactory.GetElement("h2", line);
            }
            else if (line.StartsWith(" "))
            {
                node = _htmlElementFactory.GetElement("blockquote", line);
            }
            else if (line.Contains("\n") && line.Length > 20) 
            {
                node = _htmlElementFactory.GetElement("h1", line); 
            }
            else
            {
                node = _htmlElementFactory.GetElement("p", line);
            }

            htmlElements.Add(node);
        }

        return htmlElements;
    }
}
