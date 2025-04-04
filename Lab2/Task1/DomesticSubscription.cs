using System;
using System.Collections.Generic;

public class DomesticSubscription : ISubscription
{
    public decimal MonthlyFee => 9.99m;
    public int MinimumPeriod => 1;
    public List<string> Channels => new List<string> { "News", "Music", "Entertainment" };
    public List<string> Features => new List<string> { "HD", "Limited ads" };
}
