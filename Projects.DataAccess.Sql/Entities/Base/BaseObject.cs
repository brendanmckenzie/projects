using Projects.DataAccess.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Projects.DataAccess.Sql.Entities.Base
{
    internal class BaseObject : IBaseObject
    {
        public int Id { get; set; }
    }
}