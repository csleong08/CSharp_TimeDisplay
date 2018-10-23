using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers     //namespace!
{
    public class HelloController : Controller   //inheritance
    {
        [HttpGet]       
        [Route("")]     
        public IActionResult Index() 
        {
            return View("index");
        }
    }
}