namespace DemoMVC.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public int ChapterId { get; set; }
        public string ChapterTitle { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public int Order { get; set; }
    }
}