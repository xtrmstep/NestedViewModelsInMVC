using System.Web.Mvc;
using NestedViewModelsInMVC.Models;

namespace NestedViewModelsInMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Person person)
        {
            return View(new Person {Name = "Person Name", Addr = {Location = "Person Location"}});
        }
    }
}