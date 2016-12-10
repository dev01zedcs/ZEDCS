using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZEDCS.Web.Admin.Controllers
{
    [RoutePrefix("disciplines")]
    public class disciplinesController : Controller
    {
        [Route]
        // GET: disciplines
        public ActionResult Index()
        {
            return View();
        }

        [Route("discipline/{id=0}")]
        public ActionResult discipline(int id)
        {
            return View();
        }
    }
}