using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John", 20, "A");
            student1.DisplayInfo();

            Student student2 = new Student("Alice", 19, "B");
            student2.DisplayInfo();
            Student student3 = new Student("Bob", 21, "C") ;
            student3.DisplayInfo();
            Console.ReadLine();
        }
    }
}
