using System.Dynamic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using NewMvcProject.Models;
using Microsoft.EntityFrameworkCore;
using NewMvcProject.Data;

namespace NewMvcProject.Controllers
{
       public class PersonController : Controller
       {
        private readonly ApplicationDbcontext _context;
        public PersonController(ApplicationDbcontext context)
        {}
        public async Task<IActionResult> Index()
        {}
        public IActionResult Create()
        {}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,fullName,Adress")] Person person);
        public async Task<IActionResult> Edit(String id){}
        [HttpPost] 

       }
}