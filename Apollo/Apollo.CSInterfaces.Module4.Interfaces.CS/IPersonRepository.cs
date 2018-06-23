using Apollo.CSInterfaces.Module4.Interfaces.CS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.CSInterfaces.Module4.Interfaces.CS
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();

        Person GetPerson();

        void AddPerson();

        void UpdatePerson(string lastName, Person updatedPerson);

        void DeletePerson(string lastName, string firstName);
    }
}
