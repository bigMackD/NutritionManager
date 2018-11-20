using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NutritionManager.Data.Entities
{
    public class User
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        public int Weight { get; set; }
        [Required]
        public int Height { get; set; }

        [Required]
        public int RequiedCalories { get; set; }
        public int ConsumedCalories { get; set; }

        public IList<Meal> MealsConsumed { get; set; }
    }
}
