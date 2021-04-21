using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";
            int suma = 2 + 3;

            ViewBag.Message = "La suma es: " + suma;

            return View();
        }

        public ActionResult Discos()
        {
            ViewBag.Message = "Mis discos...";
            return View();
        }
        public ActionResult Libros()
        {
            ViewBag.Message = "Mis libros...";
            return View();
        }
        [HttpPost]
        public ActionResult Libros(Libros libros)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DAL.Libros sbd = new DAL.Libros();
                    if (sbd.AgregarLibros(libros))
                    {
                        ViewBag.Message = "Título del libro: " + libros.Titulo;
                        //Limpiamos el modelo
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                ViewBag.Message = "Error al registrar el libro";
                return View();
            }
        }
    }
}