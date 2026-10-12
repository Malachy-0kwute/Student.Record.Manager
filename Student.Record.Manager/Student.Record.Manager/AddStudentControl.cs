using MaterialSkin.Controls;

namespace Student.Record.Manager
{
    public partial class AddStudentControl : UserControl
    {
        private StudentService _studentService;

        public AddStudentControl()
        {
            InitializeComponent();

            _studentService = new StudentService();

            courses.Items.Add("CS 101: Introduction to Computer Science — Explores foundational computing principles, algorithmic thinking, and basic coding syntax.");
            courses.Items.Add("CS 305: Web Development — Teaches full-stack design patterns using modern web front-ends and server infrastructure.");
            courses.Items.Add("MATH 151: Calculus I — Focuses on the mathematics of change through limits, derivatives, and basic integration.");
            courses.Items.Add("STAT 210: Introductory Statistics — Covers data collection, quantitative evaluation methods, and standard probability theory models.");
            courses.Items.Add("ECON 201: Microeconomics — Analyzes individual consumer behavior and business decision-making under resource constraints.");
            courses.Items.Add("MKTG 301: Principles of Marketing — Introduces strategies for product positioning, consumer research, and digital campaign design.");
            courses.Items.Add("ACCT 210: Financial Accounting — Teaches standard reporting structures to track, summarize, and communicate corporate financial data.");
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            var creditValue = int.TryParse(credit.Text, out var creditValueResult);

            var student = new List<StudentDataModel>
            {
                new StudentDataModel
                {
                    FirstName = firstName.Text,
                    LastName = lastName.Text,
                    Email = email.Text,
                    Address = address.Text,
                    PhoneNumber = phoneNumber.Text,
                    Credits = creditValueResult,
                    Gpa = double.Parse(gpa.SelectedItem?.ToString() ?? "0.0"),
                    AdmissionDate = admissionDate.Text,
                    IsActive = isActive.Checked
                }
            };

            foreach (var course in courses.Items)
            {
                if (course.Checked)
                {
                    student[0].EnrolledCourses.Add(course.Text);
                }
            }

            try
            {
                var response = _studentService.AddStudent(student);

                if (creditValue is false)
                {
                    response.IsValid = false;
                    response.Errors.Add("Credit", "Only whole numbers are allowed for credits");
                }

                if (response.IsValid)
                {
                    ResetForm();

                    if (ParentForm is Form1 mainForm)
                    {
                        mainForm.ShowControl(new StudentListControl());
                    }
                }
                else
                {
                    DisplayError(response);
                }
            }
            catch (Exception ex)
            {
                if (ParentForm is Form1 mainForm)
                {
                    var window = new DialogBox();
                    window.Owner = mainForm;
                    window.StartPosition = FormStartPosition.CenterParent;
                    window.Text = "Error Message";

                    window.panel.Controls.Add(new Control(ex.Message));

                    window.ShowDialog();
                }
            }
        }

        private void ResetForm()
        {
            firstName.Text = lastName.Text = email.Text = address.Text = phoneNumber.Text = credit.Text = admissionDate.Text = string.Empty;
            isActive.Checked = false;
            gpa.SelectedItem = 0.0;
            courses.Items.ForEach(course => course.Checked = false);

            // Errors
            firstNameError.Text = lastNameError.Text = emailError.Text = phoneError.Text = addressError.Text = admissionError.Text = "error";
            firstNameError.Visible = lastNameError.Visible = emailError.Visible = phoneError.Visible = addressError.Visible = admissionError.Visible = false;
        }

        public void DisplayError(ValidationResponse response)
        {
            firstNameError.Text = ExtractErrorMessage("First", response.Errors);
            firstNameError.Visible = true;

            lastNameError.Text = ExtractErrorMessage("Last", response.Errors);
            lastNameError.Visible = true;

            emailError.Text = ExtractErrorMessage("Email", response.Errors);
            emailError.Visible = true;

            phoneError.Text = ExtractErrorMessage("Phone", response.Errors);
            phoneError.Visible = true;

            addressError.Text = ExtractErrorMessage("Address", response.Errors);
            addressError.Visible = true;

            admissionError.Text = ExtractErrorMessage("Admission", response.Errors);
            admissionError.Visible = true;

            creditError.Text = ExtractErrorMessage("Credit", response.Errors);
            creditError.Visible = true;
        }

        public string ExtractErrorMessage(string key, Dictionary<string, string?> collection)
        {
            var value = collection.ContainsKey(key) ? collection.GetValueOrDefault(key) : string.Empty;

            return value ?? string.Empty;
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            if (ParentForm is Form1 mainForm)
            {
                mainForm.ShowControl(new StudentListControl());
            }
        }
    }
}
