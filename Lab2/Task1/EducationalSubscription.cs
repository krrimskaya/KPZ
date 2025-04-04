using System;
using System.Collections.Generic;

public class EducationalSubscription : ISubscription
{
    public decimal MonthlyFee => 19.99m;
    public int MinimumPeriod => 3;
    public List<string> Channels => new List<string> { "Education", "Science", "Documentaries" };
    public List<string> Features => new List<string> { "HD", "No ads", "Extra resources" };
}
