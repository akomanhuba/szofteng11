using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using szofteng11.Models;

namespace szofteng11.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        [HttpGet]
        [Route("questions/all")]
        public ActionResult M1()
        {
            HajosContext context = new HajosContext();
            var kérdések = from x in context.Questions select x.Question1;

            return Ok(kérdések);
        }
    }
}
