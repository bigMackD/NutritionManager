using NutritionManager.Data.Entities;
using NutritionManager.Data.Models.User;
using System.Collections.Generic;

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

        public void Add(AddUserModel user)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public UserModel GetUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<User> GetUsers()
        {
            return _users;
        }

        public void Update(EditUserModel user)
        {
            throw new System.NotImplementedException();
        }
    }
}
