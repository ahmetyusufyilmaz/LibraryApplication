using LibraryApplication.Contexts;
using LibraryApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApplication.Controllers
{
    public class BooksController : Controller
    {
        private readonly LibraryDbContext _context;

        public BooksController(LibraryDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var books = await _context.Books.OrderBy(b => b.Name).ToListAsync();
            return View(books);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Author,Image")] Book book, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (image != null && image.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        image.CopyTo(memoryStream);
                        book.Image = memoryStream.ToArray();
                    }
                }

                _context.Add(book);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        public IActionResult CreateBorrower(Guid bookId)
        {
            return RedirectToAction("Create", "Borrowers", new { bookId });
        }
        public async Task<IActionResult> Details(Guid id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(c => c.Id == id);
            return View(book);
        }

    }



}

