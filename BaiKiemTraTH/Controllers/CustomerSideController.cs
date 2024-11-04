using BaiKiemTraTH.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTraTH.Controllers
{
    public class CustomerSideController : Controller
    {
        private readonly BookManageContext db = new BookManageContext();
        public IActionResult Index()
        {
            var list = db.Books.ToList();
            return View(list);
        }
    }
}
