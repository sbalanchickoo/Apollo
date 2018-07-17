using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;
using Apollo.DIOnRamp.Shared.Models;
using Apollo.DIOnRamp.Module5.PeopleViewer.WPF.ServiceReference1;
using Apollo.DIOnRamp.Module5.PeopleViewer.WPF.Models;
using Unity;
using Unity.Injection;

namespace Apollo.DIOnRamp.Module5.PeopleViewer.WPF.Test
{
    [TestClass]
    public class ServiceRepoTestUnity
    {
        IPeopleService _peopleService;
        UnityContainer Container;

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
            Container = new UnityContainer();
            Container.RegisterInstance<IPeopleService>(peopleServiceMock.Object);
            Container.RegisterType<ServiceRepo>(
                new InjectionProperty("PeopleService"));
        }

        [TestMethod]
        public void Unity_GetPeople_OnExecute_ReturnsPeople()
        {
            //Arrange
            var repo = Container.Resolve<ServiceRepo>();
            
            //Act
            var output = repo.GetPeople();

            //Assert
            Assert.IsNotNull(output);
            Assert.AreEqual(3, output.Count());
        }

        [TestMethod]
        public void Unity_GetPerson_OnExecuteWithValidValue_ReturnsPerson()
        {
            // Arrange
            var repo = Container.Resolve<ServiceRepo>();

            // Act
            var output = repo.GetPerson("Woman");

            // Assert
            Assert.IsNotNull(output);
            Assert.AreEqual("Woman", output.LastName);
        }

        [TestMethod]
        public void Unity_GetPerson_OnExecuteWithInvalidValue_ReturnsPerson()
        {
            // Arrange
            var repo = Container.Resolve<ServiceRepo>();

            // Act
            var output = repo.GetPerson("NOTAREALPERSON");

            // Assert
            Assert.IsNull(output);
        }
    }
}
