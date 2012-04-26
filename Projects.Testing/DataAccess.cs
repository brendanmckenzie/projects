using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Projects.DataAccess;
using Projects.DataAccess.Memory;

namespace Projects.Testing
{
    [TestClass]
    public class DataAccess
    {
        IUnitOfWork unitOfWork;

        [TestInitialize()]
        public void Initialise()
        {
            unitOfWork = new UnitOfWork();
        }

        [TestMethod]
        public void CreateProject()
        {
            var id = 0;

            var before = unitOfWork.Projects.Count();
            var project = unitOfWork.Projects.Create();
            project.Id = id;
            project.Name = "Test project";

            unitOfWork.Projects.Add(project);

            unitOfWork.Commit();

            Assert.AreEqual<long>(before + 1, unitOfWork.Projects.Count());
        }

        [TestMethod()]
        public void FindProjectById()
        {
            var id = 1;

            var project = unitOfWork.Projects.Create();
            project.Id = id;
            project.Name = "Test project";

            unitOfWork.Projects.Add(project);

            unitOfWork.Commit();

            var found = unitOfWork.Projects.FindById(id);

            Assert.AreEqual(project, found);
        }

        [TestMethod()]
        public void DeleteProject()
        {
            var id = 2;

            var before = unitOfWork.Projects.Count();
            var project = unitOfWork.Projects.Create();
            project.Id = id;
            project.Name = "Test project";

            unitOfWork.Projects.Add(project);

            unitOfWork.Commit();

            var found = unitOfWork.Projects.FindById(id);

            unitOfWork.Projects.Remove(found);

            Assert.AreEqual(before, unitOfWork.Projects.Count());
        }
    }
}
