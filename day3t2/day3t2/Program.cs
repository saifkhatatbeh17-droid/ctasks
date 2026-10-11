using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Ahmad", "Sara", "Omar", "Lina", "Yazan" };
            int[] grades = { 85, 92, 68, 75, 90 };
            int choice;

            do
            {
                Console.WriteLine("\n===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                    choice = 0;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Students:");
                        for (int d = 0; d < students.Length; d++)
                        {
                            Console.WriteLine(students[d]);
                        }

                        Console.WriteLine("Grades:");
                        foreach (int grade in grades)
                        {
                            Console.WriteLine(grade);
                        }
                        break;

                    case 2:
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        int i = 0;
                        bool found = false;

                        while (i < students.Length)
                        {
                            if (string.Equals(students[i], name,
                                StringComparison.OrdinalIgnoreCase))
                            {
                                found = true;
                                break;
                            }
                            i++;
                        }

                        if (found)
                            Console.WriteLine("Student Found!");
                        else
                            Console.WriteLine("Student Not Found.");
                        break;

                    case 3:
                        Console.Write("Enter student's grade: ");
                        int gradeInput;

                        if (!int.TryParse(Console.ReadLine(), out gradeInput)
                            || gradeInput < 0 || gradeInput > 100)
                        {
                            Console.WriteLine("Please enter a grade from 0 to 100.");
                        }
                        else if (gradeInput >= 90)
                            Console.WriteLine("Excellent");
                        else if (gradeInput >= 80)
                            Console.WriteLine("Very Good");
                        else if (gradeInput >= 70)
                            Console.WriteLine("Good");
                        else if (gradeInput >= 60)
                            Console.WriteLine("Pass");
                        else
                            Console.WriteLine("Fail");
                        break;

                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please choose 1-4.");
                        break;
                }

            } while (choice != 4);


        }
    }
}
