using Apollo.CSInterfaces.Module3.CSVRepository;
using Apollo.CSInterfaces.Module3.Interfaces.CS;
using Apollo.CSInterfaces.Module3.ServiceRepository.CS;
using System;

namespace Apollo.CSInterfaces.Module3.PeopleViewer.WPF
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetRepository(string repoType)
        {
            IPersonRepository repo = null;
            switch (repoType)
            {
                case "Service":
                    repo = new ServiceRepo();
                    break;
                case "CSV":
                    repo = new CSVRepo();
                    break;
                default:
                    throw new ArgumentException("Invalid Repository Type");
            }
            return repo;
        }
    }
}
