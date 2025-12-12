using System.ComponentModel.DataAnnotations;

namespace MotivateMe.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "User Name is Required")]
        [MaxLength(100, ErrorMessage = "User Name cannot exceed 100 Characters")]
        public string UserName { get; set; }

        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Comment Content is Required")]
        public string Content { get; set; }

    }
}
