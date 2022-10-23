using Vtitbid.ISP20.SarbaevZlokazov.Project;
//Вариант 13
Person[] people = new Person[3];

for (int i = 0; i < people.Length; i++)
{
    Console.WriteLine("№" + (i + 1));
    Console.WriteLine("Имя: ");
    string? firstname = Console.ReadLine();
    Console.WriteLine("Фамилия: ");
    string? lastname = Console.ReadLine();
    Console.WriteLine("Номер телефона: ");
    string? number = Console.ReadLine();
    Console.WriteLine("Дата рождения: ");
    DateTime temp;
    if (DateTime.TryParse(Console.ReadLine(), out temp)== true)
    {
        people[i] = new Person(firstname, lastname, number, temp);
    }
    else
    {
        PersonAction.GetError();
    }
   
}

PersonAction.SortPerson(ref people);

Console.WriteLine("Введите месяц");


int month = Int32.Parse(Console.ReadLine());
PersonAction.GetInfoDayOfBirth(people, month);

Console.WriteLine("Введите название файла");
string title= Console.ReadLine();
for (int i = 0; i < people.Length; i++)
{
    File.AppendAllText(@$"C:\Users\student\Desktop\{title}.txt", $"{people[i].ToString()}\n\n");

}




