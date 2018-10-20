using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentApp
{
    
    class Student
    {
        //members
        private string firstName;
        private string secondName;
        const int numberOfGrades = 7;
        private int[] studentGrade = new int[numberOfGrades];

        //default constructor
       public Student()
        {
            this.firstName = null;
            this.secondName = null;
            this.studentGrade = null;
        }
        //Main constructor
       public Student(string firstName, string secondName, int[] studentGrade)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.studentGrade = studentGrade;
        }

        //getters
        public string getFirstName()
        {
            return this.firstName;
        }
        public string getSecondName()
        {
            return this.secondName;
        }
        
        //method to display grades
        public void displayGrades()
        {
            Console.Write("Grades: ");
            foreach(var grade in studentGrade)
                Console.Write(grade);
        }

        //operator overloading
        private string getStudent="";
        public override string ToString()
        {
            Console.WriteLine("First name: " + getFirstName());
            Console.WriteLine("Second name: " + getSecondName());
            displayGrades();
            return this.getStudent.ToString();
        }
    }
}
