using Microsoft.AspNetCore.Mvc;

namespace MvcProject.Controllers;
public class NguyenHongHieuController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}