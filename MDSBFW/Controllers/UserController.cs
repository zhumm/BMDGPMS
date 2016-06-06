using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MDORM.BusinessRepository;
using MDORM.Common;

namespace MDSBFW.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Login()
        {
            string userName = WebHelper.GetParam(Request, "userName");
            string password = WebHelper.GetParam(Request, "pwd");
            return "ok";
        }
    }
}
