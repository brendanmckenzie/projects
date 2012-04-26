using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using Projects.DataAccess.Entities;
using Projects.DataAccess.Repositories;

using Projects.DataAccess.Memory.Entities;
using Projects.DataAccess.Memory.Repositories.Base;

namespace Projects.DataAccess.Memory.Repositories
{
    internal class ProjectRepository : BaseRepository<IProject, Project>, IProjectRepository
    {
        public ProjectRepository(Context context)
            : base(context)
        {
        }
    }
}