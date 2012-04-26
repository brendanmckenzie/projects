using System.Collections.Generic;

using Projects.DataAccess.Repositories;

namespace Projects.DataAccess
{
    public interface IUnitOfWork
    {
        IProjectRepository Projects { get; }

        void Commit();
    }
}
