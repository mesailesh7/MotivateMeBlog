
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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


//This will tell Entity framework that Post has a relationship with Category
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        //This will have 1 to many relationship with comments
        public ICollection<Comment> Comments { get; set; }

    }
}