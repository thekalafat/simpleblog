using SimpleBlogg.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simple_Blogg.Areas.AdminAreaRegistration.Controllers
{
    [Authorize(Roles = "admin")]
    public class PostsController : Controller
    {
        [SelectedTabAttribute("posts")]

        // GET: AdminAreaRegistration/Posts
        public ActionResult Index()
        {
            return View();
        }
    }
}