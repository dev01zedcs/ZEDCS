using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZEDCS.Web.Admin.Attributes
{
    public class ZEDCSAuthorize : AuthorizeAttribute
    {
        private readonly AppOperation appOperation = default(AppOperation);
    }
    public enum AppOperation : int
    {


    }
}