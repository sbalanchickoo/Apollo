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
        [TestMethod]
        public void TestSetup()
        {
            var mockSet = new Mock<DbSet<Clan>>();
            var clanList = new List<Clan>
            {
                //new Clan {Id=1,ClanName="abc"},
            }.AsQueryable();

            var mockContext = new Mock<NinjaDataContext>();
            mockSet.As<IQueryable<Clan>>().Setup(m => m.Provider).Returns(clanList.Provider);
            mockSet.As<IQueryable<Clan>>().Setup(m => m.Expression).Returns(clanList.Expression);
            mockSet.As<IQueryable<Clan>>().Setup(m => m.ElementType).Returns(clanList.ElementType);
            mockSet.As<IQueryable<Clan>>().Setup(m => m.GetEnumerator()).Returns(clanList.GetEnumerator());
            mockContext.Setup(m => m.Clans).Returns(mockSet.Object);

            var efNinjaOperations = new EFNinjaOperations(mockContext.Object);

            //mockSet.Setup(m => m.Add(It.IsAny<Clan>())).Returns(mockSet.Object);

            //var service = new BlogService(mockContext.Object);
            //service.AddBlog("ADO.NET Blog", "http://blogs.msdn.com/adonet");
            //AddClan("a");
            //mockSet.Verify(m => m.Add(It.IsAny<Blog>()), Times.Once());
            //mockContext.Verify(m => m.SaveChanges(), Times.Once());
            //mockSet.Verify(m => m.Add(It.IsAny<Clan>()), Times.Once());
            //Clan c = new Clan { Id = 1, ClanName = "A" };
            efNinjaOperations.AddClan("A");
            //mockSet.Object.Add(c);
            //mockSet.Object.Add(c);
            //mockContext.SaveChanges();

            //mockContext.Verify(m => m.SaveChanges(), Times.AtMostOnce());
            //mockContext.SetupAllProperties();
            List<Clan> a1 = efNinjaOperations.GetAllClans();
            int a = a1.Count();
            //string n = mockSet.Object.FirstOrDefault<Clan>().ClanName;
            Assert.AreEqual(1, a);
            //Assert.AreEqual("abc", n);

        }
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    int count = 0;

        //    //using (var context = new moc())
        //    //{
        //        //count = mockContext.Object.Clans.ToList().Count;
        //    //}
        //    Assert.AreEqual(0, count);
        //}
    }
}
