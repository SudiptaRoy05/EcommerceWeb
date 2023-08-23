using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        public int DiaplayOrder { get; set; }

        /*public DateTime CreatedDateTime { get; set; } = DateTime.Now;*/

    }
}
