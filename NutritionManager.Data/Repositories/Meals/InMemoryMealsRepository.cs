using System;
using System.Collections.Generic;
using NutritionManager.Data.Entities;
using NutritionManager.Data.Models.Meal;
using System.Linq;

namespace NutritionManager.Data.Repositories.Meals
{
    public class InMemoryMealsRepository : IMealsRepository
    {
        private static readonly IList<Meal> _meals = new List<Meal>()
        {
            new Meal
            {
                Id = 1,
                Name = "Chicken with rice",
                Products = new List<Product>
                {
                    new Product
                    {
                        Id = 1,
                        Name = "Chicken",
                        NutritionValue = new NutritionValues
                        {
                            Id = 1,
                            AmountInGrams = 100,
                            AmountOfCarbs = 20,
                            AmountOfFats = 5,
                            AmountOfProteins = 20,
                            Calories = 300,
                        }
                    },
                     new Product
                    {
                        Id = 2,
                        Name = "Rice",
                        NutritionValue = new NutritionValues
                        {
                            Id = 2,
                            AmountInGrams = 120,
                            AmountOfCarbs = 70,
                            AmountOfFats = 2,
                            AmountOfProteins = 9,
                            Calories = 120,
                        }
                    }
                }
            }
        };
        public void Add(AddMealModel mealToBeAdded)
        {
            _meals.Add(new Meal
            {
                Id = mealToBeAdded.Id,
                Name = mealToBeAdded.Name,
                Products = mealToBeAdded.Products
            });
        }

        public void Delete(long id)
        {
            var mealToBeRemoved = _meals.SingleOrDefault(x => x.Id == id);
            _meals.Remove(mealToBeRemoved);
        }

        public MealModel GetMeal(long id)
        {
            var meal = _meals.SingleOrDefault(x => x.Id == id);
            return new MealModel
            {
                Id = meal.Id,
                Name = meal.Name,
                Products = meal.Products
            };
        }

        public IList<MealModel> GetMeals()
        {
            return _meals.Select(x => new MealModel
            {
                Id = x.Id,
                Name = x.Name,
                Products = x.Products
            }).ToList();
        }

        public void Update(EditMealModel user)
        {
            throw new NotImplementedException();
        }
    }
}
