using Apollo.DIOnRamp.Module3.PeopleViewer.WPF.ServiceReference1;
using Apollo.DIOnRamp.Shared.Interfaces;
using Apollo.DIOnRamp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Apollo.DIOnRamp.Module3.PeopleViewer.WPF.Models
{
    public class ServiceRepoDecorator : IPersonRepository
    {
        public IEnumerable<Person> PeopleCollection { get; set; }

        private IPersonRepository _repository;
        
        private DateTime _cacheTime;

        private bool _cacheValid;

        public void AddPerson()
        {
            _repository.AddPerson();
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
                    PeopleCollection = _repository.GetPeople();
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

        public Person GetPerson(string lastName)
        {
            return _repository.GetPerson(lastName);    
        }

        public ServiceRepoDecorator(IPersonRepository repository)
        {
            _repository = repository;
        }
    }
}
