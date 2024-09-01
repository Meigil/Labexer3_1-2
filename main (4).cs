using System;

class StudentGradeApplication {
    static void Main() {
        Console.WriteLine("===== Student Grade Application =====");
        Console.WriteLine("");
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        Console.Write("Enter course name: ");
        string course = Console.ReadLine();
        
        
        Console.Write("English     : ");
        double eng = Convert.ToDouble(Console.ReadLine());
        Console.Write("Math        : ");
        double math = Convert.ToDouble(Console.ReadLine());
        Console.Write("Science     : ");
        double scie = Convert.ToDouble(Console.ReadLine());
        Console.Write("Filipino    : ");
        double fil = Convert.ToDouble(Console.ReadLine());
        Console.Write("History     : ");
        double his = Convert.ToDouble(Console.ReadLine());
        
        
        double ave = (eng + math + scie + fil + his) / 5;

        
        char letterGrade;
        if (ave >= 90) {
            letterGrade = 'A';
        } else if (ave >= 80) {
            letterGrade = 'B';
        } else if (ave >= 70) {
            letterGrade = 'C';
        } else if (ave >= 60) {
            letterGrade = 'D';
        } else {
            letterGrade = 'F';
        }

        Console.WriteLine("");
        Console.WriteLine("===== Grade Summary =====");
        Console.WriteLine("");

        
        string status = ave >= 75 ? "Passed" : "Failed";
        
        Console.WriteLine("Student name    : " + name);
        Console.WriteLine("Course          : " + course);
        Console.WriteLine("Average         : " + ave);
        Console.WriteLine("Letter Grade    : " + letterGrade);
        Console.WriteLine("Status          : " + status);
    }
}

