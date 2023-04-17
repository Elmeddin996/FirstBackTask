using Microsoft.AspNetCore.Mvc;

namespace FirstBackTask.Controllers
{
  
        public class ProductController : Controller
        {

            //public ContentResult Detail()
            //{
            //    ContentResult result = new ContentResult();
            //    result.Content = "Detail Page";
            //    return result;
            //}

            //public JsonResult Detail()
            //{
            //    JsonResult result = new JsonResult(new{ name="Gulefruz", surename="Hesenquluyev", age=45});
            //    return result;
            //}


            public ViewResult Detail()
            {
                ViewResult result = new ViewResult();
                result.ViewName = "Detail";
                return result;
            }

        //public ViewResult Index()
        //{

        //    return View();
        //}

        public ContentResult Index(int id)
        {
            return Content(id.ToString());
        }

    }
}

