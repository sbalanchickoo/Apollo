using Apollo.CSInterfaces.Module4.Interfaces.CS;
using System;
using System.Configuration;
using System.Windows;

namespace Apollo.CSInterfaces.Module4.PeopleViewer.WPF
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetRepository()
        {
            string typeName = ConfigurationManager.AppSettings["RepositoryType"];
            Type repoType = Type.GetType(typeName);
            object repoInstance = Activator.CreateInstance(repoType);
            IPersonRepository repo = repoInstance as IPersonRepository;
            return repo;
        }
    }
}
