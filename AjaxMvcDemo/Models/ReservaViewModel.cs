using System;
using System.Security.AccessControl;

namespace AjaxMvcDemo.Models
{
    public class ReservaViewModel
    {
        public String Nombre { get; set; }
        public int NumPersonas { get; set; }
        public String Fecha { get; set; }
        public int NumReserva { get; set; }
        public String Estado { get; set; }
    }
}