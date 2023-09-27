using LibraryApplication.Contexts;
using LibraryApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApplication.Controllers
{
    public class BorrowedBooksController : Controller
    {
        private readonly LibraryDbContext _context;

        public BorrowedBooksController(LibraryDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var borrowedBooks = await _context.BorrowedBooks.ToListAsync();
            return View(borrowedBooks);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Books = _context.Books.OrderBy(b => b.Name).ToList();

            ViewBag.Borrowers = _context.Borrowers.OrderBy(b => b.FirstName).ToList();

            return View();
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BorrowedBook borrowedBook)
        {
            if (ModelState.IsValid)
            {


                _context.Add(borrowedBook);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(borrowedBook);
        }

    }
}
