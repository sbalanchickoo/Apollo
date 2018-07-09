using Apollo.DIOnRamp.Module3.Shared.Models;
using System.Collections.Generic;

namespace Apollo.DIOnRamp.Module3.Shared.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();

        Person GetPerson();

        void AddPerson();

        void DeletePerson(string lastName, string firstName);
    }
}
