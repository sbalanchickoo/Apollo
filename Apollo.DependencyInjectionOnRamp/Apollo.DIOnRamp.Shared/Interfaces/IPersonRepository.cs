﻿using Apollo.DIOnRamp.Shared.Models;
using System.Collections.Generic;

namespace Apollo.DIOnRamp.Shared.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();

        Person GetPerson();

        void AddPerson();

        void DeletePerson(string lastName, string firstName);
    }
}
