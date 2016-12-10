using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZEDCS.Web.Admin.Controllers
{
    [RoutePrefix("makeinindia")]
    public class makeinindiaController : Controller
    {
        // GET: makeinindia
        [Route]
        public ActionResult Index()
        {
            return View("makeinindia");
        }

        [Route("addedit/{id=0}")]
        public ActionResult AddOrEdit(int id)
        {
            return View("addedit");
        }
    }
}