using Apollo.DIOnRamp.Module3.PeopleViewer.WPF.ServiceReference3;
using Apollo.DIOnRamp.Module3.Shared.Interfaces;
using Apollo.DIOnRamp.Module3.Shared.Models;
using System;
using System.Collections.Generic;

namespace Apollo.DIOnRamp.Module3.PeopleViewer.WPF.Models
{
    public class ServiceRepoDecorator : IPersonRepository
    {
        PeopleServiceClient peopleService = new PeopleServiceClient();

        private int _durationSec;

        public int DurationSec
        {
            get { return _durationSec; }
            set { _durationSec = value; }
        }


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
