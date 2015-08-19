namespace _04.PersonClass
{
    using System;

    class Person
    {
        private string name;
        private int? age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public int? Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\n Age: {1}", this.Name, this.Age == null ? "Age is unknown" : this.Age.ToString() );
        }
    }
}
