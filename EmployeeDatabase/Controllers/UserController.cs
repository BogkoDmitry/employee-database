using EmployeeDatabase.BLL.Interfaces;
using EmployeeDatabase.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyCollection<User>>> GetUsers()
        {
            var result = await _userService.GetUsersAsync();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var result = await _userService.GetUserByIdAsync(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(User user)
        {
            var result = await _userService.CreateUserAsync(user);

            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<User>> Update(int id, User user)
        {
            var result = await _userService.UpdateUserAsync(id, user);


            return result;
        }
    }
}
