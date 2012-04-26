using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using Projects.DataAccess.Entities;
using Projects.DataAccess.Repositories;

using Projects.DataAccess.Sql.Entities;
using Projects.DataAccess.Sql.Repositories.Base;

namespace Projects.DataAccess.Sql.Repositories
{
    internal class ProjectRepository : BaseRepository<IProject, Project>, IProjectRepository
    {
        public ProjectRepository(Context context)
            : base(context)
        {
        }
    }
}