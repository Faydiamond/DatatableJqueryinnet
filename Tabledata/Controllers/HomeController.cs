using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tabledata.Models;

namespace Tabledata.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostData()
        {
            using (MyDataBaseEntities Bd=new MyDataBaseEntities())
            {
                var Datos = Bd.pacientes.OrderBy(X => X.Nombre).ToList();
                return Json(new { data = Datos }, JsonRequestBehavior.AllowGet);
            }
        }
	}
}