using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simple_Blogg.Areas.AdminAreaRegistration.Controllers
{
    public class PostsController : Controller
    {
        // GET: AdminAreaRegistration/Posts
        public ActionResult Index()
        {
            return Content("posts controller");
        }
    }
}