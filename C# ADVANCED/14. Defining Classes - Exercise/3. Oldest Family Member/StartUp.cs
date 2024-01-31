using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // code for a simple program that defines two classes: Person and Family.
            // The Person class represents an individual with a name and age,
            // the Family class represents a group of people.
            // The program takes user input to create instances of the Person class and adds them to the Family.
            // Finally, it prints the name and age of the oldest person in the family.

            //In the Main method, an instance of the Family class is created.
            Family family = new Family();

            //User input is taken to determine how many people will be added to the family(n).
            int n = int.Parse(Console.ReadLine());

            //A loop reads input for each person (name and age) and adds them to the family using the AddMember method.
            while (n-- > 0)
            {
                string[] personData = Console.ReadLine().Split();
                string name = personData[0];
                int age = int.Parse(personData[1]);
                family.AddMember(new Person(name, age));
            }

            //Finally, it prints the result of calling GetOldestMember on the Family instance.
            Console.WriteLine(family.GetOldestMember());
        }
    }
}
