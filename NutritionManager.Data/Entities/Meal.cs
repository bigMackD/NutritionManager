using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NutritionManager.Data.Entities
{
    public class Meal
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }

        IList<Product> Products { get; set; }
       
    }
}
