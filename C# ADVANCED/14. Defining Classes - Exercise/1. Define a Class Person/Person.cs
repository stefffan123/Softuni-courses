// This is the definition of the Person class
namespace DefiningClasses
{
    class Person
    {
        // Private fields to store name and age
        private string name;
        private int age;

        // Properties to access and modify the private fields
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
