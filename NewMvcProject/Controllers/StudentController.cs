using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace NewMvcProject.Controllers
{
    public class StudentController: Controller
    {
        public IActionResult Index()
        { 
            return View();   
        }
        public string Welcome()
        {
            return "action xinchao";   
        }
        [HttpPost]
        public IActionResult Index(string fullName, string Adress)
        {
            string strOutput = "Xin chào" + fullName + "Đến từ" + Adress;
            ViewBag.Message = strOutput;
            return View();
        }
    }
}