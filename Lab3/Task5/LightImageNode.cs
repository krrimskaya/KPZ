using System;

namespace KPZ.Lab3.Task5
{
    public class LightImageNode : LightNode
    {
        private readonly string _source;
        private readonly IImageLoadingStrategy _strategy;

        public LightImageNode(string source, IImageLoadingStrategy strategy)
        {
            _source = source ?? throw new ArgumentNullException(nameof(source));
            _strategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        }

        public override string GetOuterHTML()
        {
            try
            {
                byte[] imageData = _strategy.LoadImage(_source);
                return $"<img src='data:image;base64,{Convert.ToBase64String(imageData)}' />";
            }
            catch (Exception ex)
            {
                return $"<!-- Error loading image: {ex.Message} -->";
            }
        }

        public override string GetInnerHTML() => string.Empty;
    }
}