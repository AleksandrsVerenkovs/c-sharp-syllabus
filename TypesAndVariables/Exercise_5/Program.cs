using System;
using System.Collections.Generic;
namespace Exercise_5
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public string Teach { get; set; }
            public int Nr { get; set; }
            public Person(int nr,string name, string teach)
            {
                Nr = nr;
                Name = name;
                Teach = teach;
            }

        }
        static void Main(string[] args)
        {
            String BorderLine = $"+{new String('-', 41)}+";
            List<Person> TeacherList = new List<Person>();
            TeacherList.Add(new Person(1,"Q.Tarantino", "Dialog"));
            TeacherList.Add(new Person(2,"M.Bay", "Explosions"));
            TeacherList.Add(new Person(3,"B.Pitt", "Sex Symbol"));
            TeacherList.Add(new Person(4,"S.Spielberg", "OK_filmography"));
            TeacherList.Add(new Person(5,"N.Fake", "4chan"));

            Console.WriteLine(BorderLine);
            foreach(var teacher in TeacherList)
            {
                int nameLength = 19 - teacher.Name.Length;
                int teachLength = 15 - teacher.Teach.Length;
                Console.WriteLine($"| {teacher.Nr} |{new String(' ', nameLength)}{teacher.Name} |{new String(' ', teachLength)}{teacher.Teach} |");
            }
            Console.WriteLine(BorderLine);

            
        }
    }
}
