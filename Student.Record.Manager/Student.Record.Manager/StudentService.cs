using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Student.Record.Manager
{
    public class StudentService
    {
        private readonly List<StudentDataModel> _students;

        public StudentService()
        {
            _students = new List<StudentDataModel>();
        }

        public ValidationResponse AddStudent(List<StudentDataModel> student)
        {
            var validationResult = student[0].ValidateStudent();

            if (validationResult.IsValid is false)
            {
                return validationResult;
            }

            try
            {
                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "students.json");
                var students = GetStudents();
                students.Add(student[0]);

                var json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
                using var streamWriter = new StreamWriter(filePath, new FileStreamOptions 
                {
                    Mode = FileMode.Create,
                    Access = FileAccess.Write,
                    Options = FileOptions.None
                });

                streamWriter.Write(json);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding student to file " + ex.Message);
            }

            return validationResult;
        }

        public StudentDataModel? GetStudent(Guid id)
        {
            var student = _students.FirstOrDefault(x => x.Id.Equals(id));

            return student;
        }

        public List<StudentDataModel> LoadStudents()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "students.json");

            if (File.Exists(filePath))
            {
                var jsonString = File.ReadAllText(filePath);

                var students = JsonSerializer.Deserialize<List<StudentDataModel>>(jsonString);

                _students.Clear();
                students?.ForEach(student => _students.Add(student));
            }

            return _students;
        }

        public List<StudentDataModel> GetStudents() => LoadStudents();
    }

    public static class ValidationExtensions
    {
        public static ValidationResponse ValidateStudent(this StudentDataModel student)
        {
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(student);
            bool isValid = Validator.TryValidateObject(student, context, validationResults, true);

            return new ValidationResponse
            {
                IsValid = isValid,
                Errors = validationResults.ToDictionary(key => 
                    key.ErrorMessage.Split(" ")[0],
                    value => value.ErrorMessage)
            };
        }
    }

    public class ValidationResponse
    {
        public bool IsValid { get; set; }
        public Dictionary<string, string?> Errors { get; set; } = [];
    }
}

