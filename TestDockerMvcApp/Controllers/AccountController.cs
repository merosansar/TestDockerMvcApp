using Microsoft.AspNetCore.Mvc;
using TestDockerMvcApp.Data;
using TestDockerMvcApp.Models;

namespace TestDockerMvcApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User model)
        {
            _context.Add(model);
            _context.SaveChanges();
            return View();
        }


    }
}
