using Apollo.DIOnRamp.Module1.Shared.Model;
using System.Collections.Generic;

namespace Apollo.DIOnRamp.Module1.Shared.Interface
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();

        Person GetPerson();

        void AddPerson();

        void DeletePerson(string lastName, string firstName);
    }
}
