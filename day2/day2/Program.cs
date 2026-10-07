using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = System.Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter your grade:");
            string grade = Console.ReadLine();

            Console.WriteLine("Enter your average:");
            string average = Console.ReadLine();
            double average2 = System.Convert.ToDouble(average);

            Console.WriteLine("Enter your gender:");
            string gender = Console.ReadLine();

            Console.WriteLine("Welcome" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("grade:" + grade);
            Console.WriteLine("average:" + average2);
            Console.WriteLine("gender: " + gender);
            Console.WriteLine("Lowercase:" + name.ToLower());
            Console.WriteLine("Uppercase:" + name.ToUpper());
            Console.WriteLine(name[0]);
            double newaverage = average2 + 5;
            Console.WriteLine("New average:" + newaverage);

            if (newaverage >= 50)
            {
                Console.WriteLine("Result: Passed");
            }
            else
            {
                Console.WriteLine("Result: Failed");
            }
            if (age >= 18)
            {
                Console.WriteLine("Adult: True");

            }
            else
            {
                Console.WriteLine("Adult: False");
            }
        }
    }
}
