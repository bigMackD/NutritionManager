using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NutritionManager.Data.Entities
{
    public class Product
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }

        public IList<Meal> Meals { get; set; }
        [Required]
        public NutritionValues NutritionValue{get;set;}

    }
}
