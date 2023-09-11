using FirstWebApiApplication.Models.Domain;
using FirstWebApiApplication.Models.DTO;
using FirstWebApiApplication.Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FirstWebApiApplication.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        [HttpPost("~/login")]
        public IActionResult Login(User inputRequest)
        {
            try
            {
                var serviceObj = new LoginUser();

                return Ok(serviceObj.UserLogin(inputRequest));
            }
            catch (Exception ex)
            {

                return Unauthorized(new Response()
                {
                    StatusCode = HttpStatusCode.Unauthorized,
                    Message = ex.Message
                });
            }

        }

        [HttpPost("~/signup")]
        public IActionResult GenericAddUserDetails(UserDTO inputRequest)
        {
            try
            {
                var serviceObj = new UserService();

                return Ok(serviceObj.GetUserDetails(inputRequest));
            }
            catch (Exception ex)
            {

                return BadRequest(new Response()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Message = ex.Message
                });
            }

        }
    }
}
