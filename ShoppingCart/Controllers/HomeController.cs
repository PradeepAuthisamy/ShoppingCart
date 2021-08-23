using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShoppingCart.Models;
using ShoppingCart.Models.Interface;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ShoppingCart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IApplicationDBContext _db;

        public HomeController(ILogger<HomeController> logger,
                              IApplicationDBContext db)
        {
            _logger = logger;
            _db = db;
        }

        public async Task<IActionResult> GetBook()
        {
            var books = await _db.Books.ToListAsync();
            var bookList = new BookList
            {
                Books = books
            };
            return View(bookList);
        }

        public async Task<IActionResult> Create()
        {
            var books = await _db.Books.ToListAsync();
            var bookList = new BookList
            {
                Books = books
            };
            return View(bookList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}