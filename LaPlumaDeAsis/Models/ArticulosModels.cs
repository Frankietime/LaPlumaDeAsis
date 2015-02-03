using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaPlumaDeAsis.Models
{
    public class Cuchillo
    {
        public int CuchilloID { get; set; }
        public string Nombre { get; set; }
        public string Clase { get; set; }
        public string HojaTipo { get; set; }
        public string HojaMarca { get; set; }
        public string Descripcion { get; set; }
        public string MaterialCabo { get; set; }
        public string MaterialBoton { get; set; }
        public bool Reciclado { get; set; }
        public bool Antiguo { get; set; }
        public int AntiguedadDesde { get; set; }
        public int AntiguedadHasta { get; set; }
        public int Precio { get; set; }
    }
}