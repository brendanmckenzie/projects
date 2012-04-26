using Projects.DataAccess.Entities;
using Projects.DataAccess.Sql.Entities.Base;

namespace Projects.DataAccess.Sql.Entities
{
    internal class Project : BaseObject, IProject
    {
        public string Name { get; set; }
    }
}