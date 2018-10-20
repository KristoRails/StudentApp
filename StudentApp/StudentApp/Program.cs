using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            var createdDate = new List<DateTime>();
            
            //creating new students
            for(int i=0;i<2;i++)
            {
                string firstName=null;
                string secondName = null;
                int numberGrades = 7;
                int[] grades = new int[numberGrades]; //each student has 7 grades

                Console.WriteLine("Enter first name:");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter second name:");
                secondName = Console.ReadLine();

                //input grades
                Console.WriteLine("Enter grades:");
                for (int j = 0; j < numberGrades; j++)
                {
                    int grade = int.Parse(Console.ReadLine());
                    if (grade < 11 && grade > -1)
                        grades[j] = grade;
                    else
                        throw new ArgumentException("Grade is invalid");
                }

                //creating a new student
                students.Add(new Student(firstName, secondName, grades));

                createdDate.Add(DateTime.Now);
                Console.WriteLine("Student created!");
                Console.WriteLine();
            }
            Console.Clear();

            //display current students, grades and time of creation
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
                Console.WriteLine("Created on " + createdDate[i]);
                Console.WriteLine();
            }

            //console doesn't close
            Console.ReadLine();
        }
    }
}
