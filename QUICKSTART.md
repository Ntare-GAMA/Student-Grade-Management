# 🚀 Quick Start Guide

## Run the Application in 3 Steps

### Option 1: Windows Forms UI (Recommended)

1. **Open PowerShell or Command Prompt**
   ```powershell
   cd C:\Users\user\Downloads\StudentGradeManagement
   ```

2. **Run the application**
   ```powershell
   dotnet run --project GradeManagementUI
   ```

3. **Use the GUI**
   - Sample data loads automatically
   - Enter student names and grades
   - Click colorful buttons to perform operations
   - View statistics in the right panel

### Option 2: Console Application

1. **Open PowerShell or Command Prompt**
   ```powershell
   cd C:\Users\user\Downloads\StudentGradeManagement
   ```

2. **Run the application**
   ```powershell
   dotnet run --project GradeManagementConsole
   ```

3. **Follow the menu**
   - Enter numbers 1-9 to select operations
   - Press 8 to load sample data
   - Try all features before exiting

## Quick Test

After running either version:

1. ✅ **Load sample data** (Option 8 in console, or click "Sample Data" button in GUI)
2. ✅ **View all students** (Option 2 in console, or see the list in GUI)
3. ✅ **Calculate average** (Option 4 in console, or click "Average" button)
4. ✅ **Find High/Low** (Option 5 in console, or click "High/Low" button)
5. ✅ **Search for "Alice Johnson"** to test search functionality
6. ✅ **Add a new student** with your own name and grade
7. ✅ **Try to add the same student again** to test error handling

## Key Features at a Glance

| Feature | Console Command | GUI Button |
|---------|----------------|------------|
| Add Student | Option 1 | ➕ Add |
| View All | Option 2 | (Main List) |
| Search | Option 3 | 🔍 Search |
| Average | Option 4 | 📊 Average |
| High/Low | Option 5 | 📈 High/Low |
| Update | Option 6 | ✏️ Update |
| Remove | Option 7 | 🗑️ Remove |
| Sample Data | Option 8 | 📝 Sample Data |

## Troubleshooting

**Application won't start?**
- Make sure .NET SDK 6.0+ is installed: `dotnet --version`
- Run `dotnet build` first to ensure compilation

**Windows Forms won't display?**
- This requires Windows OS
- Try running the console version instead

**Can't find the directory?**
- Make sure you're in the correct directory: `cd C:\Users\user\Downloads\StudentGradeManagement`

## Next Steps

- Read the full [README.md](README.md) for detailed documentation
- Check [VIDEO_GUIDE.md](VIDEO_GUIDE.md) for video demonstration tips
- Review the code to understand the implementation
- Customize and extend the application

---

**Need Help?** Review the comprehensive README.md file for detailed instructions and explanations.
