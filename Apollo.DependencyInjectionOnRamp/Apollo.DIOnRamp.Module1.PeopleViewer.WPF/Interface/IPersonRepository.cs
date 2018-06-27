using Apollo.DIOnRamp.Module1.PeopleViewer.WPF.Model;
using System.Collections.Generic;

namespace Apollo.DIOnRamp.Module1.PeopleViewer.WPF.Interface
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
