using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NutritionManager.Data.Models.User;
using NutritionManager.Data.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NutritionManager.Api.Controllers
{
    [Route("api/[controller]")]
    public class DashboardController : Controller
    {
        private readonly IUsersRepository _users;

        public DashboardController(IUsersRepository users)
        {
            _users = users;
        }

        // GET: api/<controller>
        /// <summary>
        /// Returns all users of app
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = _users.GetUsers();
            return new OkObjectResult(users);

        }

        // GET api/<controller>/5
        /// <summary>
        /// Returns one user with given ID
        /// </summary>
        [HttpGet("{id}")]
        public string Get(long id)
        {
            return "value";
        }

        // PUT api/<controller>/5
        /// <summary>
        /// Updates user with given ID
        /// </summary>
        [HttpPut("{id}")]
        public void UpdateDetails([FromRoute]long id, [FromBody]EditUserModel user)
        {
            _users.UpdateUserDetails(user, id);
        }

        // DELETE api/<controller>/5
        /// <summary>
        /// Deletes user with given ID
        /// </summary>
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _users.Delete(id);
        }
    }
}
