using AIMLDurban.Models;
using Faker;

class UniversityService{
    List <Student> students = new List<Student>();
    List <Department> departments = new List<Department>();
    List <Course> courses = new List<Course>();
    List <Enrollment> enrollments = new List<Enrollment>();
    List <Grade> grades = new List<Grade>();

    // ctor
    public UniversityService()
    {
        for (int i = 0; i < 10; i++)
        {
            students.Add(new Student
            {
                StudentID = i,
                FirstName = Name.First(),
                LastName = Name.Last(),
                Email = Internet.Email(),
                Enrollments = new List<Enrollment>()
            });
        }

        for (int i = 0; i < 5; i++)
        {
            courses.Add(new Course
            {
                CourseID = i,
                CourseName = Lorem.Words(1).First(),
                Department = "Computer Science",
                Credits = 3,
                Enrollments = new List<Enrollment>()
            });
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                enrollments.Add(new Enrollment
                {
                    EnrollmentID = i * 5 + j,
                    StudentID = i,
                    CourseID = j,
                    Semester = "Spring",
                    Year = 2021,
                    Student = students[i],
                    Course = courses[j]
                });
            }
        }

        for (int i = 0; i < 50; i++)
        {
            grades.Add(new Grade
            {
                GradeID = i,
                EnrollmentID = i,
                GradeValue = RandomNumber.Next(0, 100),
                Enrollment = enrollments[i]
            });
        }
    }
}