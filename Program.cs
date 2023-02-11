namespace TULU
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            PriceManager apiManager = new PriceManager();
            List<Symbol> symbols = await apiManager.GetSymbolsInfoAsycn();

            while (true)
            {

        
                string metod = Console.ReadLine()!.Trim().ToUpperInvariant();

                 if (metod == "CLEAR")
                {
                    Console.Clear();
                }

                else if (metod.Length >= 1)
                {
                    metod += "USDT";

                    Symbol? symbol = symbols.Find(p => p.pair == metod);
                    if (symbol == null)
                    {
                        metod = "1000" + metod;
                        symbol = symbols.Find(p => p.pair == metod);
                    }

                    if (symbol != null)
                    {
                        await apiManager.GetPrice(symbol);
                    }
                    else
                    {
                        Console.WriteLine("Coin Not Found");
                    }




                }
            }
        }
    }
}