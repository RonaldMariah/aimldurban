using System.ComponentModel.DataAnnotations;

namespace AIMLDurban.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }

        [Required]
        [StringLength(50)]
        public required string CourseName { get; set; }

        [Required]
        [StringLength(50)]
        public required string Department { get; set; }

        [Required]
        public int Credits { get; set; }

        public required ICollection<Enrollment> Enrollments { get; set; }
    }
}