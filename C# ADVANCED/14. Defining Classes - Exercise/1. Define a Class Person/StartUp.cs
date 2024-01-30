namespace DefiningClasses
{
    // This is the entry point of your program
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Creating an instance of Person using object initializer
            Person person1 = new Person { Name = "Peter", Age = 20 };

            // Creating an instance of Person and then setting properties individually
            Person person2 = new Person();
            person2.Name = "George";
            person2.Age = 18;

            // Another instance of Person with properties set individually
            Person person3 = new Person();
            person3.Name = "Jose";
            person3.Age = 43;
        }
    }
}
