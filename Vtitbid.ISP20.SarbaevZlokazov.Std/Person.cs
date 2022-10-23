using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.SarbaevZlokazov.Std
{
    public class Person
    {
        public string Lastname { get; set; }
        public int  FirstMark { get; set; }
        public int SecondMark { get; set; }
        public int ThirdMark { get; set; }
        public Person(string lastname, int firstmark,int secondmark,int thirdmark)
        {
            Lastname = lastname;
            FirstMark = firstmark;
            SecondMark = secondmark;
            ThirdMark = thirdmark;

        }
        public override string ToString()
        {
            return $"{Lastname}: {FirstMark},{SecondMark},{ThirdMark}";
        }
        public static List<Person> SplitData(string[] people)
        {
            string[] Lastname = new string[people.Length];
            int[] FirstMark = new int[people.Length];
            int[] SecondMark = new int[people.Length];
            int[] ThirdMark = new int[people.Length];
            List<Person> person = new List<Person>();
            for (int i = 0; i < people.Length; i++)
            {
                string[] LastnameAndMarks = people[i].Split(' ');
                Lastname[i] = LastnameAndMarks[0];
                FirstMark[i] = Int32.Parse(LastnameAndMarks[1]);
                SecondMark[i] = Int32.Parse(LastnameAndMarks[2]);
                ThirdMark[i] = Int32.Parse(LastnameAndMarks[3]);
                person.Add(new Person(Lastname[i], FirstMark[i], SecondMark[i], ThirdMark[i]));
            }
            return person;
        }
    }
}
