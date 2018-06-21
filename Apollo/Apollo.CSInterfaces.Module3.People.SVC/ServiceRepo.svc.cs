using Apollo.CSInterfaces.Module3.People.SVC.Models;
using System;
using System.Collections.Generic;

namespace Apollo.CSInterfaces.Module3.People.SVC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceRepo : IPeopleService
    {
        public IEnumerable<Person> GetPeople()
        {
            var People = new List<Person>
            {
                new Person() { FirstName = "John", LastName = "A", PersonId = 1 },
                new Person() { FirstName = "Jack", LastName = "B", PersonId = 1 }
            };
            return People;
        }

        Person IPeopleService.GetPerson()
        {
            throw new NotImplementedException();
        }

        public void AddPerson()
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(string lastName, string firstName)
        {
            throw new NotImplementedException();
        }
    }
}
