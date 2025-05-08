namespace KPZ.Lab3.Task5
{
    public class LightTextNode : LightNode
    {
        public string Text { get; }

        public LightTextNode(string text)
        {
            Text = text;
        }

        public override string GetOuterHTML() => Text;
        public override string GetInnerHTML() => Text;
    }
}