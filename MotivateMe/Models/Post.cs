using System.ComponentModel.DataAnnotations;

namespace MotivateMe.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Title Required")]
        [MaxLength(400, ErrorMessage = "Title cannot exceed 400 Character")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Content Required")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Author Required")]
        [MaxLength(100, ErrorMessage = "Author name cannot exceed 100 Character")]
        public string  Author { get; set; }
        public string FeatureImagePath { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; } = DateTime.Now;
    }
}