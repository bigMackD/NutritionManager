﻿using System;
using System.Collections.Generic;
using NutritionManager.Data.Models.Meal;

namespace NutritionManager.Data.Repositories.Meals
{
    public class InMemoryMealsRepository : IMealsRepository
    {
        public void Add(AddMealModel user)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public MealModel GetMeal(int id)
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
