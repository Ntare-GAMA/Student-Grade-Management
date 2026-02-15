using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace GradeManagementCore
{
    public class StudentGradeManager
    {
        private Dictionary<string, int> studentGrades;
        private readonly string filePath;

        public StudentGradeManager(string dataFilePath = "students.json")
        {
            filePath = dataFilePath;
            studentGrades = new Dictionary<string, int>();
            LoadFromFile();
        }

        public void AddStudent(string name, int grade)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Student name cannot be empty.");
            }

            if (grade < 0 || grade > 100)
            {
                throw new ArgumentException("Grade must be between 0 and 100.");
            }

            if (studentGrades.ContainsKey(name))
            {
                throw new InvalidOperationException($"Student '{name}' already exists. Use update instead.");
            }

            studentGrades.Add(name, grade);
            SaveToFile();
        }

        public void UpdateStudentGrade(string name, int grade)
        {
            if (!studentGrades.ContainsKey(name))
            {
                throw new KeyNotFoundException($"Student '{name}' does not exist.");
            }

            if (grade < 0 || grade > 100)
            {
                throw new ArgumentException("Grade must be between 0 and 100.");
            }

            studentGrades[name] = grade;
            SaveToFile();
        }

        public List<StudentRecord> GetAllStudents()
        {
            List<StudentRecord> students = new List<StudentRecord>();
            
            foreach (var kvp in studentGrades)
            {
                students.Add(new StudentRecord(kvp.Key, kvp.Value));
            }

            return students;
        }

        public int SearchStudent(string name)
        {
            if (!studentGrades.ContainsKey(name))
            {
                throw new KeyNotFoundException($"Student '{name}' not found in the system.");
            }

            return studentGrades[name];
        }

        public List<StudentRecord> SearchStudentsByPartialName(string searchTerm)
        {
            List<StudentRecord> results = new List<StudentRecord>();
            
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return GetAllStudents();
            }

            string lowerSearch = searchTerm.ToLower();
            foreach (var kvp in studentGrades)
            {
                if (kvp.Key.ToLower().Contains(lowerSearch))
                {
                    results.Add(new StudentRecord(kvp.Key, kvp.Value));
                }
            }

            return results;
        }

        public bool StudentExists(string name)
        {
            return studentGrades.ContainsKey(name);
        }

        public double CalculateAverageGrade()
        {
            if (studentGrades.Count == 0)
            {
                throw new InvalidOperationException("No students in the system to calculate average.");
            }

            return studentGrades.Values.Average();
        }

        public int GetHighestGrade()
        {
            if (studentGrades.Count == 0)
            {
                throw new InvalidOperationException("No students in the system.");
            }

            return studentGrades.Values.Max();
        }

        public int GetLowestGrade()
        {
            if (studentGrades.Count == 0)
            {
                throw new InvalidOperationException("No students in the system.");
            }

            return studentGrades.Values.Min();
        }

        public List<string> GetStudentsWithHighestGrade()
        {
            if (studentGrades.Count == 0)
            {
                return new List<string>();
            }

            int maxGrade = GetHighestGrade();
            return studentGrades.Where(kvp => kvp.Value == maxGrade)
                               .Select(kvp => kvp.Key)
                               .ToList();
        }

        public List<string> GetStudentsWithLowestGrade()
        {
            if (studentGrades.Count == 0)
            {
                return new List<string>();
            }

            int minGrade = GetLowestGrade();
            return studentGrades.Where(kvp => kvp.Value == minGrade)
                               .Select(kvp => kvp.Key)
                               .ToList();
        }

        public int GetStudentCount()
        {
            return studentGrades.Count;
        }

        public void RemoveStudent(string name)
        {
            if (!studentGrades.ContainsKey(name))
            {
                throw new KeyNotFoundException($"Student '{name}' not found.");
            }

            studentGrades.Remove(name);
            SaveToFile();
        }

        public void ClearAllStudents()
        {
            studentGrades.Clear();
            SaveToFile();
        }

        private void SaveToFile()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(studentGrades, new JsonSerializerOptions 
                { 
                    WriteIndented = true 
                });
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Warning: Could not save data to file. {ex.Message}");
            }
        }

        private void LoadFromFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);
                    var loadedData = JsonSerializer.Deserialize<Dictionary<string, int>>(jsonString);
                    if (loadedData != null)
                    {
                        studentGrades = loadedData;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Warning: Could not load data from file. Starting fresh. {ex.Message}");
                studentGrades = new Dictionary<string, int>();
            }
        }
    }
}
