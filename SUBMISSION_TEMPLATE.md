# 📝 Assignment Submission Template

Use this template for your assignment submission document.

---

# Student Grade Management System - Assignment Submission

## Student Information

**Student Name**: [Your Full Name]  
**Student ID**: [Your Student ID]  
**Institution**: African Leadership University  
**Course**: [Course Name/Number]  
**Date**: February 14, 2026  
**Assignment**: Student Grade Management System

---

## 📦 GitHub Repository

**Repository URL**: `https://github.com/YOUR_USERNAME/StudentGradeManagementSystem`

**Repository Contents**:
- ✅ Complete C# source code (3 projects)
- ✅ README.md with comprehensive documentation
- ✅ Quick start guide
- ✅ Video demonstration guide
- ✅ GitHub setup instructions
- ✅ .gitignore file

---

## 🎥 Video Demonstration

**Video URL**: [Insert your video link here]

**Platform**: [YouTube / Google Drive / OneDrive / Loom / Other]

**Duration**: [X minutes]

**Password** (if applicable): [Password if video is password-protected]

### Video Contents:
- ✅ Introduction to the project
- ✅ Console application demonstration
- ✅ Windows Forms GUI demonstration
- ✅ Error handling demonstrations
- ✅ Code walkthrough
- ✅ Explanation of key concepts

---

## ✅ Assignment Requirements Checklist

### Functional Requirements

| Requirement | Status | Implementation Details |
|-------------|--------|------------------------|
| Add a Student (Dictionary<string, int>) | ✅ Complete | StudentGradeManager.AddStudent() method |
| Display all Students | ✅ Complete | Both console and GUI display sorted lists |
| Search for a Student | ✅ Complete | Dictionary key lookup with error handling |
| Calculate Average Grade | ✅ Complete | Uses LINQ Average() method |
| Find Highest and Lowest Grades | ✅ Complete | Uses LINQ Max() and Min() methods |
| Error Handling | ✅ Complete | Comprehensive try-catch blocks throughout |
| Input Handling | ✅ Complete | Keyboard input (console) + UI (forms) |
| Additional Features - UI | ✅ Complete | Windows Forms application with modern design |

### Technical Requirements

| Requirement | Status | Implementation Details |
|-------------|--------|------------------------|
| Dictionary Data Structure | ✅ Complete | Dictionary<string, int> in StudentGradeManager |
| List Data Structure | ✅ Complete | List<StudentRecord> for displaying students |
| Control Flow (if/else) | ✅ Complete | Input validation, condition checks |
| Control Flow (loops) | ✅ Complete | while loops, foreach loops |
| Control Flow (switch) | ✅ Complete | Console menu system uses switch statement |
| Functions/Methods | ✅ Complete | Organized into logical methods |
| Exception Handling | ✅ Complete | ArgumentException, KeyNotFoundException, InvalidOperationException |
| Struct | ✅ Complete | StudentRecord struct with properties |
| Enum | ✅ Complete | GradeCategory enum (A, B, C, D, F) |
| Best Practices | ✅ Complete | Comments, meaningful names, organized code |
| On-screen UI | ✅ Complete | Windows Forms with buttons, text boxes, labels |

---

## 🏗️ Project Architecture

### Project Structure:
```
StudentGradeManagement/
├── GradeManagementCore/          # Business logic (Class Library)
│   ├── GradeCategory.cs          # Enum for grade categories
│   ├── StudentRecord.cs          # Struct for student records
│   └── StudentGradeManager.cs    # Main management class
├── GradeManagementConsole/       # Console application
│   └── Program.cs                # Console UI
├── GradeManagementUI/            # Windows Forms application
│   └── Form1.cs                  # GUI implementation
└── StudentGradeManagement.sln    # Solution file
```

### Design Decisions:

**1. Three-Project Architecture**
- Separated business logic from presentation layers
- Core library can be reused by multiple UI projects
- Easier to test and maintain

**2. Dictionary<string, int> Choice**
- O(1) lookup time for searching students by name
- Naturally prevents duplicate student names
- Efficient for the required operations

**3. Struct vs Class**
- StudentRecord is a struct (value type)
- Lightweight for simple data containers
- Appropriate for small, immutable data

**4. Enum for Grades**
- Type-safe grade categories
- Prevention of invalid values
- Easy to extend if needed

---

## 🎯 Key Features Demonstrated

### 1. Data Structures
- **Dictionary**: Primary storage for student grades
- **List**: For returning and displaying student collections
- **Struct**: StudentRecord for data encapsulation

### 2. LINQ Operations
- `Average()`: Calculate average grade
- `Max()`: Find highest grade
- `Min()`: Find lowest grade
- `Where()`: Filter students by grade
- `Select()`: Project student names

### 3. Exception Handling
- `ArgumentException`: Invalid input validation
- `KeyNotFoundException`: Non-existent student searches
- `InvalidOperationException`: Empty collection operations
- User-friendly error messages in both interfaces

### 4. Control Flow
- **Switch statements**: Menu navigation (console)
- **If/else**: Conditional logic throughout
- **While loops**: Main menu loop (console)
- **Foreach loops**: Iterating student collections

### 5. User Interfaces
- **Console**: Menu-driven text interface
- **Windows Forms**: Graphical interface with buttons, text boxes, and real-time statistics

---

## 🧪 Testing Performed

### Test Scenarios Completed:

1. ✅ **Add Valid Student**: Successfully adds with grade 0-100
2. ✅ **Add Invalid Grade**: Rejects grades <0 or >100
3. ✅ **Add Duplicate Student**: Prevents duplicate entries
4. ✅ **Add Empty Name**: Rejects empty student names
5. ✅ **Search Existing Student**: Successfully finds and displays
6. ✅ **Search Non-existent Student**: Shows appropriate error
7. ✅ **Display Empty List**: Handles empty system gracefully
8. ✅ **Display with Data**: Correctly sorted and formatted
9. ✅ **Calculate Average (empty)**: Error handling for empty list
10. ✅ **Calculate Average (with data)**: Correct calculation
11. ✅ **Find High/Low (empty)**: Error handling
12. ✅ **Find High/Low (with data)**: Correctly identifies multiple students
13. ✅ **Update Existing**: Successfully updates grade
14. ✅ **Update Non-existent**: Appropriate error message
15. ✅ **Remove Existing**: Successfully removes student
16. ✅ **Remove Non-existent**: Appropriate error message
17. ✅ **Sample Data Loading**: Successfully loads 8 students

---

## 💡 Challenges and Solutions

### Challenge 1: [Example: Maintaining Statistics in Real-Time]
**Problem**: GUI statistics needed to update after every operation  
**Solution**: Created UpdateStatistics() method called after each modification

### Challenge 2: [Add your own challenges]
**Problem**: [Describe a challenge you faced]  
**Solution**: [How you solved it]

---

## 🚀 How to Run

### Windows Forms GUI (Recommended):
```powershell
cd C:\Users\user\Downloads\StudentGradeManagement
dotnet run --project GradeManagementUI
```

### Console Application:
```powershell
cd C:\Users\user\Downloads\StudentGradeManagement
dotnet run --project GradeManagementConsole
```

### Build All Projects:
```powershell
dotnet build
```

---

## 📚 Learning Outcomes

Through this assignment, I demonstrated proficiency in:

1. **C# Fundamentals**: Variables, data types, operators, control structures
2. **Object-Oriented Programming**: Classes, structs, enums, methods
3. **Data Structures**: Dictionary, List, understanding time complexity
4. **LINQ**: Functional programming style queries and operations
5. **Exception Handling**: Try-catch blocks, custom error messages
6. **User Interface Design**: Both console and graphical interfaces
7. **Project Organization**: Multi-project solutions, separation of concerns
8. **Version Control**: Git and GitHub for code management
9. **Documentation**: README files, inline comments, XML documentation

---

## 🔮 Future Enhancements

Potential improvements for this application:

1. **Database Integration**: SQLite or SQL Server for persistence
2. **Multiple Grades**: Track assignments, exams, and final grades
3. **Student Profiles**: Add ID, contact info, major, enrollment date
4. **Grade Analytics**: Charts, graphs, trend analysis
5. **Export/Import**: CSV/Excel support for data portability
6. **User Authentication**: Login system for different roles
7. **Class Management**: Group students by class/semester
8. **GPA Calculation**: Credit hours and cumulative GPA

---

## 📞 Contact Information

**Name**: [Your Name]  
**Email**: [Your Email]  
**GitHub**: [Your GitHub Profile]  

---

## 📄 Declaration

I declare that this assignment is my own work and code. All sources and references have been properly acknowledged. The application meets all the requirements specified in the assignment brief.

**Signature**: [Your Name]  
**Date**: February 14, 2026

---

## 📎 Appendix

### A. Code Statistics
- **Total Lines of Code**: ~1,460
- **Number of Classes**: 1 (StudentGradeManager)
- **Number of Structs**: 1 (StudentRecord)
- **Number of Enums**: 1 (GradeCategory)
- **Number of Methods**: 15+ methods
- **Projects**: 3 (.NET projects)

### B. Technologies Used
- **Language**: C# 11
- **Framework**: .NET 7.0
- **UI Frameworks**: Windows Forms (ALU Theme - Red, Blue, White)
- **Version Control**: Git 2.x
- **Development Environment**: Visual Studio Code / Visual Studio 2022

### C. References
- Microsoft C# Documentation: https://docs.microsoft.com/en-us/dotnet/csharp/
- LINQ Documentation: https://docs.microsoft.com/en-us/dotnet/csharp/linq/
- Windows Forms Guide: https://docs.microsoft.com/en-us/dotnet/desktop/winforms/
- C# Programming Guide: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/

---

**End of Submission Document**
