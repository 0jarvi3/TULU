﻿namespace TULU;

public class ExchangeInfo
{
    public string timezone { get; set; }
    public long serverTime { get; set; }
    public string futuresType { get; set; }
    public List<object> rateLimits { get; set; }
    public List<object> exchangeFilters { get; set; }
    public List<object> assets { get; set; }
    public List<Symbol> symbols { get; set; }
}