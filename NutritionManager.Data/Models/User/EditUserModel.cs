using System.ComponentModel.DataAnnotations;

namespace NutritionManager.Data.Models.User
{
    public class EditUserModel
    {
        [Key]
        public long Id { get; set; }
      
        [Required]
        public int? Weight { get; set; }
        [Required]
        public int? Height { get; set; }

        [Required]
        public int? RequiedCalories { get; set; }
    }
}
