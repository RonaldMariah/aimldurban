using System.ComponentModel.DataAnnotations;

namespace AIMLDurban.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }

        public int StudentID { get; set; }

        public int CourseID { get; set; }

        [Required]
        [StringLength(50)]
        public required string Semester { get; set; }

        [Required]
        public int Year { get; set; }

        public required Student Student { get; set; }

        public required Course Course { get; set; }
    }
}