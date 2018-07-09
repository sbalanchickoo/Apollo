using Apollo.DIOnRamp.Module3.Shared.Interfaces;
using Apollo.DIOnRamp.Module3.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace Apollo.DIOnRamp.Module3.PeopleViewer.WPF.ViewModels
{
    public class PeopleViewModel : INotifyPropertyChanged
    {
        private string _firstName;
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

        private RefreshCommand _refreshPeopleCommand = new RefreshCommand();
        public RefreshCommand RefreshPeopleCommand
        {
            get
            {
                if (_refreshPeopleCommand.ViewModel == null)
                    _refreshPeopleCommand.ViewModel = this;
                return _refreshPeopleCommand;
            }
        }

        private EmptyCommand _emptyPeopleCommand = new EmptyCommand();
        public EmptyCommand EmptyPeopleCommand
        {
            get
            {
                if (_emptyPeopleCommand.ViewModel == null)
                    _emptyPeopleCommand.ViewModel = this;
                return _emptyPeopleCommand;
            }
        }

        public class RefreshCommand : ICommand
        {
            public PeopleViewModel ViewModel { get; set; }
            public event EventHandler CanExecuteChanged;
            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                ViewModel.People = ViewModel.PeopleRepo.GetPeople();
            }
        }

        public class EmptyCommand : ICommand
        {
            public PeopleViewModel ViewModel { get; set; }
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                ViewModel.People = new List<Person>();
            }
        }

        public PeopleViewModel(IPersonRepository repository)
        {
            PeopleRepo = repository;
        }
    }
}
