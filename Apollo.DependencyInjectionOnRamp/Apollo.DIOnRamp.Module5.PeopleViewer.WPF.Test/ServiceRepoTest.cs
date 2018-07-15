using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;
using Apollo.DIOnRamp.Shared.Models;
using Apollo.DIOnRamp.Module3.PeopleViewer.WPF.ServiceReference1;
using Apollo.DIOnRamp.Module3.PeopleViewer.WPF.Models;

namespace Apollo.DIOnRamp.Module3.PeopleViewer.WPF.Test
{
    [TestClass]
    public class ServiceRepoTest
    {
        IPeopleService _peopleService;

        [TestInitialize]
        public void Setup()
        {
            var people = new List<Person>()
            {
                new Person() { FirstName = "Super", LastName = "Man", PersonId = 1},
                new Person() { FirstName = "Wonder", LastName = "Woman", PersonId = 2},
                new Person() { FirstName = "Incredible", LastName = "Hulk", PersonId = 3}
            };

            Mock<IPeopleService> peopleServiceMock = new Mock<IPeopleService>();
            peopleServiceMock.Setup(r => r.GetPeople()).Returns(people);

            peopleServiceMock.Setup(r => r.GetPerson(It.IsAny<string>()))
                .Returns((string n) => people.FirstOrDefault(p => p.LastName == n));
            _peopleService = peopleServiceMock.Object;
        }

        [TestMethod]
        public void GetPeople_OnExecute_ReturnsPeople()
        {
            //Arrange
            var repo = new ServiceRepo
            {
                PeopleService = _peopleService
            };

            //Act
            var output = repo.GetPeople();

            //Assert
            Assert.IsNotNull(output);
            Assert.AreEqual(3, output.Count());
        }

        [TestMethod]
        public void GetPerson_OnExecuteWithValidValue_ReturnsPerson()
        {
            // Arrange
            var repo1 = new ServiceRepo
            {
                PeopleService = _peopleService
            };

            // Act
            var output1 = repo1.GetPerson("Woman");

            // Assert
            Assert.IsNotNull(output1);
            Assert.AreEqual("Woman", output1.LastName);
        }

        [TestMethod]
        public void GetPerson_OnExecuteWithInvalidValue_ReturnsPerson()
        {
            // Arrange
            var repo = new ServiceRepo
            {
                PeopleService = _peopleService
            };

            // Act
            var output = repo.GetPerson("NOTAREALPERSON");

            // Assert
            Assert.IsNull(output);
        }
    }
}
