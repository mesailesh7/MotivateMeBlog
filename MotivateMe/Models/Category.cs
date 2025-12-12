using System.ComponentModel.DataAnnotations;

namespace MotivateMe.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Category Name is Required")]
        [MaxLength(100, ErrorMessage = "Category Name cannot exceed 100 Characters")]
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
