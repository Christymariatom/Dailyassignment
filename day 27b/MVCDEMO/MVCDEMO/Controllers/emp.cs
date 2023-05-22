using Microsoft.AspNetCore.Mvc;

namespace MVCDEMO.Controllers
{
    public class emp : Controller
    {
        public string Display()
        {
            return "HELLO VC Code";
        }
        public string Welcome() 
        {
            return " hello ";   
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
