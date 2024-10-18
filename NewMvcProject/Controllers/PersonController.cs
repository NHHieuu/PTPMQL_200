using Microsoft.AspNetCore.Mvc;
namespace NewMvcProject.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index(){
            return View();
        }
    }
}