namespace School.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<StudentCourse> StudentCourses { get; set; } = [];
        public List<TeacherStudent> TeacherStudents { get; set; } = [];
        public List<Score> Scores { get; set; } = [];


    }
}
