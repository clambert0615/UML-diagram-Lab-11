using System;
using System.Collections.Generic;

namespace Lab_12_Class_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            Student amy = new Student("Amy Smith", "111 Main St, Macomb, MI 48044", "Accounting", 2022, 2800.00);
            Student john = new Student("John White", "222 Black St, Detroit, MI 48247", "Computer Science", 2020, 1850.60);
            Student jill = new Student("Jill Jones", "58 White St, Roseville, MI 48060", "Economics", 2023, 3950.50);
            Staff donald = new Staff("Donald Grass", "32 Poplar St, New Baltimore, MI 48047", "Dakota High School", 62500.25);
            Staff sara = new Staff("Sara Walker", "256 Jokester St, Chesterfield, MI 48062", "Seneca Middle School", 52680.75);

            persons.Add(amy);
            persons.Add(john);
            persons.Add(jill);
            persons.Add(donald);
            persons.Add(sara);

            foreach (Person p in persons)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine();
            AddPerson(persons, new Student("Pete Brown", "22 Rock St, Macomb, MI 48044", "Biology", 2022, 2659.60));
            AddPerson(persons, new Staff("John Doe", "1135 Valley St, Memphis, MI 48040", "Memphis High School", 59256.95));
            
            foreach (Person p in persons)
            {
                Console.WriteLine(p);
            }
        }

        public static void AddPerson(List<Person> persons, Person person)
        {

            persons.Add(person);
        }
            
    }
}
