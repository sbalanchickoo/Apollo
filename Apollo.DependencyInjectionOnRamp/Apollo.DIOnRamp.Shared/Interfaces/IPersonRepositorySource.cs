using Apollo.DIOnRamp.Shared.Models;
using System.Collections.Generic;

namespace Apollo.DIOnRamp.Shared.Interfaces
{
    public interface IPersonRepositorySource
    {
        IEnumerable<Person> GetPeople();

        Person GetPerson(string lastName);

        void AddPerson();

        void DeletePerson(string lastName, string firstName);
    }
}
