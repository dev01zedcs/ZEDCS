using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZEDCS.Web.Admin.Controllers
{
    [RoutePrefix("users")]
    public class usersController : Controller
    {
        // GET: users
        [Route]
        public ActionResult Index()
        {
            return View();
        }
        [Route("user/{id=0}")]
        public ActionResult user(int id)
        {
            return View();
        }
    }
}