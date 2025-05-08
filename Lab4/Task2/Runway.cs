using System;

namespace lab4.Task2
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public Aircraft? IsBusyWithAircraft { get; set; }
        private IMediator? _mediator;

        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public void HighLightRed()
        {
            Console.WriteLine($"Злітна смуга {this.Id} зайнята!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Злітна смуга {this.Id} вільна!");
        }
    }
}