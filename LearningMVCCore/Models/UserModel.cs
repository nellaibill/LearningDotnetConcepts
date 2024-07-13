using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LearningMVCCore.Models
{
    public class UserModel
    {
        [Required]
        [StringLength(50,MinimumLength =3)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Country { get; set; }

        public  static List<SelectListItem> GetCountries()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Value = "USA", Text = "United States" },
                new SelectListItem { Value = "CAN", Text = "Canada" },
                new SelectListItem { Value = "UK", Text = "United Kingdom" }
            };
        }
    }
}
