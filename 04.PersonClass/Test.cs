namespace _04.PersonClass
{
    using System;

    class Test
    {
        static void Main()
        {
            var personOne = new Person("Pesho");
            var personTwo = new Person("Bai Ivan", 53);

            Console.WriteLine(personOne);
            Console.WriteLine(personTwo);
        }
    }
}
