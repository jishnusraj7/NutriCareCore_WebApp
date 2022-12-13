using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NutriCareCore_WebApp.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
        [Required]
        public string DishName { get; set; }
        [Required]
        public string DisplayImage { get; set; }
 
    }
}
