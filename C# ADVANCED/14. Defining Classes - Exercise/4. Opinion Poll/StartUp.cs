namespace P04_OpinionPoll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            //using a List<Person> to store instances of the Person class,
            //which is a good choice for holding a collection of objects.
            List<Person> people = new List<Person>();

            //You are parsing the input correctly by reading the number of people(n) 
            int n = int.Parse(Console.ReadLine());

            //then using a loop to read the information for each person.
            while (n-- > 0)
            {
                string[] personData = Console.ReadLine().Split();
                string name = personData[0];
                int age = int.Parse(personData[1]);

                people.Add(new Person(name, age));
            }

            //The LINQ query is concise and effectively filters and orders the people based on the given conditions.
            foreach (Person item in people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name))
            {
                Console.WriteLine(item);
            }
        }
    }
}
