using System.Collections.Generic;

namespace NutritionManager.Data.Entities
{
    public class User
    {
        public long Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Weight { get; set; }
        public int Height { get; set; }

        public int RequiedCalories { get; set; }
        public int ConsumedCalories { get; set; }

        public IList<Meal> MealsConsumed { get; set; }
    }
}
