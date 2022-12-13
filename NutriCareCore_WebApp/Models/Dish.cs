using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NutriCareCore_WebApp.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Required]
        [DisplayName("Dish Name")]
        public string DishName { get; set; }
        
        [Required]
        [DisplayName("Display Name")]
        public string DisplayName { get; set; }

        [Required]
        public string DisplayImage { get; set; }

        public int EthnicID { get; set; }

 
        public int DishCategoryID { get; set; }

        public int FoodHabitID { get; set; }

        [Required]
        [DisplayName("Display Name")]
        public int DishRemark { get; set; }

    }
}
