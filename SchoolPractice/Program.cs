using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student jed = new Student("Jed", 110, 1, 4.0);
            Teacher moe = new Teacher("Moe", "A", "C#", 1);

            Console.WriteLine($"The student class works! {jed.Name} is a student!");
            Console.WriteLine($"The teacher class works! {moe.FirstName} is the teacher!");
            Console.WriteLine($"The course class works! {moe.FirstName} is teaching {jed.Name} in the course!");
        }
    }
}
