using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZEDCS.Web.Admin.Controllers
{
    [RoutePrefix("evidences")]
    public class evidencesController : Controller
    {
        // GET: evidences
        [Route]
        public ActionResult Index()
        {
            return View();
        }

        [Route("evidence/{id=0}")]
        public ActionResult evidence(int id)
        {
            return View();
        }
    }
}