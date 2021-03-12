using Microsoft.AspNetCore.Mvc;

namespace taskManager.Controllers
{
    public class ApiController : Controller
    {
        public ApiController()
        {
            //Im the constructor
        }

        [HttpGet]
        public IActionResult Test()
        {
            string name = "Nick";
            return Json(name);
        }
        
        [HttpGet]
        public IActionResult GetTask() 
        {
            return Json(null);
        }
        [HttpPost]
        public IActionResult PostTask()
        {
            return Json(null);
        }

    }

}