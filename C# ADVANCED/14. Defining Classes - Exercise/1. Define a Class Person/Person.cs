namespace DefiningClasses
{
    class Person
    {
        //------Private Fields ----------
        private string name;
        private int age;


        //------ Properties -------------
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
