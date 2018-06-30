using Apollo.DIOnRamp.Module1.PeopleViewer.WPF.ServiceReference1;
using Apollo.DIOnRamp.Module1.Shared.Interface;
using Apollo.DIOnRamp.Module1.Shared.Model;
using System;
using System.Collections.Generic;

namespace Apollo.DIOnRamp.Module1.PeopleViewer.WPF.Model
{
    public class ServiceRepo : IPersonRepository
    {
        PeopleServiceClient peopleService = new PeopleServiceClient();

        public void AddPerson()
        {
            peopleService.AddPerson();
        }

        public void DeletePerson(string lastName, string firstName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeople()
        {
            return peopleService.GetPeople();
        }

        public Person GetPerson()
        {
            throw new NotImplementedException();
        }
    }
}
