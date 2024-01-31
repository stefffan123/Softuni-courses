using System.Xml.Linq;

namespace P04_OpinionPoll
{

    //The Person class looks well-structured.
    //It has a default constructor, a constructor with an age parameter, and a parameterized constructor for initializing both name and age.
    public class Person
    {

        //----------------- Fields -----------------
        private string name;
        private int age;

        //-------------- Constructors --------------
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) : this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // Properties:  The properties Name and Age use a combination of private fields and public accessors.
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

        // Methods: The ToString method is overridden to provide a custom string representation for a Person object.
        public override string ToString()
        {
            return $"{this.Name} - {this.Age}";
        }
    }
}
