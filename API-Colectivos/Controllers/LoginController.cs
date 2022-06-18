using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Colectivos.Domain.IServices;
using API_Colectivos.Domain.Models;
using API_Colectivos.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Colectivos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            try
            {
                user.Password = Utilities.EncrpytPassword(user.Password);
                var usr = await _loginService.ValidateUser(user);
                if (usr == null)
                {
                    return BadRequest(new { message = "Usuario o contraseña inválida" });
                }
                //string tokenString = JwtConfigurator.GetToken(usr, _config);
                return Ok(new { usuario = usr.NameUser });
                //return Ok(new { token = tokenString });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
