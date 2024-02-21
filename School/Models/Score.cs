namespace School.Models
{
    public class Score
    {
        public int Id { get; set; }
        public int value { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        //public List<Book> Books { get; set; }
        //public List<StudentCourse> StudentCourses { get; set; } = [];
        //public List<TeacherCourse> TeacherCourses { get; set; } = [];

    }
}
