using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace E_Commerce_Temp_RazorPages.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be Between 1-10")]
        public int DisplayOrder { get; set; }
    }
}
