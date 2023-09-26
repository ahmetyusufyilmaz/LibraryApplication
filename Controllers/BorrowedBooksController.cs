using Microsoft.AspNetCore.Mvc;

namespace LibraryApplication.Controllers
{
    public class BorrowedBooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
