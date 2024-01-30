namespace DefiningClasses
{
    public class Person
    {
        //----------------- Fields -----------------
        private string name;
        private int age;

        //-------------- Constructors --------------
        public Person()
        {
            // Default constructor with default values
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) : this()
        {
            // Constructor with age parameter, utilizing the default constructor
            this.Age = age;
        }

        public Person(string name, int age)
        {
            // Constructor with name and age parameters
            this.Name = name;
            this.Age = age;
        }

        //--------------- Properties ---------------
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}
