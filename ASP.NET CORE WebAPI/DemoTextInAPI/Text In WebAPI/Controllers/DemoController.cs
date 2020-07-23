using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TextInWebAPI.Controllers
{
    [Route("api/demo")]
    public class DemoController : Controller
    {
        [Produces("text/plain")]
        [HttpGet("demo1")]
        public async Task<IActionResult> Demo1()
        {
            try
            {
                string result = "Hello world";
                return Ok(result);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
