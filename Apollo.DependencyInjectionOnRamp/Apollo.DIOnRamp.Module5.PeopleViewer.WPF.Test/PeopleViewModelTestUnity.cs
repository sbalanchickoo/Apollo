using System.Collections.Generic;
using System.Linq;
using Apollo.DIOnRamp.Module5.PeopleViewer.WPF.ViewModels;
using Apollo.DIOnRamp.Shared.Interfaces;
using Apollo.DIOnRamp.Shared.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Unity;

namespace Apollo.DIOnRamp.Module5.PeopleViewer.WPF.Test
{
    [TestClass]
    public class PeopleViewModelTestUnity
    {
        private IPersonRepository _repository;
        private UnityContainer Container;

        [TestInitialize]
        public void Setup()
        {
            var people = new List<Person>()
            {
                new Person() { FirstName = "Super", LastName = "Man", PersonId = 1},
                new Person() { FirstName = "Wonder", LastName = "woman", PersonId = 2},
                new Person() { FirstName = "Incredible", LastName = "Hulk", PersonId = 3}
            };

            var repositoryMock = new Mock<IPersonRepository>();
            repositoryMock.Setup(r => r.GetPeople()).Returns(people);
            Container = new UnityContainer();
            Container.RegisterInstance<IPersonRepository>(repositoryMock.Object);
            //_repository = repositoryMock.Object;
        }

        [TestMethod]
        public void Unity_People_OnGet_IsPopulated()
        {
            //Arrange
            //var viewModel = new PeopleViewModel(_repository);
            var viewModel = Container.Resolve<PeopleViewModel>();

            //Act
            viewModel.RefreshPeopleCommand.Execute(null);

            //Assert
            Assert.IsNotNull(viewModel.People);
            Assert.AreEqual(3, viewModel.People.Count());
        }
    }
}
