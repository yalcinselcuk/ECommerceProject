using ECommerceProject.DTO.Requests;
using ECommerceProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace ECommerceProject.API.Controllers
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

        [HttpGet("[action]")]
        public IActionResult GetAllUser()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetUserById(int id) 
        {
            var user = _userService.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserRequest request)
        {
            if (ModelState.IsValid)
            {
                var userMail = await _userService.UserMailIsExitsAsync(request);
                if (userMail)
                {
                    return BadRequest("User with the same email already exists.");
                }
                // Model geçerli ise, gelen veriyi işlemek için devam edin
                _userService.CreateUserAsync(request);
                return Ok($"User created successfully. \n {request.ToJson()}");
            }
            // Model geçersiz ise hata mesajlarıyla birlikte BadRequest cevabı döndür
            return BadRequest(ModelState);
        }
    }
}
