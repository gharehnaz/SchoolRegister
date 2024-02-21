namespace School.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class CourseViewModel
    {
        public int Id { get; set; }
        public string CourseName { get; set; } 

        public string StudentName { get; set; }
    }

}
