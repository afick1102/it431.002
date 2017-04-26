using IT431Site.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IT431Site.DAL
{
    public class SiteDataContext1:DbContext
    {
        public DbSet<Widget> Widgets { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public System.Data.Entity.DbSet<IT431Site.Models.Location> Locations { get; set; }
    }
}