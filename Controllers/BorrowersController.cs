using LibraryApplication.Contexts;
using LibraryApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApplication.Controllers
{
    public class BorrowersController : Controller
    {
        private readonly LibraryDbContext _context;

        public BorrowersController(LibraryDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var borrowers = await _context.Borrowers.ToListAsync();
            return View(borrowers);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

      



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Borrower borrower, Guid bookId)
        {
            if (ModelState.IsValid)
            {
                _context.Add(borrower);
                _context.SaveChanges();
                return RedirectToAction("Create", "BorrowedBooks", new { bookId, borrowerId = borrower.Id });
            }
            return View(borrower);
        }


    }
}
