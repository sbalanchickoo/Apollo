﻿using Apollo.DIOnRamp.Module1.Shared.Models;
using System.Collections.Generic;

namespace Apollo.DIOnRamp.Module1.Shared.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();

        Person GetPerson();

        void AddPerson();

        void DeletePerson(string lastName, string firstName);
    }
}
