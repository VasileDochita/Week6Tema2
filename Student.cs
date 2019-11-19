using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1. Student class
//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
//mobile phone e-mail, course, specialty, university, faculty.Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators ==and !=.

//Problem 2. ICloneable
//Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
//Problem 3. IComparable
//Implement the IComparable<Student> interface to compare students by names(as first criteria, in lexicographic order) 
//and by social security number(as second criteria, in increasing order).
//Problem 4. Person class
//Create a class Person with two fields – name and age.Age can be left unspecified(may contain null value.Override ToString()
//to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.

namespace Week6Tema2
{
    public class Student : ICloneable, IComparable
    {
        public enum University
        {
            Cuza,
            Asachi,
            Haret
        }
        public enum Faculty
        {
            Facultate1,
            Facultate2,
            Facultate3
        }

        public enum Specialty
        {
            Litere,
            Informatica,
            Biologie,
            Psihologie
        }



        public Student(string firstName, string middleName, string lastName, int SSN, string adress, string mobilePhone,
                        string email, int course, University university, Specialty specialty, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSecurityNumber = SSN;
            this.Adress = adress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Specialty = specialty;
            this.faculty = faculty;

        }
        public string FirstName { get; private set; }
        public string MiddleName { get; }
        public string LastName { get; }
        public int SocialSecurityNumber { get; }
        public string Adress { get; }
        public string MobilePhone { get; }
        public string Email { get; }
        public int Course { get; }

        private readonly string university;

        public string GetUniversity()
        {
            return University1;
        }

        public string Specialty { get; }

        private readonly string faculty;

        public string GetFaculty()
        {
            return faculty;
        }

        public string University1 => university;
        
        public override bool Equals(object another)
        {
            var anotherStudent = another as Student;

            return this.FirstName == anotherStudent.FirstName && this.MiddleName == anotherStudent.MiddleName && this.LastName == anotherStudent.LastName
                    && this.SocialSecurityNumber == anotherStudent.SocialSecurityNumber;
        }
        public string student3 { get; }
        public string student4 { get; }
        public override int GetHashCode()
        {
            var HashCode = 352033288;
            HashCode = HashCode * -1521134295 + student3.GetHashCode();
            HashCode = HashCode * -1521134295 + student4.GetHashCode();
            
                return HashCode; // ? nu prea am inteles cu GetHashCode
        }
        public override string ToString()
        {
             StringBuilder result = new StringBuilder();
            result.Append(string.Format("Student {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            result.Append(string.Format("Student's adress : {0}, Email : {1}, Mobile Phone : {2}, Course : {3}, Social Security number : {4}", this.Adress, this.Email, this.MobilePhone, this.Course, this.SocialSecurityNumber));
            result.Append(string.Format("University : {0}, Faculty : {1}, Specialty : {2}", this.University1, this.GetFaculty(), this.Specialty));
            return result.ToString();


        }

        public object Clone()
        {
            Student studentOriginal = this;
            Student newStudent = new Student(studentOriginal.FirstName, studentOriginal.MiddleName, studentOriginal.LastName,
                studentOriginal.Adress, studentOriginal.Email, studentOriginal.MobilePhone, studentOriginal.Course,
                studentOriginal.SocialSecurityNumber, studentOriginal.University1, studentOriginal.GetFaculty(), studentOriginal.Specialty);
            return newStudent;
        }

        public int CompareTo(object obj)
        {
            Student anotherStudent = obj as Student;
            int compare = this.FirstName.CompareTo(anotherStudent.FirstName);
            int compare2 = this.MiddleName.CompareTo(anotherStudent.MiddleName);
            int compare3 = this.LastName.CompareTo(anotherStudent.LastName);
            int compare4 = this.SocialSecurityNumber.CompareTo(anotherStudent.SocialSecurityNumber);
            if(compare == 0 && compare2 == 0 && compare3 == 0)
            {
                return this.SocialSecurityNumber.CompareTo(anotherStudent.SocialSecurityNumber);
                
            }
            return compare4;
        }

        public static bool operator ==(Student student1, Student student2 )
        {
            return student1.Equals(student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(student1 == student2);
        }
    }
}

