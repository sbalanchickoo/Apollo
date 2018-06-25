using Apollo.CSInterfaces.Module3.Interfaces.CS;
using Apollo.CSInterfaces.Module3.Interfaces.CS.Models;
using Apollo.CSInterfaces.Module3.ServiceRepository.CS.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.CSInterfaces.Module3.ServiceRepository.CS
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

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
