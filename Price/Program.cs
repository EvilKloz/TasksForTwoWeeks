using Vtitbid.ISP20.SarbaevZlokazov.Price;
//Вариант 19
List<Market> markets = new List<Market>();

int counter = 2;

MarketAction.Inicialise( ref markets, counter);

MarketAction.SortPrice(ref markets);

Console.WriteLine("Введите магазин для поиска");

MarketAction.FindMarketplace(Console.ReadLine(), markets);

Console.WriteLine("Введите название для файла");

string FileTitle = Console.ReadLine();

for(int i = 0; i < counter; i++)
{
    File.AppendAllText(@$"C:\Users\student\Desktop\{FileTitle}.txt", $"{markets[i]}\n") ;
}




