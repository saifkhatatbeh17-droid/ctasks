
using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    protected string SchoolName { get; set; }

    private string _internalCode;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        SchoolName = "My School";
        _internalCode = "P001";
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Student : Person
{
    public int Grade { get; set; }
    public string StudentId { get; set; }

    public Student(string name, int age, int grade, string studentId)
        : base(name, age)
    {
        Grade = grade;
        StudentId = studentId;
    }

    public void DisplayStudentInfo()
    {
        DisplayInfo();
        Console.WriteLine("Grade: " + Grade);
        Console.WriteLine("Student ID: " + StudentId);
        Console.WriteLine("School Name: " + SchoolName);
    }
}

class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    public void DisplayTeacherInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Subject: " + Subject);
    }
}

sealed class SchoolReport
{
    public string ReportTitle { get; set; }

    public SchoolReport(string reportTitle)
    {
        ReportTitle = reportTitle;
    }

    public void DisplayReportTitle()
    {
        Console.WriteLine("Report Title: " + ReportTitle);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create two Student objects
        Student student1 = new Student("Ahmad", 16, 10, "S101");
        Student student2 = new Student("Sara", 15, 9, "S102");

        // Display student information
        Console.WriteLine("Student 1:");
        student1.DisplayInfo();
        Console.WriteLine("Grade: " + student1.Grade);
        Console.WriteLine("Student ID: " + student1.StudentId);
        Console.WriteLine();

        Console.WriteLine("Student 2:");
        student2.DisplayInfo();
        Console.WriteLine("Grade: " + student2.Grade);
        Console.WriteLine("Student ID: " + student2.StudentId);
        Console.WriteLine();

        // Create a Teacher object
        Teacher teacher1 = new Teacher("Mr. Ali", 35, "Math");

        Console.WriteLine("Teacher Information:");
        teacher1.DisplayTeacherInfo();
        Console.WriteLine();

        // Create a SchoolReport object
        SchoolReport report = new SchoolReport("Annual School Report");
        report.DisplayReportTitle();

        // ERROR: SchoolName is protected, so Main cannot access it directly.
        // Console.WriteLine(student1.SchoolName);

        // ERROR: _internalCode is private inside Person.
        // Console.WriteLine(student1._internalCode);

        // SchoolReport is sealed, so another class cannot inherit from it.
    }
}
