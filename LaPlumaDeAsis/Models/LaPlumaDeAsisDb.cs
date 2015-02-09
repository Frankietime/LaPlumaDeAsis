using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LaPlumaDeAsis.Models
{
    public class LaPlumaDeAsisDb : DbContext 
    {
        public LaPlumaDeAsisDb() : base("name=DefaultConnection")
        {

        }
        public DbSet<Cuchillo> Cuchillos { get; set; }
        public DbSet<Lampara> Lamparas { get; set; }
    }
}