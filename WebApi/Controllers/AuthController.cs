using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Dtos.User;
using WebApi.Models;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("Controller")]
    public class AuthController : ControllerBase
    {
        public AuthController(IAuthRepository authRepository)
        {
            _AuthRepository = authRepository;
        }

        private IAuthRepository _AuthRepository { get; }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _AuthRepository.Register(
                new User { Username = request.Username }, request.Password
                );
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }


        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<int>>> Login(UserRegisterDto request)
        {
            var response = await _AuthRepository.Login(request.Username, request.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
