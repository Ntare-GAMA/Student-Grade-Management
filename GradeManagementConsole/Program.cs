#nullable disable
using System;
using GradeManagementCore;

namespace GradeManagementConsole
{
    class Program
    {
        static StudentGradeManager manager = new StudentGradeManager();

        static void Main(string[] args)
        {
            Console.WriteLine("═══════════════════════════════════════════════════");
            Console.WriteLine("   STUDENT GRADE MANAGEMENT SYSTEM");
            Console.WriteLine("═══════════════════════════════════════════════════");
            Console.WriteLine();

            bool running = true;

            while (running)
            {
                DisplayMenu();
                string choice = Console.ReadLine() ?? "";

                try
                {
                    switch (choice)
                    {
                        case "1":
                            AddStudent();
                            break;
                        case "2":
                            DisplayAllStudents();
                            break;
                        case "3":
                            SearchStudent();
                            break;
                        case "4":
                            CalculateAverage();
                            break;
                        case "5":
                            FindHighestAndLowest();
                            break;
                        case "6":
                            UpdateStudentGrade();
                            break;
                        case "7":
                            RemoveStudent();
                            break;
                        case "8":
                            LoadSampleData();
                            break;
                        case "9":
                            running = false;
                            Console.WriteLine("\nThank you for using Student Grade Management System!");
                            break;
                        default:
                            Console.WriteLine("\n❌ Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n❌ Error: {ex.Message}");
                }

                if (running)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n╔═══════════════════════════════════════════════════╗");
            Console.WriteLine("║                    MAIN MENU                      ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════╝");
            Console.WriteLine("  1. Add a Student");
            Console.WriteLine("  2. Display All Students");
            Console.WriteLine("  3. Search for a Student");
            Console.WriteLine("  4. Calculate Average Grade");
            Console.WriteLine("  5. Find Highest and Lowest Grades");
            Console.WriteLine("  6. Update Student Grade");
            Console.WriteLine("  7. Remove a Student");
            Console.WriteLine("  8. Load Sample Data");
            Console.WriteLine("  9. Exit");
            Console.WriteLine("───────────────────────────────────────────────────");
            Console.Write("Enter your choice (1-9): ");
        }

        static void AddStudent()
        {
            Console.WriteLine("\n┌─ ADD STUDENT ─────────────────────────────────────┐");
            
            Console.Write("Enter student name: ");
            string name = Console.ReadLine()?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Student name cannot be empty.");
            }

            Console.Write("Enter grade (0-100): ");
            string gradeInput = Console.ReadLine() ?? "";

            if (!int.TryParse(gradeInput, out int grade))
            {
                throw new ArgumentException("Invalid grade format. Please enter a number.");
            }

            manager.AddStudent(name, grade);
            
            StudentRecord record = new StudentRecord(name, grade);
            Console.WriteLine($"\n✓ Successfully added: {record}");
        }

        static void DisplayAllStudents()
        {
            Console.WriteLine("\n┌─ ALL STUDENTS ────────────────────────────────────┐");
            
            var students = manager.GetAllStudents();

            if (students.Count == 0)
            {
                Console.WriteLine("  No students in the system.");
                Console.WriteLine("└───────────────────────────────────────────────────┘");
                return;
            }

            Console.WriteLine($"  Total Students: {students.Count}");
            Console.WriteLine("  ─────────────────────────────────────────────────");

            students.Sort((a, b) => b.Grade.CompareTo(a.Grade));

            foreach (var student in students)
            {
                Console.WriteLine($"  • {student}");
            }
            
            Console.WriteLine("└───────────────────────────────────────────────────┘");
        }

        static void SearchStudent()
        {
            Console.WriteLine("\n┌─ SEARCH STUDENT ──────────────────────────────────┐");
            
            Console.Write("Enter student name: ");
            string name = Console.ReadLine()?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Student name cannot be empty.");
            }

            int grade = manager.SearchStudent(name);
            StudentRecord record = new StudentRecord(name, grade);
            
            Console.WriteLine($"\n✓ Found: {record}");
        }

        static void CalculateAverage()
        {
            Console.WriteLine("\n┌─ AVERAGE GRADE ───────────────────────────────────┐");
            
            double average = manager.CalculateAverageGrade();
            
            Console.WriteLine($"  Average Grade: {average:F2}");
            Console.WriteLine($"  Letter Grade: {new StudentRecord("", (int)Math.Round(average)).Category}");
            Console.WriteLine("└───────────────────────────────────────────────────┘");
        }

        static void FindHighestAndLowest()
        {
            Console.WriteLine("\n┌─ GRADE STATISTICS ────────────────────────────────┐");
            
            int highest = manager.GetHighestGrade();
            int lowest = manager.GetLowestGrade();
            
            var topStudents = manager.GetStudentsWithHighestGrade();
            var bottomStudents = manager.GetStudentsWithLowestGrade();

            Console.WriteLine($"  Highest Grade: {highest}");
            Console.WriteLine($"  Students: {string.Join(", ", topStudents)}");
            Console.WriteLine();
            Console.WriteLine($"  Lowest Grade: {lowest}");
            Console.WriteLine($"  Students: {string.Join(", ", bottomStudents)}");
            Console.WriteLine("└───────────────────────────────────────────────────┘");
        }

        static void UpdateStudentGrade()
        {
            Console.WriteLine("\n┌─ UPDATE STUDENT GRADE ────────────────────────────┐");
            
            Console.Write("Enter student name: ");
            string name = Console.ReadLine()?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Student name cannot be empty.");
            }

            int currentGrade = manager.SearchStudent(name);
            Console.WriteLine($"Current grade: {currentGrade}");

            Console.Write("Enter new grade (0-100): ");
            string gradeInput = Console.ReadLine() ?? "";

            if (!int.TryParse(gradeInput, out int newGrade))
            {
                throw new ArgumentException("Invalid grade format. Please enter a number.");
            }

            manager.UpdateStudentGrade(name, newGrade);
            
            StudentRecord record = new StudentRecord(name, newGrade);
            Console.WriteLine($"\n✓ Successfully updated: {record}");
        }

        static void RemoveStudent()
        {
            Console.WriteLine("\n┌─ REMOVE STUDENT ──────────────────────────────────┐");
            
            Console.Write("Enter student name: ");
            string name = Console.ReadLine()?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Student name cannot be empty.");
            }

            manager.RemoveStudent(name);
            Console.WriteLine($"\n✓ Successfully removed student: {name}");
        }

        static void LoadSampleData()
        {
            Console.WriteLine("\n┌─ LOAD SAMPLE DATA ────────────────────────────────┐");
            
            try
            {
                manager.AddStudent("Alice Johnson", 95);
                manager.AddStudent("Bob Smith", 78);
                manager.AddStudent("Carol Williams", 88);
                manager.AddStudent("David Brown", 92);
                manager.AddStudent("Emma Davis", 65);
                manager.AddStudent("Frank Miller", 73);
                manager.AddStudent("Grace Wilson", 98);
                manager.AddStudent("Henry Taylor", 82);

                Console.WriteLine("✓ Successfully loaded 8 sample students!");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"⚠ Warning: {ex.Message}");
                Console.WriteLine("  Some sample data may already exist.");
            }
        }
    }
}
