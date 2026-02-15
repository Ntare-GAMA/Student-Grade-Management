# Student Grade Management System

A C# application for managing student records and grades, featuring both a console-based interface and a Windows Forms GUI with African Leadership University theme colors (Red, Blue, and White).

## Features

Core Functionality
- Add Students: Add student names with grades (0-100) to the system
- Display All Students: View all students with their grades and letter categories
- Search for Students: Search by name to find specific student grades
- Calculate Average: Compute the average grade across all students
- Find Highest/Lowest: Identify students with the highest and lowest grades
- Update Grades: Modify existing student grades
- Remove Students: Delete student records from the system
- Sample Data: Load pre-populated sample data for testing

Technical Highlights
- **Data Structures**: Uses `Dictionary<string, int>` for efficient storage and retrieval
- **Exception Handling**: Comprehensive error handling for all operations
- **Structs & Enums**: Implements `StudentRecord` struct and `GradeCategory` enum
- **Dual Interface**: Both console and Windows Forms UI implementations
- **Clean Architecture**: Separated core business logic from UI layers

## Grade Categories

The system automatically categorizes grades using an enum:

| Category | Grade Range |
|----------|-------------|
| A        | 90-100      |
| B        | 80-89       |
| C        | 70-79       |
| D        | 60-69       |
| F        | 0-59        |

## Project Structure

```
StudentGradeManagement/
├── GradeManagementCore/          # Core business logic (Class Library)
│   ├── GradeCategory.cs          # Enum for grade categories
│   ├── StudentRecord.cs          # Struct representing student records
│   └── StudentGradeManager.cs    # Main management class
│
├── GradeManagementConsole/       # Console application
│   └── Program.cs                # Console UI implementation
│
├── GradeManagementUI/            # Windows Forms application
│   ├── Form1.cs                  # GUI implementation
│   └── Form1.Designer.cs         # Auto-generated designer code
│
└── StudentGradeManagement.sln    # Solution file
```

## How to Run

### Prerequisites
- **.NET SDK 6.0 or higher** (tested with .NET 7.0)
- **Windows OS** (for Windows Forms application)
- **Visual Studio 2022 or VS Code** (optional, for development)

### Running the Console Application

1. **Open Terminal/Command Prompt** and navigate to the project directory:
   ```bash
   cd StudentGradeManagement
   ```

2. **Run the console application**:
   ```bash
   dotnet run --project GradeManagementConsole
   ```

3. **Follow the on-screen menu** to interact with the system:
   - Enter numbers 1-9 to select operations
   - Follow prompts to input student names and grades
   - Press any key to continue after each operation

### Running the Windows Forms Application

1. **Open Terminal/Command Prompt** and navigate to the project directory:
   ```bash
   cd StudentGradeManagement
   ```

2. **Run the Windows Forms application**:
   ```bash
   dotnet run --project GradeManagementUI
   ```

3. **Use the GUI interface**:
   - Enter student name and grade in the text fields
   - Click buttons to perform various operations
   - View real-time statistics in the side panel
   - Sample data loads automatically on startup

### Building the Projects

To build all projects in the solution:
```bash
dotnet build
```

To build a specific project:
```bash
dotnet build GradeManagementConsole
dotnet build GradeManagementUI
```

## Usage Examples

### Console Application

```
╔═══════════════════════════════════════════════════╗
║                    MAIN MENU                      ║
╚═══════════════════════════════════════════════════╝
  1. Add a Student
  2. Display All Students
  3. Search for a Student
  4. Calculate Average Grade
  5. Find Highest and Lowest Grades
  6. Update Student Grade
  7. Remove a Student
  8. Load Sample Data
  9. Exit
───────────────────────────────────────────────────
Enter your choice (1-9): 1

┌─ ADD STUDENT ─────────────────────────────────────┐
Enter student name: Alice Johnson
Enter grade (0-100): 95

Successfully added: Alice Johnson: 95 (A)
```

### Windows Forms Application

The GUI provides an intuitive interface with:
- **Input Fields**: Text boxes for student name and grade
- **Action Buttons**: Color-coded buttons for all operations
- **Student List**: Real-time list of all students sorted by grade
- **Statistics Panel**: Live statistics including total students, average, highest, and lowest grades

## Error Handling

The application handles various error scenarios:

- **Empty Names**: Prevents adding students with blank names
- **Invalid Grades**: Validates that grades are between 0-100
- **Duplicate Students**: Prevents adding the same student twice
- **Non-existent Students**: Gracefully handles searches/updates for students not in the system
- **Empty Dataset**: Handles calculations when no students exist
- **Invalid Input**: Validates numeric input for grades

## Testing the Application

### Quick Test with Sample Data

Both applications include a "Load Sample Data" feature that adds 8 students:
- Alice Johnson (95)
- Bob Smith (78)
- Carol Williams (88)
- David Brown (92)
- Emma Davis (65)
- Frank Miller (73)
- Grace Wilson (98)
- Henry Taylor (82)

Use this to quickly test all features without manual data entry.

### Manual Testing Checklist

1. Add a new student
2. Try adding a student with invalid grade (e.g., 150, -10, "abc")
3. Try adding an existing student (should show error)
4. Search for an existing student
5. Search for a non-existent student
6. Display all students
7. Calculate average grade
8. Find highest and lowest grades
9. Update a student's grade
10. Remove a student

## Educational Concepts Demonstrated

This project demonstrates key C# programming concepts:

1. **Data Structures**: Dictionary, List
2. **Control Flow**: if/else statements, switch cases, loops (foreach)
3. **Functions/Methods**: Organized, reusable code
4. **Exception Handling**: try/catch blocks with specific exception types
5. **Structs**: StudentRecord struct with properties
6. **Enums**: GradeCategory enum
7. **LINQ**: Max(), Min(), Average(), Where(), Select()
8. **Object-Oriented Programming**: Classes, encapsulation, separation of concerns
9. **Event Handling**: Button click events in Windows Forms
10. **Project Organization**: Multi-project solution with references

## Video Demonstration Guide

When recording your video demonstration, consider covering:

1. **Introduction** (30 seconds)
   - Briefly introduce the project and its purpose
   - Show both console and GUI versions

2. **Console Application Demo** (2-3 minutes)
   - Run the console app
   - Demonstrate adding students
   - Show all operations from the menu
   - Demonstrate error handling (try invalid inputs)

3. **Windows Forms Application Demo** (2-3 minutes)
   - Run the GUI app
   - Show the interface design
   - Demonstrate all button functions
   - Highlight the statistics panel
   - Show error message dialogs

4. **Code Walkthrough** (2-3 minutes)
   - Show the project structure
   - Highlight key classes (StudentGradeManager, StudentRecord)
   - Point out exception handling
   - Show the use of Dictionary and LINQ

5. **Conclusion** (30 seconds)
   - Summarize features implemented
   - Mention technical requirements met

## Assignment Requirements Checklist

### Functional Requirements
- Add a Student (Dictionary<string, int>)
- Display all Students
- Search for a Student (with appropriate messages)
- Calculate Average Grade
- Find Highest and Lowest Grades (using Max() and Min())
- Error Handling (comprehensive)
- Input Handling (keyboard + UI)
- Additional Features (Windows Forms UI)

### Technical Requirements
- Appropriate data structures (Dictionary, List)
- Control flow statements (if/else, loops, switch)
- Functions for logical organization
- Exception handling throughout
- Structs (StudentRecord) and Enums (GradeCategory)
- Best coding practices with comments
- Onscreen UI (Windows Forms)

## Contributing

To extend this project, consider adding:
- Database persistence (SQLite, SQL Server)
- Student ID system
- Multiple grade entries per student (assignments, exams)
- Grade history tracking
- Export to CSV/PDF
- Advanced filtering and sorting
- Student profiles with additional information

## License

This project is created for educational purposes as part of a C# programming assignment.

## Author

Created as part of the Student Grade Management System assignment.
