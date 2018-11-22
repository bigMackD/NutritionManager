using System;
using System.Collections.Generic;
using NutritionManager.Data.Models.Meal;
using NutritionManager.Data.Services;

namespace NutritionManager.Data.Repositories.Meals
{
    public class SqlMealsRepository : IMealsRepository
    {
        private ApplicationDbContext _context;
        public SqlMealsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(AddMealModel user)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public MealModel GetMeal(long id)
        {
            throw new NotImplementedException();
        }

        public IList<MealModel> GetMeals()
        {
            throw new NotImplementedException();
        }

        public void Update(EditMealModel user)
        {
            throw new NotImplementedException();
        }
    }
}
