using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int sumOfGrades = 0;
            int sumOfSubjectGrades = 0;

            Console.WriteLine("Please Enter Number Of Student:");
            int numberOfStudent = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Number Of Subjects:");
            int numberOfSubjects = int.Parse(Console.ReadLine());

            int[,] studentsGrades = new int[numberOfStudent, numberOfSubjects];

            // Take Grades of Students From User
            for (int i = 0; i < studentsGrades.GetLength(0); i++)
            {
                Console.WriteLine($"Please Enter The Grades Of Student Number {i + 1}");
                for (int j = 0; j < studentsGrades.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter Grade For Subject Number {j + 1}");
                    studentsGrades[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("_______________________________________________");
            }

            // Display Student Grades
            for (int i = 0; i < studentsGrades.GetLength(0); i++)
            {
                Console.WriteLine($"The Grades Of Student Number {i + 1}");
                for (int j = 0; j < studentsGrades.GetLength(1); j++)
                {
                    Console.WriteLine($"Grade For Subject Number {j + 1} : {studentsGrades[i, j]}");
                    sumOfGrades += studentsGrades[i, j];
                }
                Console.WriteLine($"Sum Of Grades Of Student = {sumOfGrades}");
                sumOfGrades = 0;
                Console.WriteLine("_______________________________________________");
            }

            for (int i = 0; i < studentsGrades.GetLength(1); i++)
            {
                for (int j = 0; j < studentsGrades.GetLength(0); j++)
                {
                    sumOfSubjectGrades += studentsGrades[j, i];
                }
                Console.WriteLine($"avarage of Subject number {i+1} Grades = {sumOfSubjectGrades / numberOfStudent}");
                sumOfSubjectGrades = 0;

            }
        }
    }
}
