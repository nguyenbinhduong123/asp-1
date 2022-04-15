using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baitap2_61132767.Controllers
{
    public class SinhVien_61132767Controller : Controller
    {
        // GET: SinhVien_61132767
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register2(FormCollection field)
        {
            ViewBag.Id = field["Id"];
            ViewBag.Name = field["Name"];
            ViewBag.Marks = field["Marks"];
            return View(ViewBag);
        }
    }
}