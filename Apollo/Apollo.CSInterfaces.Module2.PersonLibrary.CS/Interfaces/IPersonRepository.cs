using Apollo.CSInterfaces.Module2.PersonLibrary.CS.Models;
using System.Collections.Generic;

namespace Apollo.CSInterfaces.Module2.PersonLibrary.CS.Interfaces
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