namespace GradeManagementCore
{
    public struct StudentRecord
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public GradeCategory Category { get; set; }

        public StudentRecord(string name, int grade)
        {
            Name = name;
            Grade = grade;
            Category = GetGradeCategory(grade);
        }

        private static GradeCategory GetGradeCategory(int grade)
        {
            if (grade >= 90) return GradeCategory.A;
            if (grade >= 80) return GradeCategory.B;
            if (grade >= 70) return GradeCategory.C;
            if (grade >= 60) return GradeCategory.D;
            return GradeCategory.F;
        }

        public override string ToString()
        {
            return $"{Name}: {Grade} ({Category})";
        }
    }
}
