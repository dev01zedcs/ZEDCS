using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZEDCS.Web.Admin.Controllers
{
    [RoutePrefix("questions")]
    public class questionsController : Controller
    {
        // GET: questions
        [Route]
        public ActionResult Index()
        {
            return View();
        }

        [Route("question/{id=0}")]
        public ActionResult question(int id)
        {
            return View();
        }
    }
}