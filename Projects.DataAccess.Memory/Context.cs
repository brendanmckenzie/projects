using System.Collections.Generic;

using Projects.DataAccess.Memory.Entities;

namespace Projects.DataAccess.Memory
{
    internal class Context
    {
        public List<Project> Projects { get; set; }

        public IList<T> Set<T>()
        {
            if (typeof(T) == typeof(Project))
            {
                return (IList<T>)Projects;
            }

            return null;
        }

        public Context()
        {
            Projects = new List<Project>();
        }
    }
}