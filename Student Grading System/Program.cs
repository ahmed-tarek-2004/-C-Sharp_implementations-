using Student_Grading_System;
using System;
namespace Student_System
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                Console.WriteLine("Press Any Key To Continue Or ESC To End Process :");
                ConsoleKeyInfo keyInfo=Console.ReadKey(true);
                ConsoleKey key = keyInfo.Key;
                if (key==ConsoleKey.Escape)
                {
                    break;
                }
                Console.Write("\nEnter Student Name : ");
                string sName = Console.ReadLine();
                //if (sName.Contains("Done", StringComparison.OrdinalIgnoreCase))
                //{
                //    break;
                //}
                List<int> grades = new(5);
                int subject;
                Console.WriteLine("Enter Grades : ");
                for (int i = 0; i < 5; i++)
                {
                    int.TryParse(Console.ReadLine(), out subject);
                    grades.Add(subject);
                }
                Student student = new Student();
                student.name = sName;
                student.grades = grades;
                //display(student);
                students.Add(student);
            }
            GraingSystem grading = new GraingSystem();
            grading.displayGradingInfo(students, GetAvg, IsPAssed, display);
        }
        private static void display(Student s, double avg, bool isPassed)
        {
            Console.WriteLine("\t----------------------------------------------------------------------------------------");
            Console.WriteLine($"Student Name  : {s.name ?? "Unknown"} \n His Grades is :");
            foreach (var grade in s.grades)
            {
                Console.WriteLine($"\t {grade}");
            }
            Console.WriteLine($"Avarage Grades is : {avg}% , Statue Is {(isPassed == true ? "Passed" : "Failed")}");
            Console.WriteLine("\t----------------------------------------------------------------------------------------");
        }
        private static double GetAvg(List<int> grades)
        {
            return grades.Sum() / grades.Count;
        }
        private static bool IsPAssed(double Avg)
        {
            return Avg > 29;
        }
    }
}