using Apollo.DIOnRamp.Module1.People.SVC.Model;
using System.Collections.Generic;
using System.ServiceModel;

namespace Apollo.DIOnRamp.Module1.People.SVC.Interface
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPeopleService
    {
        [OperationContract]
        List<Person> GetPeople();

        [OperationContract]
        Person GetPerson();

        [OperationContract]
        void AddPerson();

        [OperationContract]
        void UpdatePerson(string lastName, Person updatedPerson);

        [OperationContract]
        void DeletePerson(string lastName, string firstName);
        // TODO: Add your service operations here
    }
}
