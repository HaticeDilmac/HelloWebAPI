using HelloWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebAPI.Controllers
{
    //ControllerBase yapısını ekleriz.
    [ApiController]//Api yapısını sdesteklemek için eklendi.
    [Route("home")]//url yolu
    public class CHomeController :ControllerBase
    {
        [HttpGet]
        public  IActionResult GetMessage()
        {
             var result=new ResponseModel
            {
                HttpStatus = 200,
                Message = "Hello biseylergelistiriyorum:)",
            };
            return Ok(result);
        }
    }
}
