using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GradeManagementCore;

namespace GradeManagementUI;

public partial class Form1 : Form
{
    private StudentGradeManager manager;

    private TextBox txtStudentName;
    private TextBox txtGrade;
    private ListBox lstStudents;
    private Label lblStats;
    private Label lblTitle;
    private Button btnAdd;
    private Button btnSearch;
    private Button btnUpdate;
    private Button btnRemove;
    private Button btnCalculateAvg;
    private Button btnHighLow;
    private Button btnRefresh;
    private Button btnLoadSample;

    public Form1()
    {
        InitializeComponent();
        manager = new StudentGradeManager();
        InitializeCustomComponents();
        LoadSampleData();
    }

    private void InitializeCustomComponents()
    {
        this.Text = "Student Grade Management System";
        this.Size = new Size(800, 600);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.BackColor = Color.White;

        lblTitle = new Label
        {
            Text = "📚 STUDENT GRADE MANAGEMENT SYSTEM",
            Location = new Point(20, 20),
            Size = new Size(740, 40),
            Font = new Font("Segoe UI", 18, FontStyle.Bold),
            ForeColor = Color.FromArgb(30, 64, 175),
            TextAlign = ContentAlignment.MiddleCenter
        };
        this.Controls.Add(lblTitle);

        Label lblName = new Label
        {
            Text = "Student Name (start typing to search):",
            Location = new Point(20, 58),
            Size = new Size(250, 20),
            Font = new Font("Segoe UI", 8, FontStyle.Italic),
            ForeColor = Color.Gray
        };
        this.Controls.Add(lblName);

        Label lblNameField = new Label
        {
            Text = "Student Name:",
            Location = new Point(20, 78),
            Size = new Size(120, 25),
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };
        this.Controls.Add(lblNameField);

        txtStudentName = new TextBox
        {
            Location = new Point(150, 78),
            Size = new Size(200, 25),
            Font = new Font("Segoe UI", 10)
        };
        txtStudentName.TextChanged += TxtStudentName_TextChanged;
        this.Controls.Add(txtStudentName);

        Label lblGrade = new Label
        {
            Text = "Grade (0-100):",
            Location = new Point(370, 80),
            Size = new Size(120, 25),
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };
        this.Controls.Add(lblGrade);

        txtGrade = new TextBox
        {
            Location = new Point(500, 78),
            Size = new Size(100, 25),
            Font = new Font("Segoe UI", 10)
        };
        this.Controls.Add(txtGrade);

        btnAdd = new Button
        {
            Text = "➕ Add",
            Location = new Point(620, 75),
            Size = new Size(140, 30),
            BackColor = Color.FromArgb(30, 64, 175),
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 10, FontStyle.Bold),
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand
        };
        btnAdd.FlatAppearance.BorderSize = 0;
        btnAdd.Click += BtnAdd_Click;
        this.Controls.Add(btnAdd);

        Label lblListHint = new Label
        {
            Text = "💡 Click any student below to auto-fill their details",
            Location = new Point(20, 100),
            Size = new Size(580, 20),
            Font = new Font("Segoe UI", 8, FontStyle.Italic),
            ForeColor = Color.Gray,
            TextAlign = ContentAlignment.MiddleCenter
        };
        this.Controls.Add(lblListHint);

        lstStudents = new ListBox
        {
            Location = new Point(20, 120),
            Size = new Size(580, 280),
            Font = new Font("Consolas", 10),
            BackColor = Color.White,
            BorderStyle = BorderStyle.FixedSingle
        };
        lstStudents.SelectedIndexChanged += LstStudents_SelectedIndexChanged;
        this.Controls.Add(lstStudents);

        lblStats = new Label
        {
            Text = "Statistics will appear here...",
            Location = new Point(620, 120),
            Size = new Size(140, 280),
            Font = new Font("Segoe UI", 9),
            BackColor = Color.White,
            BorderStyle = BorderStyle.FixedSingle,
            Padding = new Padding(10)
        };
        this.Controls.Add(lblStats);

        btnSearch = new Button
        {
            Text = "🔍 Search",
            Location = new Point(20, 420),
            Size = new Size(120, 35),
            BackColor = Color.FromArgb(59, 130, 246),
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 9, FontStyle.Bold),
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand
        };
        btnSearch.FlatAppearance.BorderSize = 0;
        btnSearch.Click += BtnSearch_Click;
        this.Controls.Add(btnSearch);

        btnUpdate = new Button
        {
            Text = "✏️ Update",
            Location = new Point(150, 420),
            Size = new Size(120, 35),
            BackColor = Color.FromArgb(59, 130, 246),
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 9, FontStyle.Bold),
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand
        };
        btnUpdate.FlatAppearance.BorderSize = 0;
        btnUpdate.Click += BtnUpdate_Click;
        this.Controls.Add(btnUpdate);

        btnRemove = new Button
        {
            Text = "🗑️ Remove",
            Location = new Point(280, 420),
            Size = new Size(120, 35),
            BackColor = Color.FromArgb(220, 38, 38),
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 9, FontStyle.Bold),
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand
        };
        btnRemove.FlatAppearance.BorderSize = 0;
        btnRemove.Click += BtnRemove_Click;
        this.Controls.Add(btnRemove);

        btnCalculateAvg = new Button
        {
            Text = "📊 Average",
            Location = new Point(20, 465),
            Size = new Size(120, 35),
            BackColor = Color.FromArgb(30, 64, 175),
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 9, FontStyle.Bold),
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand
        };
        btnCalculateAvg.FlatAppearance.BorderSize = 0;
        btnCalculateAvg.Click += BtnCalculateAvg_Click;
        this.Controls.Add(btnCalculateAvg);

        btnHighLow = new Button
        {
            Text = "📈 High/Low",
            Location = new Point(150, 465),
            Size = new Size(120, 35),
            BackColor = Color.FromArgb(220, 38, 38),
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 9, FontStyle.Bold),
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand
        };
        btnHighLow.FlatAppearance.BorderSize = 0;
        btnHighLow.Click += BtnHighLow_Click;
        this.Controls.Add(btnHighLow);

        btnRefresh = new Button
        {
            Text = "🔄 Refresh",
            Location = new Point(280, 465),
            Size = new Size(120, 35),
            BackColor = Color.FromArgb(59, 130, 246),
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 9, FontStyle.Bold),
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand
        };
        btnRefresh.FlatAppearance.BorderSize = 0;
        btnRefresh.Click += BtnRefresh_Click;
        this.Controls.Add(btnRefresh);

        btnLoadSample = new Button
        {
            Text = "📝 Sample Data",
            Location = new Point(410, 465),
            Size = new Size(140, 35),
            BackColor = Color.FromArgb(30, 64, 175),
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 9, FontStyle.Bold),
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand
        };
        btnLoadSample.FlatAppearance.BorderSize = 0;
        btnLoadSample.Click += BtnLoadSample_Click;
        this.Controls.Add(btnLoadSample);
    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            string name = txtStudentName.Text.Trim();
            
            if (!int.TryParse(txtGrade.Text, out int grade))
            {
                throw new ArgumentException("Please enter a valid numeric grade.");
            }

            manager.AddStudent(name, grade);
            
            StudentRecord record = new StudentRecord(name, grade);
            MessageBox.Show($"Successfully added:\n{record}", "Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            RefreshStudentList();
            UpdateStatistics();
            ClearInputFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            string name = txtStudentName.Text.Trim();
            int grade = manager.SearchStudent(name);
            
            StudentRecord record = new StudentRecord(name, grade);
            MessageBox.Show($"Student Found:\n\n{record}", "Search Result", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void BtnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            string name = txtStudentName.Text.Trim();
            
            if (!int.TryParse(txtGrade.Text, out int grade))
            {
                throw new ArgumentException("Please enter a valid numeric grade.");
            }

            manager.UpdateStudentGrade(name, grade);
            
            StudentRecord record = new StudentRecord(name, grade);
            MessageBox.Show($"Successfully updated:\n{record}", "Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            RefreshStudentList();
            UpdateStatistics();
            ClearInputFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnRemove_Click(object sender, EventArgs e)
    {
        try
        {
            string name = txtStudentName.Text.Trim();
            
            var result = MessageBox.Show($"Are you sure you want to remove '{name}'?", 
                "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                manager.RemoveStudent(name);
                MessageBox.Show($"Successfully removed student: {name}", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                RefreshStudentList();
                UpdateStatistics();
                ClearInputFields();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnCalculateAvg_Click(object sender, EventArgs e)
    {
        try
        {
            double average = manager.CalculateAverageGrade();
            GradeCategory category = new StudentRecord("", (int)Math.Round(average)).Category;
            
            MessageBox.Show($"Average Grade: {average:F2}\nLetter Grade: {category}", 
                "Average Grade", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void BtnHighLow_Click(object sender, EventArgs e)
    {
        try
        {
            int highest = manager.GetHighestGrade();
            int lowest = manager.GetLowestGrade();
            
            var topStudents = manager.GetStudentsWithHighestGrade();
            var bottomStudents = manager.GetStudentsWithLowestGrade();

            string message = $"HIGHEST GRADE: {highest}\n";
            message += $"Students: {string.Join(", ", topStudents)}\n\n";
            message += $"LOWEST GRADE: {lowest}\n";
            message += $"Students: {string.Join(", ", bottomStudents)}";

            MessageBox.Show(message, "Grade Statistics", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void BtnRefresh_Click(object sender, EventArgs e)
    {
        RefreshStudentList();
        UpdateStatistics();
    }

    private void BtnLoadSample_Click(object sender, EventArgs e)
    {
        LoadSampleData();
    }

    private void LoadSampleData()
    {
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

            RefreshStudentList();
            UpdateStatistics();
            
            MessageBox.Show("Successfully loaded 8 sample students!", "Sample Data Loaded", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (InvalidOperationException)
        {
            RefreshStudentList();
            UpdateStatistics();
        }
    }

    private void RefreshStudentList(string searchFilter = "")
    {
        lstStudents.Items.Clear();
        var students = manager.GetAllStudents();
        
        if (!string.IsNullOrWhiteSpace(searchFilter))
        {
            students = students.Where(s => s.Name.ToLower().Contains(searchFilter.ToLower())).ToList();
        }
        
        students.Sort((a, b) => b.Grade.CompareTo(a.Grade));

        if (string.IsNullOrWhiteSpace(searchFilter))
        {
            lstStudents.Items.Add("═══════════════════════════════════════════════════");
            lstStudents.Items.Add($"  TOTAL STUDENTS: {students.Count}");
            lstStudents.Items.Add("═══════════════════════════════════════════════════");
        }
        else
        {
            lstStudents.Items.Add($"  ═══ SEARCH RESULTS: {students.Count} match(es) ═══");
        }

        foreach (var student in students)
        {
            lstStudents.Items.Add($"  {student}");
        }
    }

    private void TxtStudentName_TextChanged(object sender, EventArgs e)
    {
        string searchText = txtStudentName.Text.Trim();
        RefreshStudentList(searchText);
    }

    private void LstStudents_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstStudents.SelectedItem == null) return;
        
        string selectedLine = lstStudents.SelectedItem.ToString();
        
        if (selectedLine.Contains("═") || selectedLine.Contains("TOTAL") || 
            selectedLine.Contains("SEARCH RESULTS")) return;

        string trimmed = selectedLine.Trim();
        int colonIndex = trimmed.IndexOf(':');
        
        if (colonIndex > 0)
        {
            string name = trimmed.Substring(0, colonIndex).Trim();
            string gradeAndCategory = trimmed.Substring(colonIndex + 1).Trim();
            int spaceIndex = gradeAndCategory.IndexOf(' ');
            
            if (spaceIndex > 0)
            {
                string gradeStr = gradeAndCategory.Substring(0, spaceIndex).Trim();
                
                txtStudentName.TextChanged -= TxtStudentName_TextChanged;
                txtStudentName.Text = name;
                txtGrade.Text = gradeStr;
                txtStudentName.TextChanged += TxtStudentName_TextChanged;
            }
        }
    }

    private void UpdateStatistics()
    {
        try
        {
            int count = manager.GetStudentCount();
            
            if (count == 0)
            {
                lblStats.Text = "No students yet.\n\nAdd students to see statistics.";
                return;
            }

            double avg = manager.CalculateAverageGrade();
            int high = manager.GetHighestGrade();
            int low = manager.GetLowestGrade();

            lblStats.Text = "📊 STATISTICS\n\n";
            lblStats.Text += $"Total Students:\n{count}\n\n";
            lblStats.Text += $"Average Grade:\n{avg:F2}\n\n";
            lblStats.Text += $"Highest Grade:\n{high}\n\n";
            lblStats.Text += $"Lowest Grade:\n{low}";
        }
        catch
        {
            lblStats.Text = "Statistics\nunavailable";
        }
    }

    private void ClearInputFields()
    {
        txtStudentName.TextChanged -= TxtStudentName_TextChanged;
        txtStudentName.Clear();
        txtGrade.Clear();
        txtStudentName.Focus();
        txtStudentName.TextChanged += TxtStudentName_TextChanged;
        RefreshStudentList();
    }
}

