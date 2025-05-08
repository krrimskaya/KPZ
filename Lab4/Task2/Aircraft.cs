namespace lab4.Task2
{
    public class Aircraft
    {
        public string Name { get; }
        public Runway? CurrentRunway { get; set; }
        private IMediator? _mediator;

        public Aircraft(string name)
        {
            this.Name = name;
        }

        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public void RequestLand()
        {
            Console.WriteLine($"Літак {this.Name} запитує дозвіл на посадку.");
            _mediator?.Notify(this, "Land");
        }

        public void RequestTakeOff()
        {
            Console.WriteLine($"Літак {this.Name} запитує дозвіл на зліт.");
            _mediator?.Notify(this, "TakeOff");
        }
    }
}