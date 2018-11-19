using System.Collections.Generic;

namespace NutritionManager.Data.Entities
{
    public class Meal
    {
        public long Id { get; set; }
        public string Name { get; set; }

        IList<Product> Products { get; set; }
       
    }
}
