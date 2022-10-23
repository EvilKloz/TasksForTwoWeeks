using Vtitbid.ISP20.SarbaevZlokazov.Std;

string[] students =  File.ReadAllLines(@"C:\Users\student\Documents\ISP20\Vtitbid.ISP20.SarbaevZlokazov.Projects\Vtitbid.ISP20.SarbaevZlokazov.Project\Students.txt");

List<Person> people = Person.SplitData(students);

Sorting.AlphabetSort(ref people);

Console.WriteLine("Выберите способ сортировки:\n1. Сортировка по алфавиту\n2. Сортировка по среднему баллу");

byte temp = Byte.Parse(Console.ReadLine());

switch (temp)
{
    case 1:
        Sorting.AlphabetSort(ref people);
        break;
    case 2:
        Sorting.MarkSort(ref people);
        break;
    default:
        Console.WriteLine("Метод сортировки не распознан");
        Environment.Exit(1);
        break;    
}
Console.WriteLine("Введите имя для нового файла");
string title = Console.ReadLine();

for (int i = 0; i < people.Count; i++)
{
    Console.WriteLine(people[i]);
}
for (int i = 0; i < people.Count; i++)
{
    File.AppendAllText(@$"C:\Users\student\Desktop\{title}.txt", $"{people[i]}\n");
}