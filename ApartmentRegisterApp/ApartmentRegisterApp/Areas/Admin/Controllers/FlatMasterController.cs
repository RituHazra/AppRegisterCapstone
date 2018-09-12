using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApartmentRegisterApp.Areas.Admin.Controllers
{
    public class FlatMasterController : Controller
    {
        // GET: Admin/FlatMaster
        public ActionResult Index()
        {
            return View();
        }
    }
}