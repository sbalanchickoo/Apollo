using Apollo.CSInterfaces.Module3.Interfaces.CS;
using Apollo.CSInterfaces.Module3.Interfaces.CS.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.CSInterfaces.Module3.CSVRepository
{
    public class CSVRepo : IPersonRepository
    {
        string path;

        public CSVRepo()
        {
            var filename = ConfigurationManager.AppSettings["CSVFileName"];
            path = AppDomain.CurrentDomain.BaseDirectory + filename;
        }

        public IEnumerable<Person> GetPeople()
        {
            var people = new List<Person>();

            if (File.Exists(path))
            {
                var sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var elems = line.Split(',');
                    var per = new Person()
                    {
                        FirstName = elems[0],
                        LastName = elems[1],
                    };
                    people.Add(per);
                }
            }
            return people;
        }

        public Person GetPerson()
        {
            throw new NotImplementedException();
        }

        public void AddPerson()
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(string lastName, string firstName)
        {
            throw new NotImplementedException();
        }

        public void UpdatePeople(IEnumerable<Person> updatedPeople)
        {
            throw new NotImplementedException();
        }
    }
}
