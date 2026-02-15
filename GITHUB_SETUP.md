# 📦 GitHub Repository Setup Guide

This guide walks you through publishing your Student Grade Management System to GitHub.

## 🎯 Quick GitHub Upload (5 minutes)

### Step 1: Create a GitHub Repository

1. **Go to GitHub.com**
   - Sign in to your account (or create one at https://github.com/join)

2. **Create a new repository**
   - Click the **+** icon in the top right → "New repository"
   - **Repository name**: `StudentGradeManagementSystem` (or any name you prefer)
   - **Description**: `A C# application for managing student records and grades with Console and Windows Forms UI`
   - **Visibility**: Choose **Public** (so instructors can access it)
   - **Important**: Do NOT initialize with README, .gitignore, or license (we already have these)
   - Click **"Create repository"**

### Step 2: Link Your Local Project to GitHub

The repository is already initialized with Git. Now connect it to GitHub:

```powershell
# Navigate to your project directory
cd C:\Users\user\Downloads\StudentGradeManagement

# Add your GitHub repository as remote
git remote add origin https://github.com/YOUR_USERNAME/StudentGradeManagementSystem.git

# Push your code to GitHub
git branch -M main
git push -u origin main
```

**Replace `YOUR_USERNAME`** with your actual GitHub username!

### Step 3: Verify Upload

1. Refresh your GitHub repository page
2. You should see all your files:
   - README.md
   - QUICKSTART.md
   - VIDEO_GUIDE.md
   - All project folders
   - .gitignore

---

## 🔒 Authentication Issues?

If you get authentication errors, GitHub requires a Personal Access Token:

### Create a Personal Access Token (PAT)

1. Go to GitHub → Settings → Developer settings → Personal access tokens → Tokens (classic)
2. Click "Generate new token" → "Generate new token (classic)"
3. Give it a name: "Student Grade Management Upload"
4. Set expiration: 30 days (or custom)
5. Check the **repo** scope (full control of private repositories)
6. Click "Generate token"
7. **Copy the token immediately** (you won't see it again!)

### Use Token for Authentication

When pushing, use the token as your password:
```powershell
Username: your_github_username
Password: paste_your_token_here
```

Or configure it permanently:
```powershell
git config credential.helper store
git push -u origin main
# Enter username and token when prompted
```

---

## 📝 Updating Your Repository After Changes

Made changes to your code? Update GitHub:

```powershell
# Stage all changes
git add .

# Commit with a descriptive message
git commit -m "Add new feature or fix bug"

# Push to GitHub
git push
```

---

## 🎨 Enhance Your GitHub Repository

### Add Topics/Tags

1. Go to your repository on GitHub
2. Click the ⚙️ gear icon next to "About"
3. Add topics: `csharp`, `dotnet`, `windows-forms`, `console-application`, `student-management`, `dictionary`, `linq`
4. Update description if needed
5. Save changes

### Pin the Repository (Optional)

1. Go to your GitHub profile
2. Click "Customize your pins"
3. Select this repository to showcase it

---

## 📄 Sample Repository Description

Use this for your GitHub repository description:

```
A comprehensive C# application demonstrating Dictionary data structures, 
LINQ operations, exception handling, structs, and enums. Features both 
a console interface and a modern Windows Forms GUI for managing student 
grades. Built with .NET 7.0.
```

---

## 🌟 Adding a License (Optional but Recommended)

1. In your repository, click "Add file" → "Create new file"
2. Name it `LICENSE`
3. Click "Choose a license template"
4. Select **MIT License** (most common for educational projects)
5. Fill in your name and year
6. Commit the file

---

## 📊 Repository Stats & Insights

After uploading, your repository will show:
- **13 files** in the initial commit
- **1,460+ lines of code**
- **3 C# projects**
- **Programming language**: C# (primary)

---

## 🔗 Get Your Repository Link

After uploading, your repository URL will be:
```
https://github.com/YOUR_USERNAME/StudentGradeManagementSystem
```

**This is the link to submit for your assignment!**

---

## ✅ Submission Checklist

Before submitting, verify your GitHub repository has:

- ✅ All source code files (.cs files)
- ✅ All project files (.csproj)
- ✅ Solution file (.sln)
- ✅ README.md with instructions
- ✅ QUICKSTART.md for quick reference
- ✅ VIDEO_GUIDE.md for video demo help
- ✅ .gitignore file
- ✅ Repository is public (not private)
- ✅ Description and topics are added

---

## 🎥 Submitting Your Video

In your submission document, include:

```markdown
# Student Grade Management System Submission

**Student Name**: [Your Name]
**Date**: February 14, 2026

## GitHub Repository
https://github.com/YOUR_USERNAME/StudentGradeManagementSystem

## Video Demonstration
[Link to your video]
Platform: YouTube/Google Drive/Loom/etc.
Duration: X minutes

## Project Summary
This C# application manages student records and grades using:
- Dictionary<string, int> for efficient storage
- LINQ (Max, Min, Average) for calculations
- Comprehensive exception handling
- StudentRecord struct and GradeCategory enum
- Dual interfaces: Console and Windows Forms

All assignment requirements have been implemented and tested.
```

---

## 🆘 Troubleshooting

### "Repository not found" error
- Check the URL is correct
- Verify you have push access
- Make sure you're using HTTPS, not SSH (unless SSH is configured)

### "Permission denied" error
- Use Personal Access Token instead of password
- Check token has 'repo' scope
- Verify token hasn't expired

### Large files warning
- The .gitignore excludes bin/ and obj/ folders
- If you get warnings, run: `git rm -r --cached bin obj`

### Merge conflicts
- If you initialized the repo with files, pull first:
  ```powershell
  git pull origin main --allow-unrelated-histories
  git push origin main
  ```

---

## 📞 Need Help?

- **GitHub Docs**: https://docs.github.com/
- **Git Tutorial**: https://git-scm.com/docs/gittutorial
- **Video Guide**: [Git and GitHub for Beginners](https://www.youtube.com/watch?v=RGOj5yH7evk)

---

**Good luck with your submission! 🚀**
