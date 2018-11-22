using NutritionManager.Data.Entities;
using NutritionManager.Data.Models.Meal;
using NutritionManager.Data.Models.User;
using System.Collections.Generic;
using System.Linq;

namespace NutritionManager.Data.Repositories
{
    public class InMemoryUsersRepository : IUsersRepository
    {
        private readonly static IList<User> _users = new List<User>()
        {
            new User()
            {
                Id = 1,
                Identity = new AppUser()
                {
                    FirstName = "Maciej",
                    LastName = "Drozdowicz",
                    PictureUrl = "MockedPhotoUrl"
                },        
                Height = 175,
                Weight = 78,
                RequiedCalories = 3000,
                MealsConsumed = new List<Meal>()
                {
                    new Meal()
                    {
                        Id = 1,
                        Name = "Breakfast",
                        Products = new List<Product>()
                        {
                            new Product()
                            {
                                Id = 1,
                                Name = "Cereals",
                                NutritionValue = new NutritionValues()
                                {
                                    Id = 1,
                                    AmountOfProteins = 3,
                                    AmountOfCarbs = 80,
                                    AmountOfFats = 1,
                                    Calories = 140
                                }
                            },
                             new Product()
                            {
                                Id = 2,
                                Name = "Milk",
                                NutritionValue = new NutritionValues()
                                {
                                    Id = 2,
                                    AmountOfProteins = 12,
                                    AmountOfCarbs = 10,
                                    AmountOfFats = 5,
                                    Calories = 240
                                }
                            }
                        }
                    }
                }
            }
        };

        public UserModel AddAppUser(AppUser identity)
        {
            _users.Add(new User
            {
                Identity = identity,
                IdentityId = identity.Id,
                Height = null,
                Weight = null,
                MealsConsumed = null,
                RequiedCalories = null
            });
            return new UserModel()
            {
                Identity = identity,
                IdentityId = identity.Id,
                ConsumedCalories = null,
                Height = null,
                Weight = null,
                MealsConsumed = null,
                RequiedCalories = null
            };
        }

        public void Delete(long id)
        {
            var userToBeRemoved = _users.SingleOrDefault(x => x.Id == id);
            _users.Remove(userToBeRemoved);
        }

        public UserModel GetUser(long id)
        {
            var user = _users.SingleOrDefault(x => x.Id == id);

            return new UserModel()
            {
                Id = user.Id,
                IdentityId = user.IdentityId,
                Identity = user.Identity,
                Weight = user.Weight,
                Height = user.Height,
                RequiedCalories = user.RequiedCalories,
                ConsumedCalories = user.ConsumedCalories,
                MealsConsumed = user.MealsConsumed
            };
        }

        public IList<UserModel> GetUsers()
        {
            return _users.Select(user => new UserModel
            {
                Id = user.Id,
                IdentityId = user.IdentityId,
                Identity = user.Identity,
                Height = user.Height,
                Weight = user.Weight,
                RequiedCalories = user.RequiedCalories,
                MealsConsumed = user.MealsConsumed,
                ConsumedCalories = user.ConsumedCalories
            }).ToList();
           
        }

        public void LogMeal(MealModel mealToBeLogged, long id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            user.MealsConsumed.Add(new Meal
            {
                Id = mealToBeLogged.Id,
                Name = mealToBeLogged.Name,
                Products = mealToBeLogged.Products
            });
        }

        public void UpdateUserDetails(EditUserModel user, long id)
        {
            var userToBeUpdated = GetUser(id);

            userToBeUpdated.Id = user.Id;
            userToBeUpdated.Weight = user.Weight;
            userToBeUpdated.Height = user.Height;
            userToBeUpdated.RequiedCalories = user.RequiedCalories;
        }
    }
}
