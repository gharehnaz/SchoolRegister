namespace School.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        //public List<Book> Books { get; set; }
        public List<StudentCourse> StudentCourses { get; set; } = [];
        public List<TeacherCourse> TeacherCourses { get; set; } = [];
        public List<Score> Scores { get; set; } = [];
    }
}
