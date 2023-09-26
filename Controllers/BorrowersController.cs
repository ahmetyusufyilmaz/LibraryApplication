using Microsoft.AspNetCore.Mvc;

namespace LibraryApplication.Controllers
{
    public class BorrowersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
