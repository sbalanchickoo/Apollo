using Apollo.PersonLibrary.CS.Interfaces;
using Apollo.PersonLibrary.CS.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Apollo.PersonLibrary.CS.Concretes
{
    public class PeopleRepository : IPersonRepository
    {
        //public Person[] GetPeople()
        //public List<Person> GetPeople()
        IEnumerable<Person> IPersonRepository.GetPeople()
        //public <Person> GetPeople()
        {
            //var People = new Person[]
            var People = new List<Person>
            {
                new Person() { FirstName = "John", LastName = "A", PersonId = 1 },
                new Person() { FirstName = "Jack", LastName = "B", PersonId = 1 }
            };
            return People;
        }
        
        Person IPersonRepository.GetPerson()
        {
            throw new NotImplementedException();
        }

        void IPersonRepository.AddPerson()
        {
            throw new NotImplementedException();
        }

        void IPersonRepository.UpdatePerson(string lastName, Person updatedPerson)
        {
            throw new NotImplementedException();
        }

        void IPersonRepository.DeletePerson(string lastName, string firstName)
        {
            throw new NotImplementedException();
        }
    }
}
