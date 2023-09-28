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
                borrowedBook.BookName = _context.Books.Find(borrowedBook.BookId)?.Name;
                borrowedBook.BorrowerName = _context.Borrowers.Find(borrowedBook.BorrowerId)?.FullName;
               
                var book = _context.Books.Find(borrowedBook.BookId);
                if (book != null)
                {
                    book.IsAvailable = false; 
                }

                _context.Add(borrowedBook);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(borrowedBook);
        }

        [HttpPost]
        public IActionResult TakeBack(Guid id)
        {
            var borrowedBook = _context.BorrowedBooks.Find(id);

            if (borrowedBook == null)
            {
                return NotFound();
            }

            var book = _context.Books.Find(borrowedBook.BookId);
            if (book != null)
            {
                book.IsAvailable = true;
            }

           
            _context.SaveChanges();

            return Json(new { success = true });
        }





    }
}
