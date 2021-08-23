using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShoppingCart.Models;
using System.Threading.Tasks;

namespace ShoppingCart.Controllers
{
    public class BooksController : Controller
    {
        private readonly ILogger<BooksController> _logger;
        private readonly ApplicationDBContext _db;

        public BooksController(ILogger<BooksController> logger,
                              ApplicationDBContext db)
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

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Books bookInfo)
        {
            if (ModelState.IsValid)
            {
                await _db.Books.AddAsync(bookInfo);
                await _db.SaveChangesAsync();
                return RedirectToAction("GetBook");
            }
            return View();
        }
    }
}