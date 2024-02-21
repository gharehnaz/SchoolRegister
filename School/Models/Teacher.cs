namespace School.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<TeacherStudent>? TeacherStudents { get; set; } = [];
        public List<TeacherCourse>? TeacherCourses { get; set; } = [];

    }
}
