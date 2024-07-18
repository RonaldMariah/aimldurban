using System.ComponentModel.DataAnnotations;

namespace AIMLDurban.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }

        [Required]
        [StringLength(50)]
        public required string DepartmentName { get; set; }

        [Required]
        [StringLength(50)]
        public required string HeadOfDepartment { get; set; }

        public required ICollection<Course> Courses { get; set; }
    }
}