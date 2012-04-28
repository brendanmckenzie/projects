using Projects.DataAccess.Entities;
using Projects.DataAccess.Memory.Entities.Base;

namespace Projects.DataAccess.Memory.Entities
{
    internal class Project : BaseObject, IProject
    {
        public string Name { get; set; }
        public ProjectStatus Status { get; set; }
        public string Summary { get; set; }
    }
}