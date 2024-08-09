using Application.bookshelf.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.bookshelf.Applications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService ;
        }

        [Route("api/Login")]
        [HttpGet]

        public async Task<IActionResult> Login(string email,string password)
            {
            var userstore = await _userService.GetUserbyUserNameAndPassword(email,password);
            if (userstore == null)
            { 
            
            return BadRequest();  
            
            }
            else 
            {
                return Ok(userstore);
            }


            }
        




    }
}
