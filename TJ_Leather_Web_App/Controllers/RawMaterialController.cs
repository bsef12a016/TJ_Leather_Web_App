using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TJ_Leather_Web_App.Controllers
{
    public class RawMaterialController : Controller
    {
        // GET: RawMaterial
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddRawMaterial()
        {
            return View();
        }


    }
}