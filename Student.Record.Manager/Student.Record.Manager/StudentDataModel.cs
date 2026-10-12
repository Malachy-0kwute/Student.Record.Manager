using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace Student.Record.Manager
{
    public class StudentDataModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(20, ErrorMessage = "First name cannot exceed 20 characters.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(20, ErrorMessage = "Last name cannot exceed 20 characters.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Email address is invalid.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(150, ErrorMessage = "Address cannot exceed 150 characters.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Phone number is invalid.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [IntegerValidator(MinValue = 0, MaxValue = 4)]
        public double Gpa { get; set; }

        [IntegerValidator(MinValue = 0, MaxValue = 100)]
        public int Credits { get; set; }

        [Required(ErrorMessage = "Admission date is required.")]
        public string AdmissionDate { get; set; } = string.Empty;

        public List<string> EnrolledCourses { get; set; } = new List<string>();

        public bool IsActive { get; set; }
    }
}
