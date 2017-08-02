using OdeToFood.Filters;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        //[Authorize]
        [Log]
        public ActionResult Search(string name = "french")
        {

            //throw new Exception("teste");

            var message = Server.HtmlEncode(name);
            return Content(message);

            //return RedirectToAction("Index", "Home", new { name = name });
            //return RedirectToRoute("Default", new { controller = "Home", action = "About" });
            //return File(Server.MapPath("~/Content/site.css"), "text/css");
            //return Json(new { Message = message, Name = "Guilherme" }, JsonRequestBehavior.AllowGet);
        }

        //[HttpGet]
        //public ActionResult Search()
        //{
        //    return Content("Search!");
        //}
    }
}