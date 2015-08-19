namespace _01.StudentClass
{
    using System;

    public class Student : ICloneable, IComparable
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private uint ssn;
        private string address;
        private string phoneNumber;
        private string email;
        private int course;
        private Specialties specialities;
        private University university;
        private Faculty faculty;

        public Student (string firstName, string middleName, string lastName, uint ssn, string address, string phoneNumber, string email,
            int course, Specialties specialities, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Course = course;
            this.Specialties = specialities;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName
        {
            get { return this.firstName; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.lastName = value;
            }
        }

        public uint SSN
        {
            get { return this.ssn; }

            private set 
            {
                if (value > 8 && value < 8)
                {
                    throw new ArgumentOutOfRangeException("SSN number must be exactly 8 digits!");
                }
                this.ssn = value;
            }
        }

        public string Address
        {
            get { return this.address; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.address = value;
            }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.phoneNumber = value;
            }
        }

        public string Email
        {
            get { return this.email; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.email = value;
            }
        }

        public int Course
        {
            get { return this.course; }

            private set
            {
                if (value <= 0 || value > 5 )
                {
                    throw new ArgumentOutOfRangeException("Course must be between 1 and 5");
                }
                this.course = value;
            }
        }

        public Specialties Specialties
        {
            get { return this.specialities; }

            private set
            {
                this.specialities = value;
            }
        }

        public University University
        {
            get { return this.university; }

            private set
            {
                this.university = value;
            }
        }

        public Faculty Faculty
        {
            get { return this.faculty; }

            private set
            {
                this.faculty = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (this.FirstName == (obj as Student).FirstName &&
                this.MiddleName == (obj as Student).MiddleName &&
                this.LastName == (obj as Student).LastName &&
                this.SSN == (obj as Student).SSN &&
                this.Address == (obj as Student).Address &&
                this.PhoneNumber == (obj as Student).PhoneNumber &&
                this.Email == (obj as Student).Email &&
                this.Course == (obj as Student).Course &&
                this.Specialties == (obj as Student).Specialties &&
                this.University == (obj as Student).University &&
                this.Faculty == (obj as Student).Faculty)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string studentInfo = 
                string.Format
                ("Full name of student: {0} {1} {2}\nSSN number: {3}\nAddress: {4}\nPhone Number: {5}\nEmail: {6}\nCourse: {7}\nSpecialties: {8}\nUniversity: {9}\nFaculty: {10}.",
             this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.PhoneNumber, this.Email,
             this.Course, this.Specialties, this.University, this.Faculty);
            return studentInfo;
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public static bool operator ==(Student student1,
                                  Student student2)
        {
            return Student.Equals(student1, student2);
        }
        public static bool operator !=(Student student1,
                           Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public object Clone()
        {
            Student temp = new Student(this.FirstName, this.MiddleName,
                this.LastName, this.SSN, this.Address, this.PhoneNumber, this.Email, this.Course, this.specialities, this.University, this.Faculty);
            

            return temp;
        }

        public int CompareTo(object obj)
        {


            if (this.FirstName.CompareTo((obj as Student).FirstName) != 0)
            {
                return this.FirstName.CompareTo((obj as Student).FirstName);
            }

            if (this.MiddleName.CompareTo((obj as Student).MiddleName) != 0)
            {
                return this.MiddleName.CompareTo((obj as Student).MiddleName);
            }
            if (this.LastName.CompareTo((obj as Student).LastName) != 0)
            {
                return this.LastName.CompareTo((obj as Student).LastName);
            }
            if (this.SSN.CompareTo((obj as Student).SSN) != 0)
            {
                return this.SSN.CompareTo((obj as Student).SSN);
            }

            return 0;
        }

    }
}
