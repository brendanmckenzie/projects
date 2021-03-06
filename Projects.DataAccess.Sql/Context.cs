﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using Projects.DataAccess.Sql.Entities;

namespace Projects.DataAccess.Sql
{
    internal class Context : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        public Context()
            : base()
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
            Database.Initialize(false);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}