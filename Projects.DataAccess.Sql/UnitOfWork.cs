﻿using System;

using Projects.DataAccess.Repositories;

namespace Projects.DataAccess.Sql
{
    public class UnitOfWork : IUnitOfWork
    {
        private Context _context;
        private IProjectRepository _projects;

        public UnitOfWork()
        {
            _context = new Context();
            _projects = new Repositories.ProjectRepository(_context);
        }

        public IProjectRepository Projects
        {
            get { return _projects; }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void CreateDatabase()
        {
            _context.CreateDatabase();
        }
    }
}