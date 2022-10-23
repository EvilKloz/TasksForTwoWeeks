using Vtitbid.ISP20.SarbaevZlokazov.Zod;

List<Person> person = new List<Person>();

int count = 2;

Zodiac.Inicialize(ref person, count);

Zodiac.SortDate(ref person);
Console.WriteLine("Введите знак зодиака для поиска");
Zodiac.FindZodiak(person, Console.ReadLine());
Console.WriteLine("Введите название файла");
string title = Console.ReadLine();
for(int i = 0; i < person.Count; i++)
{
    File.AppendAllText(@$"C:\Users\student\Desktop\{title}.txt", $"{person[i]}\n");
}