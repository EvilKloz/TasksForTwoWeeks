using Vtitbid.ISP20.SarbaevZlokazov.Rte;
//Вариант 10
List<Route> routes = new List<Route>();

int counter = 3;
RouteAction.Inicialise(routes, counter);


RouteAction.RouteSort(routes);

RouteAction.RouteFind(routes);

Console.WriteLine("Ввведите название файла");

string title = Console.ReadLine();

for(int i = 0; i < routes.Count; i++)
{
    File.AppendAllText(@$"C:\Users\student\Desktop\{title}.txt", $"{routes[i]}\n\n");
}
