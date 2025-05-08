using System;
using System.Collections.Generic;

namespace lab4.Task2
{
    public class CommandCentre : IMediator
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);

            foreach (var runway in _runways)
                runway.SetMediator(this);

            foreach (var aircraft in _aircrafts)
                aircraft.SetMediator(this);
        }

        public void Notify(object sender, string eventCode)
        {
            if (eventCode == "Land")
            {
                var aircraft = sender as Aircraft;
                if (aircraft != null)
                {
                    foreach (var runway in _runways)
                    {
                        if (runway.IsBusyWithAircraft == null)
                        {
                            runway.IsBusyWithAircraft = aircraft;
                            aircraft.CurrentRunway = runway;
                            runway.HighLightRed();
                            Console.WriteLine($"Літак {aircraft.Name} приземлився на злітну смугу {runway.Id}.");
                            return;
                        }
                    }
                    Console.WriteLine($"Не вдалося приземлитися, всі злітні смуги зайняті.");
                }
            }
            else if (eventCode == "TakeOff")
            {
                var aircraft = sender as Aircraft;
                if (aircraft != null && aircraft.CurrentRunway != null)
                {
                    var runway = aircraft.CurrentRunway;
                    runway.IsBusyWithAircraft = null;
                    runway.HighLightGreen();
                    aircraft.CurrentRunway = null;
                    Console.WriteLine($"Літак {aircraft.Name} злетів з злітної смуги {runway.Id}.");
                }
            }
        }
    }
}