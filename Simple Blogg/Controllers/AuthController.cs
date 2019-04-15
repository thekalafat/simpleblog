using Simple_Blogg.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Simple_Blogg.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
      
        [HttpPost]
        public ActionResult Login(AuthLogin Form,string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(Form);
            }
            FormsAuthentication.SetAuthCookie(Form.Username, true);

            if (!string.IsNullOrWhiteSpace(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
                return RedirectToRoute("home");
        }
        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
        }
    }
}
 