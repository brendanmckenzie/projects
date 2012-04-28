using Projects.DataAccess.Entities.Base;

namespace Projects.DataAccess.Entities
{
    public enum ProjectStatus
    {
        Planning,
        Development,
        Testing,
        Release
    }

    public interface IProject : IBaseObject, INamedObject
    {
        ProjectStatus Status { get; set; }
        string Summary { get; set; }
    }
}