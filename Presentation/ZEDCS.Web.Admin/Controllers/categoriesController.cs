using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZEDCS.Web.Admin.Controllers
{
    [RoutePrefix("categories")]
    public class categoriesController : Controller
    {
        // GET: categories
        [Route]
        public ActionResult Index()
        {
            return View();
        }
        [Route("category/{id=0}")]
        public ActionResult category(int id)
        {
            return View();
        }
    }
}