using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Web.App.TapaBuraco.Models
{
    public class Contexto : DbContext
    {
        public Contexto() : base("DefaultConnection")
        {

        }
        public DbSet<Buraco> Buraco { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Prefeitura> Prefeitura { get; set; }
        public DbSet<Representante> Representante { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            base.OnModelCreating(modelBuilder);
        }
    }
}