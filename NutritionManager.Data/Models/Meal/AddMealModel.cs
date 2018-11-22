using System.Collections.Generic;

namespace NutritionManager.Data.Models.Meal
{
    public class AddMealModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IList<Entities.Product> Products { get; set; }
    }
}
