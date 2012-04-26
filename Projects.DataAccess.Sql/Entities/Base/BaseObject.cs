using Projects.DataAccess.Entities.Base;

namespace Projects.DataAccess.Sql.Entities.Base
{
    internal class BaseObject : IBaseObject
    {
        public int Id { get; set; }
    }
}