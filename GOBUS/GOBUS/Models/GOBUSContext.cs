using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace GOBUS.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class GOBUSContext : DbContext
    {
        public GOBUSContext() : base("GOBUSContext")
        {
           
        }

        public DbSet <Citas> Citas { get; set; }
        public DbSet <Servicios> Servicios { get; set; }
        public DbSet <Sucursales> Sucursales { get; set; }
        public DbSet <Clientes> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}