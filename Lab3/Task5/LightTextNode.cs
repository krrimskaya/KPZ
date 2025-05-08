public class LightTextNode : LightNode
{
    public string Text { get; set; }

    public LightTextNode(string text)
    {
        Text = text;
    }

    public override string GetOuterHTML()
    {
        return Text;
    }

    public override string GetInnerHTML()
    {
        return Text;
    }
}