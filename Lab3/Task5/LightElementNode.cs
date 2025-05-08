using System;
using System.Collections.Generic;
using System.Linq;

namespace KPZ.Lab3.Task5
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public bool IsBlockElement { get; set; }
        public bool IsSelfClosing { get; set; }
        public List<string> CssClasses { get; set; } = new List<string>();
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
                return $"<{TagName} class=\"{string.Join(" ", CssClasses)}\" />";
            }
            
            string classes = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
            string children = string.Join("", Children.Select(c => c.GetOuterHTML()));
            return $"<{TagName}{classes}>{children}</{TagName}>";
        }

        public override string GetInnerHTML()
        {
            return string.Join("", Children.Select(c => c.GetOuterHTML()));
        }
    }
}