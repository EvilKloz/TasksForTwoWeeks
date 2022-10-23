using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.SarbaevZlokazov.Project
{
    static class PersonAction
    {
        public static void SortPerson(ref Person[] persons)
        {
            string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = 0; j < persons.Length - 1; j++)
                {

                    if (Alphabet.IndexOf(persons[j].Lastname[0])> Alphabet.IndexOf(persons[j].Lastname[0]))
                    {
                        Swap(ref persons[j], ref persons[j+1]);
                    }


                }
                    
            }

        }
        static private void Swap(ref Person first, ref Person second)
        {
            Person temp;
            temp = first;
            first = second;
            second = temp;
        }
        public static void  GetInfoDayOfBirth(Person[] person, int month)
        {
            bool check = false;
            int[] mas = new int[person.Length];
            for ( int i = 0; i < person.Length; i++)
            {
                if (person[i].DayOfBirth.Month == month)
                {
                    Console.WriteLine(person[i].ToString() + "\n");
                    check = true;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Человека с такой датой рождения нет в списке");
            }
            
        }
        static public void GetError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введены некорректные данные. Данные не сохранены.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        }
    
}
