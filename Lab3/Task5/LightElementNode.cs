using System;
using System.Collections.Generic;
using System.Linq;

public class LightElementNode : LightNode
{
    public string TagName { get; set; }
    public bool IsBlock { get; set; }
    public bool IsSelfClosing { get; set; }
    public List<string> CssClasses { get; set; } = new List<string>();
    public List<LightNode> Children { get; set; } = new List<LightNode>();
    
    private Dictionary<string, List<Action>> _eventListeners = new Dictionary<string, List<Action>>();

    public LightElementNode(string tagName, bool isBlock = false, bool isSelfClosing = false)
    {
        TagName = tagName;
        IsBlock = isBlock;
        IsSelfClosing = isSelfClosing;
    }

    // Методи для роботи з подіями
    public void AddEventListener(string eventType, Action handler)
    {
        if (!_eventListeners.ContainsKey(eventType))
        {
            _eventListeners[eventType] = new List<Action>();
        }
        _eventListeners[eventType].Add(handler);
    }

    public void RemoveEventListener(string eventType, Action handler)
    {
        if (_eventListeners.ContainsKey(eventType))
        {
            _eventListeners[eventType].Remove(handler);
        }
    }

    public void TriggerEvent(string eventType)
    {
        if (_eventListeners.ContainsKey(eventType))
        {
            foreach (var handler in _eventListeners[eventType].ToList())
            {
                handler.Invoke();
            }
        }
    }

    // Методи для рендерингу HTML
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