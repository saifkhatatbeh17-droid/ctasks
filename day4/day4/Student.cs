using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Student
    {
        public string name;
        public int age;
        public string grade;
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade}");
        }
        public Student(string Studentname, int Studentage, string Studentgrade)
        {
            name = Studentname;
            age = Studentage;
            grade = Studentgrade;
        }
    }
}
