using Apollo.DIOnRamp.Shared.Interfaces;
using Apollo.DIOnRamp.Shared.Models;
using System;
using System.Collections.Generic;

namespace Apollo.DIOnRamp.Module3.PeopleViewer.WPF.Models
{
    public class ServiceRepoDecorator : IPersonRepository
    {
        public IEnumerable<Person> PeopleCollection { get; set; }
            
        public IPersonRepository Repository { get; set; }

        private DateTime _cacheTime;
        
        public void AddPerson()
        {
            Repository.AddPerson();
            PeopleCollection = null;
        }

        public void DeletePerson(string lastName, string firstName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeople()
        {
            if (!(ValidateCache()) || PeopleCollection == null)
            {
                try
                {
                    PeopleCollection = Repository.GetPeople();
                    _cacheTime = DateTime.Now;
                }
                catch
                {
                    PeopleCollection = new List<Person>
                    {
                        new Person() { FirstName = "Not found", LastName = "Not found", PersonId = -1 }
                    };
                }
            }
            return PeopleCollection;
        }

        private bool ValidateCache()
        {
            bool validity;
            if ((DateTime.Now - _cacheTime).TotalSeconds > 30)
            {
                validity = false;
            }
            else
            {
                validity = true;
            }
            return validity;
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
