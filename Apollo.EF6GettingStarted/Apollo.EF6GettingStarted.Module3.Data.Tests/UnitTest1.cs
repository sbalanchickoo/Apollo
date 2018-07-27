using System.Linq;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using Apollo.EFGettingStarted.EFRepo.DataModels;
using Apollo.EFGettingStarted.EFRepo.Implementations;
using System.Collections.Generic;
using Apollo.EFGettingStarted.Shared.Models;

namespace Apollo.EF6GettingStarted.Module3.Data.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void TestSetup()
        {
            var mockSet = new Mock<DbSet<Clan>>();

            var mockContext = new Mock<NinjaDataContext>();
            mockContext.Setup(m => m.Clans).Returns(mockSet.Object);
            //mockSet.Setup(m => m.Add(It.IsAny<Clan>())).Returns(mockSet.Object);

            //var service = new BlogService(mockContext.Object);
            //service.AddBlog("ADO.NET Blog", "http://blogs.msdn.com/adonet");
            //AddClan("a");
            //mockSet.Verify(m => m.Add(It.IsAny<Blog>()), Times.Once());
            //mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
        [TestMethod]
        public void TestMethod1()
        {
            int count = 0;

            //using (var context = new moc())
            //{
                //count = mockContext.Object.Clans.ToList().Count;
            //}
            //Assert.AreEqual(2, count);
        }
    }
}
