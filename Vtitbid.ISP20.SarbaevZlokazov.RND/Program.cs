using Vtitbid.ISP20.SarbaevZlokazov.RND;
Console.WriteLine("Введите промежуток рандома");
int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Результат: {OwnRandom.Next(first,second)}");