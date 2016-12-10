using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZEDCS.Web.Admin.Controllers
{
    [RoutePrefix("sectors")]
    public class sectorsController : Controller
    {
        // GET: sectors
        [Route]
        public ActionResult Index()
        {
            return View();
        }

        [Route("sector/{id=0}")]
        public ActionResult sector(int id)
        {
            return View();
        }
    }
}