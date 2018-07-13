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

        public IPersonRepository Repository { get; set; }

        private bool _cacheValid;
        private DateTime _cacheTime;

        //PeopleServiceClient peopleService = new PeopleServiceClient();

        public void AddPerson()
        {
            Repository.AddPerson();
        }

        public void DeletePerson(string lastName, string firstName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeople()
        {
            ValidateCache();
            if (!(_cacheValid) || PeopleCollection == null)
            {
                PeopleCollection = Repository.GetPeople();
                _cacheTime = DateTime.Now;
            }
            return PeopleCollection;
        }

        private void ValidateCache()
        {
            if (DateTimeOffset.Now.Second - _cacheTime.Second > 30)
            {
                _cacheValid = false;
            }
            else
            {
                _cacheValid = true;
            }
        }
        public Person GetPerson()
        {
            throw new NotImplementedException();
        }

        public ServiceRepoDecorator(IPersonRepository repository)
        {
            Repository = repository;
        }
    }
}
