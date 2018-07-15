using Apollo.DIOnRamp.Shared.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace Apollo.DIOnRamp.People.SVC.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPeopleService
    {
        [OperationContract]
        IEnumerable<Person> GetPeople();

        [OperationContract]
        Person GetPerson(string lastName);

        [OperationContract]
        void AddPerson();

        [OperationContract]
        void DeletePerson(string lastName, string firstName);
        // TODO: Add your service operations here
    }
}
