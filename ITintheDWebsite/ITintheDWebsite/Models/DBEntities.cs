using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITintheDWebsite.Models
{
    public class DBEntities : DbContext
    {

        public DbSet<Application> Apps { get; set; }

        public DbSet<Mentor> Mentors { get; set; }


    }
}