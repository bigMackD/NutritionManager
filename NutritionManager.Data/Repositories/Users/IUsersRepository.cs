using NutritionManager.Data.Models.User;
using System.Collections.Generic;

namespace NutritionManager.Data.Repositories
{
    public interface IUsersRepository
    {
        IList<UserModel> GetUsers();
        UserModel GetUser(int id);

        void Add(AddUserModel user);
        void Delete(long id);
        void Update(EditUserModel user);
    }
}
