using System;

namespace Assignment_2_
{
    internal class Program
    {
        class Student
        {
            private int studentId; //field
            private string studentFName;
            private string studentLName;
            private char studentGrade;

            public int StudentId //property
            {
                get { return studentId; }
                set { studentId = value; }
            }
            public string StudentFName 
            {
                get { return studentFName; }
                set { studentFName = value; }
            }
            public string StudentLName 
            {
                get { return studentLName; }
                set { studentLName = value; }
            }
            public char StudentGrade 
            {
                get { return studentGrade; }
                set { studentGrade = value; }
            }

        }
        static void Main(string[] args)
        {
            Student studentInfo = new Student(); //instantiate

            Console.WriteLine("Enter student's ID: ");
            studentInfo.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student's First Name: ");
            studentInfo.StudentFName = Console.ReadLine();
            Console.WriteLine("Enter student's Last Name: ");
            studentInfo.StudentLName = Console.ReadLine();
            Console.WriteLine("Enter student's Grade: ");
            studentInfo.StudentGrade = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Student's ID: {studentInfo.StudentId}");
            Console.WriteLine($"Student's First Name: {studentInfo.StudentFName}");
            Console.WriteLine($"Student's Last Name: {studentInfo.StudentLName}");
            Console.WriteLine($"Student's Grade: {studentInfo.StudentGrade}");
        }

        
    }
}
