namespace _01.StudentClass
{
    using System;

    public class Test
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student("Boncho", "Bonchov", "Bonchoto", 13202733, "Ulica nqkva si 33", "+359 8824324234",
                "Boncho.BBonchoto@gmail.com", 4, Specialties.Programming,
                University.SofiaUniversity, Faculty.Informatics);

            Student secondStudent = new Student("Spartak", "Spartakiev", "Spartakov", 12224956, "Ulica nqkva si 34", "+359 8854545454",
                "Boncho.BBonchoto@gmail.com", 4, Specialties.Art,
                University.NBU, Faculty.Arts);

            Student thirdStudent = new Student("Boncho", "Bonchov", "Bonchoto", 13202733, "Ulica nqkva si 33", "+359 8824324234",
                "Boncho.BBonchoto@gmail.com", 4, Specialties.Programming,
                University.SofiaUniversity, Faculty.Informatics);

            Console.WriteLine(firstStudent + "\n");
            Console.WriteLine(secondStudent + "\n");
            Console.WriteLine("Students are equals: " + firstStudent.Equals(secondStudent) + "\n");
            Console.WriteLine("Students are equals: " + firstStudent.Equals(thirdStudent) + "\n");
            Console.WriteLine("Hash code student one: {0}\nHash code student two: {1}\n.",
                firstStudent.GetHashCode(), secondStudent.GetHashCode());
            Console.WriteLine("Equals operator \"==\": {0}\n", firstStudent == thirdStudent);
            Console.WriteLine("Equals operator \"!=\": {0}\n", firstStudent != thirdStudent);


        }
    }
}
