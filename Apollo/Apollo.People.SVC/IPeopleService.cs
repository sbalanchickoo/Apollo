﻿using Apollo.People.SVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Apollo.People.SVC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPeopleService
    {

        [OperationContract]
        IEnumerable<Person> GetPeople();

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
