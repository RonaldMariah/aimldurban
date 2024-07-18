using System.ComponentModel.DataAnnotations;

namespace AIMLDurban.Models
{
    public class Grade
    {
        [Key]
        public int GradeID { get; set; }

        public int EnrollmentID { get; set; }

        [Required]
        public int GradeValue { get; set; }

        public required Enrollment Enrollment { get; set; }
    }
}