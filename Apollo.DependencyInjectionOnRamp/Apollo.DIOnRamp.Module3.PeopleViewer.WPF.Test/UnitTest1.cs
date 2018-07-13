using System;
using Apollo.DIOnRamp.Module3.PeopleViewer.WPF.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Apollo.DIOnRamp.Module3.PeopleViewer.WPF.Test
{
    [TestClass]
    public class PeopleViewModelTest
    {
        [TestMethod]
        public void People_OnGet_IsPopulated()
        {
            //Arrange
            var viewModel = new PeopleViewModel(xxx);

            //Act
            viewModel.RefreshPeopleCommand.Execute(null);

            //Assert
            Assert.IsNotNull(viewModel.People);
        }
    }
}
