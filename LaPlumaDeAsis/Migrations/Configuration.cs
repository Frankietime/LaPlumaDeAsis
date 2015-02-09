namespace LaPlumaDeAsis.Migrations
{
    using LaPlumaDeAsis.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LaPlumaDeAsis.Models.LaPlumaDeAsisDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LaPlumaDeAsis.Models.LaPlumaDeAsisDb context)
        {
            context.Cuchillos.AddOrUpdate(c => c.Nombre,
                new Cuchillo { Nombre = "Pluma alfa", Antiguo = false, Reciclado = true, MaterialCabo = "marfil", MaterialBoton = "plata" },
                new Cuchillo { Nombre = "Pluma beta", Antiguo = false, Reciclado = true, MaterialCabo = "ebano", MaterialBoton = "plata" },
                new Cuchillo { Nombre = "Pluma gamma", Antiguo = false, Reciclado = false, MaterialCabo = "guampa", MaterialBoton = "alpaca"}
            );
            context.Lamparas.AddOrUpdate(l => l.Nombre,
                new Lampara { Nombre = "Lampara alfa", Antiguo = true, Antiguedad = 18, Reciclado = false  }
            );
        }
    }
}
