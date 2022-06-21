using Newtonsoft.Json;

namespace DiscordBot;

public class PriceProvider
{
    private const string _address = "https://poe.ninja/api/data/currencyoverview?league=Sentinel&type=Currency";

    public decimal GetPriceInChaos(string currencyName)
    {
        var json = GetData();
        var root = JsonConvert.DeserializeObject<Root>(json);

        var currency = root!.lines.FirstOrDefault(x => x.currencyTypeName.ToLower() == currencyName.ToLower());

        return currency?.chaosEquivalent ?? -1M;
    }

    public decimal GetPriceInExalted(string currencyName)
    {
        var json = GetData();
        var root = JsonConvert.DeserializeObject<Root>(json);
        var currency = root!.lines.First(x => x.currencyTypeName.ToLower() == "Exalted orb".ToLower());


        var chaosPrice = GetPriceInChaos(currencyName);
        if (chaosPrice == -1)
        {
            return -1;
        }
        else
        {
            return Math.Round(chaosPrice / currency.chaosEquivalent, 2);
        }
    }


    private string GetData()
    {
        var request = new GetRequest(_address);
        request.Run();

        return request.Response!;
    }
}
