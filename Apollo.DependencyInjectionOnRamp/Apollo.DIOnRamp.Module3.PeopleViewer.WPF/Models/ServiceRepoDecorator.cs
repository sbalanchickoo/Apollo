using Apollo.DIOnRamp.Module3.PeopleViewer.WPF.ServiceReference1;
using Apollo.DIOnRamp.Shared.Interfaces;
using Apollo.DIOnRamp.Shared.Models;
using System;
using System.Collections.Generic;

namespace Apollo.DIOnRamp.Module3.PeopleViewer.WPF.Models
{
    public class ServiceRepoDecorator : IPersonRepository
    {
        private IEnumerable<Person> _peopleCollection;
        public IEnumerable<Person> PeopleCollection
        {
            get
            {
                return _peopleCollection;
            }
            set
            {
                if (true)
                {
                    _peopleCollection = value;
                }
                else
                {

                }
            }
        }

        private bool _cacheValid;
        private DateTime _cacheTime;

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
            if (_cacheValid)
            {
                return PeopleCollection;
            }
            else
            {
                PeopleCollection = peopleService.GetPeople();
                return PeopleCollection;
            }
        }

        public Person GetPerson()
        {
            throw new NotImplementedException();
        }
    }
}
