using System.ComponentModel.DataAnnotations;

namespace SimpleProjects.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string ? Name { get; set; }
        public int Display { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
