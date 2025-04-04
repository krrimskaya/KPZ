using System;
using System.Collections.Generic;

public class PremiumSubscription : ISubscription
{
    public decimal MonthlyFee => 29.99m;
    public int MinimumPeriod => 6;
    public List<string> Channels => new List<string> { "Sports", "Movies", "Exclusive Shows" };
    public List<string> Features => new List<string> { "4K", "No ads", "Premium Support" };
}
