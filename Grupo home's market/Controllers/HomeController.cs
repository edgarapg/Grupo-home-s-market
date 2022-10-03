using Grupo_home_s_market.Models.viewModel;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grupo_home_s_market.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(String nombre="")
        {

            ViewBag.nombre = nombre;
            return View(nombre);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Report()
        {
            List<Reporte_VM> lst = new List<Reporte_VM>();
            lst.Add(new Reporte_VM (){Nombre= "juan", precio = 35, Email ="algo@gmail.com"});
            lst.Add(new Reporte_VM() { Nombre = "juan1", precio = 36, Email = "algo@gmail.com" });
            lst.Add(new Reporte_VM() { Nombre = "juan2", precio = 37, Email = "algo@gmail.com" });
            lst.Add(new Reporte_VM() { Nombre = "juan3", precio = 38, Email = "algo@gmail.com" });
            lst.Add(new Reporte_VM() { Nombre = "juan4", precio = 95, Email = "algo@gmail.com" });
            return View(lst );

        }
        public  ActionResult Print() 
        {

            return new ActionAsPdf("Report")
            { FileName = "Test.pdf" };

        }
    }
}