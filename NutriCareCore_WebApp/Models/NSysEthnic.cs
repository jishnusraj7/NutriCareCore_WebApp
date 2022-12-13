using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NutriCareCore_WebApp.Models
{
    public class NSysEthnic
    {
        [Key]
        public int EthnicID { get; set; }
        [Required]
        [DisplayName("Ethnic Name")]
        public string EthnicName { get; set; }
    }
}
