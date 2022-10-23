using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.SarbaevZlokazov.Rte
{
    static public class RouteAction
    {
        public static void Inicialise(List<Route> routes, int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("Введите название начального пункта маршрута");
                string start = Console.ReadLine();
                Console.WriteLine("Введите название конечного пункта маршрута");
                string end = Console.ReadLine();
                Console.WriteLine("Введите номер маршрута");
                int number = 0;
                if (Int32.TryParse(Console.ReadLine(), out number) == false || number < 0 || String.IsNullOrEmpty(end)==true || String.IsNullOrEmpty(start)==true)
                {
                    ThrowError();
                    continue;
                } 
                
                routes.Add(new Route(start,end, number));
            }
        }
        public static void RouteSort(List<Route> routes)
        {
            for (int i = 0; i < routes.Count; i++)
            {
                for (int j = 0; j < routes.Count - 1; j++)
                {
                    if (routes[i].Number < routes[j].Number)
                    {
                        Route empty = routes[i];
                        routes[i] = routes[j];
                        routes[j] = empty;
                    }
                }

            }

        }
        public static void RouteFind(List<Route> routes)
        {
            Console.WriteLine("Введите номер маршрута длля поиска");
            bool checker = false;
            int number = 0;
            if (Int32.TryParse(Console.ReadLine(),out number) == false)
            {
                ThrowError();
            }
            for (int i = 0; i < routes.Count; i++)
            {
                if (routes[i].Number ==number)
                {
                    Console.WriteLine(routes[i]);
                    checker = true;
                }
            }
            if (!checker)
            {
                Console.WriteLine("Таких маршрутов нет");
            }
        }
        private static void ThrowError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Некорректные даннные");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
