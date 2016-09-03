using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo2.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {
            return View();
        }
    }
}
