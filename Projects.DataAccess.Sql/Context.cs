﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using Projects.DataAccess.Sql.Entities;

namespace Projects.DataAccess.Sql
{
    internal class Context : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        public Context(bool createDatabase = false, string connectionString = null)
            : base(connectionString)
        {
            if (createDatabase)
            {
                Database.SetInitializer<Context>(new DropCreateDatabaseAlways<Context>());
                Database.Initialize(true);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}