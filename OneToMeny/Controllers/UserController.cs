using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneToMeny.Model;
using OneToMeny.Service;

namespace OneToMeny.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("")]
        public async Task<ActionResult<Users>> AddUser(UserDto userDto)
        {
            Role role = new Role()
            {
                Name = userDto.Role,
                Description = userDto.Description,
            };
            Users users = new Users()
            {
                DateTimeCreate = DateTime.Now,
                email = userDto.email,
                password = userDto.password,
                phone = userDto.phone,
                name = userDto.name,
            };
            users.roles.Add(role);

            var userReturn = _userService.AddUserAsync(users);
            return await userReturn;
        }
    }
}
