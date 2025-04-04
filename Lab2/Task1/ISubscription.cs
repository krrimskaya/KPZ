using System.Collections.Generic;

public interface ISubscription
{
    decimal MonthlyFee { get; }
    int MinimumPeriod { get; }
    List<string> Channels { get; }
    List<string> Features { get; }
}
