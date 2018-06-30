using Apollo.DIOnRamp.Module1.PeopleViewer.WPF.Model;
using Apollo.DIOnRamp.Module1.Shared.Interface;
using Apollo.DIOnRamp.Module1.Shared.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Apollo.DIOnRamp.Module1.PeopleViewer.WPF.ViewModel
{
    public class PeopleViewModel : INotifyPropertyChanged
    {
        private string _firstName;
        public IPersonRepository _peopleRepo; 
        public IPersonRepository PeopleRepo { get; set; }

        private IEnumerable<Person> _people;
        public IEnumerable<Person> People
        {
            get { return _people; }
            set
            {
                _people = value;
                RaisePropertyChanged("People");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaisePropertyChanged("FirstName");
                }
            }
        }
        public PeopleViewModel()
        {
            PeopleRepo = RepositoryFactory.GetRepository();
            People = PeopleRepo.GetPeople();
        }
    }
}
