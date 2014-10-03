using SDP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SDP.DAL
{
    public class SDPContext : DbContext
    {
        public SDPContext() : base("SDPContext")
        {}

        public DbSet<Event> Events {get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
 	         modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<SDP.Models.Activity> Activities { get; set; }  /*vietcode*/
    }
}