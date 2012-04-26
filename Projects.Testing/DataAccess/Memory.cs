using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Projects.DataAccess;
using Projects.DataAccess.Memory;

namespace Projects.Testing.DataAccess
{
    [TestClass]
    public class Memory
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
            const int id = 0;

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
            const int id = 1;

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
            const int id = 2;

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

        [TestMethod()]
        public void UpdateProject()
        {
            const int id = 3;
            const string nameBefore = "PROJECT TEST";
            const string nameAfter = "TEST PROJECT";

            var projectA = unitOfWork.Projects.Create();
            projectA.Id = id;
            projectA.Name = nameBefore;

            unitOfWork.Projects.Add(projectA);
            unitOfWork.Commit();

            var projectB = unitOfWork.Projects.FindById(id);
            Assert.AreEqual(projectB.Name, projectA.Name);
            projectB.Name = nameAfter;
            unitOfWork.Commit();

            var projectC = unitOfWork.Projects.FindById(id);
            Assert.AreEqual(projectC.Name, projectB.Name);
        }
    }
}
