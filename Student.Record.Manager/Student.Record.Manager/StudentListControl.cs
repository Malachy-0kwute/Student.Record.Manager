using MaterialSkin;
using Student.Record.Manager;

namespace Student.Record.Manager
{
    public partial class StudentListControl : UserControl
    {
        private StudentService _studentService;
        private Dictionary<int, Guid> _studentInfo;
        private int _counter = 1;
        public StudentListControl()
        {
            InitializeComponent();

            _studentService = new StudentService();
            _studentInfo = [];

            Load += (s, e) =>
            {
                var students = _studentService.LoadStudents();

                if(students.Any())
                {
                    emptyLabel.Visible = false;

                    foreach (var student in students)
                    {
                        var id = (_counter++).ToString();
                        var data = new[]
                        {   
                            id,
                            student.FirstName,
                            student.LastName,
                            student.Email,
                            student.IsActive ? "Enrolled" : "Not Enrolled",
                            student.AdmissionDate
                        };

                        var item = new ListViewItem(data);
                        studentList.Items.Add(item);

                        _studentInfo.Add(int.Parse(id), student.Id);
                    }
                }
                else
                {
                    emptyLabel.Visible = true;
                }
            };

            studentList.Click += StudentList_Click;
        }

        private void StudentList_Click(object? sender, EventArgs e)
        {
            if (ParentForm is Form1 mainForm)
            {
                var window = new DialogBox();
                window.Owner = mainForm;
                window.StartPosition = FormStartPosition.CenterParent;
                window.Text = "Student Record";

                var studentDetail = new StudentInfoControl();

                foreach (var item in studentList.Items)
                {
                    if(item is ListViewItem listItem && listItem.Focused)
                    {
                        var key = _studentInfo.GetValueOrDefault(int.Parse(listItem.Text));
                        var student = _studentService.GetStudent(key);
                        if (student is not null)
                        {
                            studentDetail.FirstName = student.FirstName;
                            studentDetail.LastName = student.LastName;
                            studentDetail.Email = student.Email;
                            studentDetail.Address = student.Address;
                            studentDetail.PhoneNumber = student.PhoneNumber;
                            studentDetail.Credits = student.Credits.ToString();
                            studentDetail.Gpa = student.Gpa.ToString();
                            studentDetail.AdmissionDate = student.AdmissionDate;
                            studentDetail.IsActive = student.IsActive ? "Enrolled" : "Not enrolled";

                            student.EnrolledCourses.ForEach(course =>
                            {
                                var courseDetails = course.Split(":");
                                studentDetail.Courses.Add(new MaterialListBoxItem(courseDetails[0], courseDetails[1]));
                            });

                            break;
                        }
                    }
                }

                window.panel.Controls.Add(studentDetail);

                window.ShowDialog();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ParentForm is Form1 mainForm)
            {
                mainForm.ShowControl(new AddStudentControl());
            }
        }
    }
}
