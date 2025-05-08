public abstract class LightNode
{
    public abstract string GetOuterHTML();
    public abstract string GetInnerHTML();
    
    public virtual void AddEventListener(string eventType, Action handler)
    {
        throw new NotImplementedException();
    }
    
    public virtual void TriggerEvent(string eventType)
    {
        throw new NotImplementedException();
    }
}