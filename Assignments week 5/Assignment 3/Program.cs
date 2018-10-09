using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read course
            Console.Write("Enter course name: ");
            string course = Console.ReadLine();

            //Read amount of students
            Console.Write("Enter number of students: ");
            int count = int.Parse(Console.ReadLine());

            //Create new arrays. 1 for students, 1 for grades
            string[] students = new string[count];
            double[] grades = new double[count];

            //Read students
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter name of student {0}: ", i + 1);
                students[i] = Console.ReadLine();
            }

            //Read grades per student 
            for (int i = 0; i < count; i++)
            {
                string student = students[i];

                Console.Write("Enter grade of {0}: ", student);
                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;
            }

            //Calc & display average of grades
            double average = grades.Average();
            Console.WriteLine("Average grade: {0:0.00}", average);

            //Calc which student has highest grade
            string studentMax = "";
            double gradeMax = 0;
            for (int i = 0; i < count; i++)
            {
                if (grades[i] >= gradeMax)
                {
                    studentMax = students[i];
                    gradeMax = grades[i];
                }
            }

            //Display student & his/her grade
            Console.WriteLine("Student {0} has maximum grade {1:0.00}", studentMax, gradeMax);

            //Display students  + course + their grade
            for (int i = 0; i < count; i++)
            {
                string name = students[i];
                double grade = grades[i];
                Console.WriteLine("Grade for student {0} (course {1}) is: {2:0.0}",
                    name, course, grade);
            }

        }
    }
}
