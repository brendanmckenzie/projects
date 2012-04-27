using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Projects.DataAccess;
using Projects.DataAccess.Sql;

namespace Projects.Testing.DataAccess
{
    [TestClass]
    public class Sql
    {
        //[TestMethod]
        public void CreateDatabase()
        {
            UnitOfWork uow = new UnitOfWork();

            uow.CreateDatabase();
        }

        [TestMethod]
        public void CreateProject()
        {
            UnitOfWork unitOfWork = new UnitOfWork();

            var before = unitOfWork.Projects.Count();

            var project = unitOfWork.Projects.Create();
            project.Name = "Test project";
            project.Status = Projects.DataAccess.Entities.ProjectStatus.Development;

            unitOfWork.Projects.Add(project);

            unitOfWork.Commit();

            Assert.AreEqual<long>(before + 1, unitOfWork.Projects.Count());
        }

        [TestMethod()]
        public void FindProjectById()
        {
            UnitOfWork unitOfWork = new UnitOfWork();

            var project = unitOfWork.Projects.Create();
            project.Name = "Test project";

            unitOfWork.Projects.Add(project);

            unitOfWork.Commit();

            var found = unitOfWork.Projects.FindById(project.Id);

            Assert.AreEqual(project, found);
        }

        [TestMethod()]
        public void FindProjectByName()
        {
            UnitOfWork unitOfWork = new UnitOfWork();

            var project = unitOfWork.Projects.Create();
            project.Name = "Lorem ipsum dolor sit amit.";

            unitOfWork.Projects.Add(project);
            unitOfWork.Commit();

            var found = unitOfWork.Projects.FindBy(p => p.Name.Contains("ipsum") && p.Id == project.Id).FirstOrDefault();

            Assert.AreEqual(project, found);
        }

        [TestMethod()]
        public void DeleteProject()
        {
            UnitOfWork unitOfWork = new UnitOfWork();

            var before = unitOfWork.Projects.Count();

            var project = unitOfWork.Projects.Create();
            project.Name = "Test project";

            unitOfWork.Projects.Add(project);

            unitOfWork.Commit();

            var found = unitOfWork.Projects.FindById(project.Id);

            unitOfWork.Projects.Remove(found);
            unitOfWork.Commit();

            Assert.AreEqual(before, unitOfWork.Projects.Count());
        }

        [TestMethod()]
        public void UpdateProject()
        {
            UnitOfWork unitOfWork = new UnitOfWork();

            const string nameBefore = "PROJECT TEST";
            const string nameAfter = "TEST PROJECT";

            var projectA = unitOfWork.Projects.Create();
            projectA.Name = nameBefore;

            unitOfWork.Projects.Add(projectA);
            unitOfWork.Commit();

            var projectB = unitOfWork.Projects.FindById(projectA.Id);
            Assert.AreEqual(projectB.Name, projectA.Name);
            projectB.Name = nameAfter;
            unitOfWork.Commit();

            var projectC = unitOfWork.Projects.FindById(projectA.Id);
            Assert.AreEqual(projectC.Name, projectB.Name);
        }

        [TestMethod()]
        public void DeleteAllProjects()
        {
            UnitOfWork unitOfWork = new UnitOfWork();

            const string name = "PROJECT TEST";

            var project = unitOfWork.Projects.Create();
            project.Name = name;

            unitOfWork.Projects.Add(project);
            unitOfWork.Commit();

            unitOfWork.Projects.Remove(unitOfWork.Projects.FindAll());
            unitOfWork.Commit();

            Assert.AreEqual<long>(0L, unitOfWork.Projects.Count());
        }
    }
}
