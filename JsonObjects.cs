
public class Line
{
    public string currencyTypeName { get; set; }
    public Pay pay { get; set; }
    public Receive receive { get; set; }
    public decimal chaosEquivalent { get; set; }
    public string detailsId { get; set; }
}

public class Pay
{
    public int id { get; set; }
    public int league_id { get; set; }
    public int pay_currency_id { get; set; }
    public int get_currency_id { get; set; }
    public DateTime sample_time_utc { get; set; }
    public int count { get; set; }
    public double value { get; set; }
    public int data_point_count { get; set; }
    public bool includes_secondary { get; set; }
    public int listing_count { get; set; }
}

public class Receive
{
    public int id { get; set; }
    public int league_id { get; set; }
    public int pay_currency_id { get; set; }
    public int get_currency_id { get; set; }
    public DateTime sample_time_utc { get; set; }
    public int count { get; set; }
    public double value { get; set; }
    public int data_point_count { get; set; }
    public bool includes_secondary { get; set; }
    public int listing_count { get; set; }
}

public class Root
{
    public List<Line> lines { get; set; }
}
