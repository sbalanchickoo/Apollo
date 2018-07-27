using System.Linq;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using Apollo.EFGettingStarted.EFRepo.DataModels;
using System.Collections.Generic;
using Apollo.EFGettingStarted.Shared.Models;

namespace Apollo.EF6GettingStarted.Module3.Data.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Mock<NinjaDataContext> mockContext = new Mock<NinjaDataContext>();

        [TestInitialize]
        public void TestSetup()
        {

            // COUNTRIES
            List<Clan> [Unique]cland = new List<Clan>();
            var clans = new List<Clan>
            {
                new Clan { Id = 1, ClanName = "A"},
                new Clan { Id = 2, ClanName = "B"}
            }
            .AsQueryable();

            var mockClans = new Mock<DbSet<Clan>>();
            //mockCountries.Setup(m => m.Provider).Returns(clans.Provider);
            //mockCountries.Setup(m => m.Expression).Returns(clans.Expression);
            //mockCountries.Setup(m => m.ElementType).Returns(clans.ElementType);
            mockClans.Setup(m => m.GetEnumerator()).Returns(() => clans.GetEnumerator());
            mockContext.Setup(x => x.Clans).Returns(mockClans.Object);
        }
        [TestMethod]
        public void TestMethod1()
        {
            int count = 0;

            //using (var context = new moc())
            //{
                count = mockContext.Object.Clans.ToList().Count;
            //}
            //Assert.AreEqual(2, count);
        }
    }
}
