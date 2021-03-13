using Microsoft.AspNetCore.Mvc;

namespace NewTaskManager.Controllers
{
    public class ApiController : Controller
    {
        public ApiController()
        {
            //I'm the constructor
        }

        [HttpGet]
        public IActionResult Test()
        {
            
            string name="MA";
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