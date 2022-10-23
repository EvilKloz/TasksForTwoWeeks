using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.SarbaevZlokazov.Std
{
    public static class Sorting
    {
        public static void AlphabetSort(ref List<Person>persons)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = 0; j < persons.Count - 1; j++)
                {
                    if (Alphabet(persons[i].Lastname, persons[j].Lastname))
                    {
                        Person empty = persons[i];
                        persons[i] = persons[j];
                        persons[j] = empty;
                    }
                }

            }
        }
        private static bool Alphabet(string a, string b)
        {
            string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string aUp = a.ToUpper();
            string bUp = b.ToUpper();

            int counter = (a.Length < b.Length) ? a.Length : b.Length;

            for (int i = 0; i < counter; i++)
            {
                if (Alphabet.IndexOf(aUp[i]) < Alphabet.IndexOf(bUp[i]))
                {
                    return true;
                }
                else if (Alphabet.IndexOf(aUp[i]) == Alphabet.IndexOf(bUp[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public static void MarkSort(ref List<Person> persons)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = 0; j < persons.Count - 1; j++)
                {
                    double MiddleValueI = (persons[i].FirstMark + persons[i].SecondMark + persons[i].ThirdMark) / 3;
                    double MiddleValueJ = (persons[j].FirstMark + persons[j].SecondMark + persons[j].ThirdMark) / 3;

                    if (MiddleValueI > MiddleValueJ)
                    {
                        Person empty = persons[i];
                        persons[i] = persons[j];
                        persons[j] = empty;
                    }
                }

            }
        }
    }

}
