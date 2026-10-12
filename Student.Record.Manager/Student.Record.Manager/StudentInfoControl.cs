using MaterialSkin;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Student.Record.Manager
{
    public partial class StudentInfoControl : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string FirstName { get => firstName.Text; set => firstName.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string LastName { get => lastName.Text; set => lastName.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Email { get => email.Text; set => email.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Address { get => address.Text; set => address.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string PhoneNumber { get => phoneNumber.Text; set => phoneNumber.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Credits { get => credit.Text; set => credit.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Gpa { get => gpa.Text; set => gpa.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string IsActive { get => isActive.Text; set => isActive.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string AdmissionDate { get => admissionDate.Text; set => admissionDate.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<MaterialListBoxItem> Courses 
        {
            get => courses.Items;
            set
            {
                var items = courses.Items;
                items = value;
            }
        }

        public string[] Data = [];

        public StudentInfoControl()
        {
            InitializeComponent();
        }
    }
}
