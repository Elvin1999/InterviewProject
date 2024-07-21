using System.ComponentModel.DataAnnotations;

namespace InterviewProject.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Author is required.")]
        public string? Author { get; set; }

        [Required(ErrorMessage = "Publish date is required.")]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "Content is required.")]
        public string? Content { get; set; }
    }
}
