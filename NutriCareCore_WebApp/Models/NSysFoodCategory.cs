using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NutriCareCore_WebApp.Models
{
    public class NSysFoodCategory
    {
        [Key]
        public int FoodCategoryID { get; set; }
        [Required]
        [DisplayName("Food Category")]
        public string FoodCategoryName { get; set; }
    }
}
