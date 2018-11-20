using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace NutritionManager.Data.Entities
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public long? FacebookId { get; set; }
        public string PictureUrl { get; set; }

    }
}
