using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Projects.DataAccess;
using Projects.DataAccess.Sql;

namespace Projects.Testing.DataAccess
{
    [TestClass]
    public class Sql
    {
        [TestMethod]
        public void CreateDatabase()
        {
            UnitOfWork uow = new UnitOfWork();

            uow.CreateDatabase();
        }
    }
}
