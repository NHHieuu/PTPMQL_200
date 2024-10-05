
using System;
using System.Net;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;
namespace MvcProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public  IActionResult Demo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(String HovaTen, string Address)
        {
            String strOutput ="Xin chào" + HovaTen + "đến từ" + Address;
            ViewBag.Message=strOutput;
            return View();
        }

    }
}