using Microsoft.AspNetCore.Mvc;
using NutritionManager.Data.Repositories;
using System.Threading.Tasks;

namespace NutritionManager.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class DashboardController : Controller
    {
        private readonly IUsersRepository _users;
        public DashboardController(IUsersRepository users)
        {
            _users = users;
        }

        //GET api/dashboard/users
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> Users()
        {
           // var users = await _users.GetUsers();
            return new OkObjectResult(_users.GetUsers());
        }
    }
}
