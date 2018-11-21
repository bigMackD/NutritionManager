using NutritionManager.Data.Entities;
using NutritionManager.Data.Models.Meal;
using NutritionManager.Data.Models.User;
using System.Collections.Generic;

namespace NutritionManager.Data.Repositories
{
    public interface IUsersRepository
    {
        IList<UserModel> GetUsers();
        UserModel GetUser(long id);

        void AddUserDetails(long id, UserModel detailedUserModel);
        UserModel AddAppUser(AppUser identity);
        void Delete(long id);
        void Update(EditUserModel user, long id);

        void LogMeal(MealModel mealToBeLogged, long id);
    }
}
