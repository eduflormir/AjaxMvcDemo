using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxMvcDemo.Models;

namespace AjaxMvcDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ObtenerReserva(String nombre, int numPersonas, String fecha)
        {
            

            if (!string.IsNullOrWhiteSpace(nombre))
            {
                var numReserva = Convert.ToDateTime(fecha).Day + DateTime.Now.Second;
                ReservaViewModel reserva = new ReservaViewModel();
                reserva.Nombre = nombre;
                reserva.NumPersonas = numPersonas;
                reserva.Fecha = fecha;
                reserva.NumReserva = numReserva;
                reserva.Estado = "Confirmada";
                
                return PartialView("Reserva", reserva);
            }
            
            return PartialView("ReservaAnonima");

            //String cadena = $"Nombre: {nombre} Numero: {numPersonas} Fecha: {fecha}";
            //return Content(cadena);
        }
    }
}