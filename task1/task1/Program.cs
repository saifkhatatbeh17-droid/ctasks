using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = "saif khatatbeh";
            int studentAge = 28;
            int studentGrade = 20;
            double studentAverage = 18.5;
            char studentGender = 'M';
            bool studentIsGraduated = true;
            Console.WriteLine("Student Name: {0}", studentName);
            Console.WriteLine("Student Age: {0}", studentAge);
            Console.WriteLine("Student Grade: {0}", studentGrade);
            Console.WriteLine("Student Average: {0}", studentAverage);
            Console.WriteLine("Student Gender: {0}", studentGender);
            Console.WriteLine("Student Is Graduated: {0}", studentIsGraduated);
            string[] students = { "saif", "alaa", "wessam" };
            Console.WriteLine("Students: 1 {0}", students[0]);
            Console.WriteLine("Students: 2 {0}", students[1]);
            Console.WriteLine("Students: 3 {0}", students[2]);
            Console.WriteLine("nuber of sudents: " + students.Length);

            students[2] = "ahmad";
            Console.WriteLine("Students: 1 {0}", students[0]);
            Console.WriteLine("Students: 2 {0}", students[1]);
            Console.WriteLine("Students: 3 {0}", students[2]);
        }
    }
}
