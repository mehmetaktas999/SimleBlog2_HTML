using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog2.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            return Content("Users !");
        }

        public ActionResult List()
        {
            return Content("Liste content i");
        }

        public ActionResult control(int id=0)
        {
            return Content("Kontrolüm = "+id);
        }
    }
}