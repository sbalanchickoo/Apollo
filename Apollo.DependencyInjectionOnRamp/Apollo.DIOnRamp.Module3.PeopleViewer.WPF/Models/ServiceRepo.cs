using Apollo.DIOnRamp.Module3.PeopleViewer.WPF.ServiceReference1;
using Apollo.DIOnRamp.Shared.Interfaces;
using Apollo.DIOnRamp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Apollo.DIOnRamp.Module3.PeopleViewer.WPF.Models
{
    public class ServiceRepo : IPersonRepository
    {
        //PeopleServiceClient peopleService = new PeopleServiceClient();

        private IPeopleService _peopleService;
        public IPeopleService PeopleService
        {
            get
            {
                if (_peopleService == null)
                {
                    _peopleService = new PeopleServiceClient();
                }
                return _peopleService;
            }
            set { _peopleService = value; }
        }

        public Person GetPerson(string lastName)
        {
            Person selPerson = PeopleService.GetPerson(lastName);
            return selPerson;
        }
        
        public void AddPerson()
        {
            PeopleService.AddPerson();
        }

        public void DeletePerson(string lastName, string firstName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeople()
        {
            return PeopleService.GetPeople();
        }

        //servicerepo -> decorator -> viewmodel -> view
    }
}
