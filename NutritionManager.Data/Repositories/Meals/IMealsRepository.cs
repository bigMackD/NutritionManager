using NutritionManager.Data.Models.Meal;
using System.Collections.Generic;

namespace NutritionManager.Data.Repositories.Meals
{
    public interface IMealsRepository
    {
        IList<MealModel> GetMeals();
        MealModel GetMeal(int id);
   
        void Add(AddMealModel user);
        void Delete(long id);
        void Update(EditMealModel user);
    }
}
