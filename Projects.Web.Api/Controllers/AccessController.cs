using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

using Projects.DataAccess;
using Projects.DataAccess.Sql;
using Projects.DataAccess.Entities;

namespace Projects.Web.Api.Controllers
{
    public class AccessController : ApiController
    {
        IUnitOfWork unitOfWork;

        public AccessController()
            : this(new UnitOfWork())
        {
        }

        public AccessController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet()]
        public IEnumerable<IProject> Get()
        {
            return unitOfWork.Projects.FindAll();
        }

        public IProject Get(int id)
        {
            return unitOfWork.Projects.FindById(id);
        }

        public IProject Post(string name, string summary)
        {
            var entity = unitOfWork.Projects.Create();
            entity.Name = name;
            entity.Status = ProjectStatus.Planning;
            entity.Summary = summary;

            unitOfWork.Projects.Add(entity);
            unitOfWork.Commit();

            return entity;
        }

        public IProject Put(int id, string name, string summary, ProjectStatus status)
        {
            var entity = unitOfWork.Projects.FindById(id);
            entity.Name = name;
            entity.Status = status;
            entity.Summary = summary;

            unitOfWork.Commit();

            return entity;
        }

        public void Delete(int id)
        {
            var entity = unitOfWork.Projects.FindById(id);

            unitOfWork.Projects.Remove(entity);

            unitOfWork.Commit();
        }
    }
}