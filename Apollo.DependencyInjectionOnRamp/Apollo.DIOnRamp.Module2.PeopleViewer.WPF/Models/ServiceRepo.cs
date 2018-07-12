﻿using Apollo.DIOnRamp.Module2.PeopleViewer.WPF.ServiceReference1;
using Apollo.DIOnRamp.Shared.Interfaces;
using Apollo.DIOnRamp.Shared.Models;
using System;
using System.Collections.Generic;

namespace Apollo.DIOnRamp.Module2.PeopleViewer.WPF.Models
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
    }
}
