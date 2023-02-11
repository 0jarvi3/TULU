using System.Diagnostics;
using Newtonsoft.Json;
namespace TULU;

public class PriceManager
{
    private static HttpClient client;

    public PriceManager()
    {
        client = new HttpClient();
        client.DefaultRequestHeaders.Connection.Add("keep-alive");
        client.BaseAddress = new Uri(URLs.baseUrl);
    }


    public async Task GetPrice(Symbol symbol)
    {
        string url = URLs.price + "?symbol=" + symbol.symbol;
        HttpResponseMessage response = await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        Price price = JsonConvert.DeserializeObject<Price>(responseBody);
        Console.WriteLine($"{price.symbol} : {price.price}");
    }

    public async Task<List<Symbol>> GetSymbolsInfoAsycn()
    {
        List<Symbol> symbols = new List<Symbol>();

        HttpResponseMessage response = await client.GetAsync(URLs.exchangeInfo);
        string responseBody = await response.Content.ReadAsStringAsync();
        ExchangeInfo exchangeInfo = JsonConvert.DeserializeObject<ExchangeInfo>(responseBody);
        foreach (Symbol symbol in exchangeInfo.symbols)
        {
            if (symbol.pair.EndsWith("USDT") && symbol.contractType == "PERPETUAL" && symbol.status == "TRADING")
            {
                symbols.Add(symbol);
            }
        }

        Console.WriteLine("Symbol Getirildi");
        return symbols;
    }
}