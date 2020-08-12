using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SisPlaPractica.BLL2;

namespace SisPlaPractica.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public IActionResult Get(string email,string clave)
        {
            try
            {
                return Ok(SisPlaBs.ObtenerUsuario(email, clave));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
