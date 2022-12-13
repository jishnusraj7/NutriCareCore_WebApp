using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NutriCareCore_WebApp.Models
{
    public class NSysFoodHabit
    {
        [Key]
        public int FoodHabitID { get; set; }
        [Required]
        [DisplayName("FoodHabit Name")]
        public string FoodHabitName { get; set; }
        [Required]
        [DisplayName("Food Habit Description")]
        public string FoodHabitDescription { get; set; }
    }
}
