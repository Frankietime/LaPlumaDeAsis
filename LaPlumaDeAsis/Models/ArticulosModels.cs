using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaPlumaDeAsis.Models
{
    public class Cuchillo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Clase { get; set; }
        public string HojaTipo { get; set; }
        public string HojaMarca { get; set; }
        public string Descripcion { get; set; }
        public string MaterialCabo { get; set; }
        public string MaterialBoton { get; set; }
        public bool Reciclado { get; set; }
        public bool Antiguo { get; set; }
        public int Antiguedad { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
    }

    public class Lampara
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Materiales { get; set; }
        public bool Reciclado { get; set; }
        public bool Antiguo { get; set; }
        public int Antiguedad { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
    }
}