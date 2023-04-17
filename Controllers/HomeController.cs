using Microsoft.AspNetCore.Mvc;

namespace FirstBackTask.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Detail()
        {
            return View();
        }

        public ViewResult About(int id)
        {
            return View(id);
        }
    }
}
