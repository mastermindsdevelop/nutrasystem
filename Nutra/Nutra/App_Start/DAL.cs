using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Nutra.Models;

namespace Nutra.DAL
{
    public class nutracon : DbContext
    {
        public nutracon()
            : base("nutracon")
        {

        }
        public DbSet<sube> sube { get; set; }
        public DbSet<nereden> nereden { get; set; }
        public DbSet<iletisim> iletisim { get; set; }
        public DbSet<login> login { get; set; }
    }
}