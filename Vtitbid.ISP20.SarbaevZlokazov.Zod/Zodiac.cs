using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.SarbaevZlokazov.Zod
{
    public static class Zodiac
    {
        //public static string GiveRudeZodiak(DateTime dayOfBirth)
        //{
        //    switch (dayOfBirth.Month)
        //    {
        //        case 1: return "Козерог";
        //        case 2: return "Водолей";
        //        case 3: return "Рыбы";
        //        case 4: return "Овен";
        //        case 5: return "Телец";
        //        case 6: return "Близнецы";
        //        case 7: return "Рак";
        //        case 8: return "Лев";
        //        case 9: return "Дева";
        //        case 10: return "Весы";
        //        case 11: return "Скорпион";
        //        case 12: return "Стрелец";
        //    }
        //    return null;
        //}
        public static string GiveZodiak(DateTime dayOfBirth)
        {
            if ((dayOfBirth.Month == 1 && dayOfBirth.Day >= 21) || (dayOfBirth.Month == 2 && dayOfBirth.Day <= 18))
            {
                return "Водолей";
            }
            else if ((dayOfBirth.Month == 2 && dayOfBirth.Day >= 19) || (dayOfBirth.Month == 3 && dayOfBirth.Day <= 20))
            {
                return "Рыбы";
            }
            else if ((dayOfBirth.Month == 3 && dayOfBirth.Day >= 21) || (dayOfBirth.Month == 4 && dayOfBirth.Day <= 20))
            {
                return "Овен";
            }
            else if ((dayOfBirth.Month == 4 && dayOfBirth.Day >= 21) || (dayOfBirth.Month == 5 && dayOfBirth.Day <= 21))
            {
                return "Телец";
            }
            else if ((dayOfBirth.Month == 5 && dayOfBirth.Day >= 22) || (dayOfBirth.Month == 6 && dayOfBirth.Day <= 21))
            {
                return "Близнецы";
            }
            else if ((dayOfBirth.Month == 6 && dayOfBirth.Day >= 22) || (dayOfBirth.Month == 7 && dayOfBirth.Day <= 22))
            {
                return "Рак";
            }
            else if ((dayOfBirth.Month == 7 && dayOfBirth.Day >= 23) || (dayOfBirth.Month == 8 && dayOfBirth.Day <= 21))
            {
                return "Лев";
            }
            else if ((dayOfBirth.Month == 8 && dayOfBirth.Day >= 24) || (dayOfBirth.Month == 9 && dayOfBirth.Day <= 22))
            {
                return "Дева";
            }
            else if ((dayOfBirth.Month == 9 && dayOfBirth.Day >= 23) || (dayOfBirth.Month == 10 && dayOfBirth.Day <= 23))
            {
                return "Весы";
            }
            else if ((dayOfBirth.Month == 10 && dayOfBirth.Day >= 24) || (dayOfBirth.Month == 11 && dayOfBirth.Day <= 22))
            {
                return "Скорпион";
            }
            else if ((dayOfBirth.Month == 11 && dayOfBirth.Day >= 23) || (dayOfBirth.Month == 12 && dayOfBirth.Day <= 21))
            {
                return "Стрелец";
            }
            else if ((dayOfBirth.Month == 12 && dayOfBirth.Day >= 22) || (dayOfBirth.Month == 1 && dayOfBirth.Day <= 20))
            {
                return "Козерог";
            }
            return null;
        }
        public static void SortDate(ref List<Person> person)
        {
            for (int i = 0; i < person.Count; i++)
            {
                for (int j = 0; j < person.Count - 1; j++)
                {
                    if (person[i].DayOfBirth < person[j].DayOfBirth)
                    {
                        Person wait = person[i];
                        person[i] = person[j];
                        person[j] = wait;

                    }
                }
            }
        }
        public static void FindZodiak(List<Person> person, string zodiak)
        {
            bool check = false;
            for (int i = 0; i < person.Count; i++)
            {
                if (person[i].Zodiak == zodiak)
                {
                    Console.WriteLine(person[i]);
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine("Не найдено");
            }
        }
        public static void Inicialize(ref List<Person> people, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите Имя:");
                string firstname = Console.ReadLine();
                Console.WriteLine("Введите Фамилию:");
                string lastname = Console.ReadLine();
                Console.WriteLine("Введите Дату рождения:");
                DateTime dayofbirth = default;
                bool check = DateTime.TryParse(Console.ReadLine(), out dayofbirth);
                if (!check || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
                {
                    GetError();
                    continue;
                }
                people.Add(new Person(firstname, lastname, dayofbirth));
                Console.WriteLine($"Знак зодиака: {people[i].Zodiak}");
            }
        }
        static private void GetError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введены некорректные данные. Данные не сохранены.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
