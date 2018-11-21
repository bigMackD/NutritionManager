using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace NutritionManager.Data.Entities
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string IdentityId { get; set; }
        public AppUser Identity { get; set; }

        [Required]
        public int? Weight { get; set; }
        [Required]
        public int? Height { get; set; }

        [Required]
        public int? RequiedCalories { get; set; }
        public int? ConsumedCalories {
            get
            {
                return MealsConsumed
                    .Sum(meal => meal.Products
                        .Sum(product => product.NutritionValue.Calories));
            }
        }

        public IList<Meal> MealsConsumed { get; set; }
    }
}
