using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZEDCS.Web.Admin.Controllers
{
    [RoutePrefix("parameters")]
    public class parametersController : Controller
    {
        // GET: parameters
        [Route]
        public ActionResult Index()
        {
            return View();
        }

        [Route("parameter/{id=0}")]
        public ActionResult parameter(int id)
        {
            return View();
        }
    }
}