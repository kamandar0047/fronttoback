using FronttoBack.DAL;
using FronttoBack.Views.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FronttoBack.Controllers
{
    public class HomeController : Controller
    {
        public AppDBContext _context { get; }
        public HomeController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {

            ViewModels viewmodels = new ViewModels
            {
                Slides = await _context.Slides.ToListAsync()
                Introduction=await_context.Introductions.FirstOrDefaultAsync()

        };
            return View(viewmodels);
        }
    }
}
