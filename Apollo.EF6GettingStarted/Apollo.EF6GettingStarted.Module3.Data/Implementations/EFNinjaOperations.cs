using Apollo.EF6GettingStarted.Module3.Data.Interfaces;
using Apollo.EF6GettingStarted.Module3.Intro.DataModels;
using Apollo.EF6GettingStarted.Module3.Intro.Models;
using System.Collections.Generic;
using System.Linq;

namespace Apollo.EF6GettingStarted.Module3.Data.Implementations
{
    public class EFNinjaOperations : INinja
    {
        public string AddClan(string clanName)
        {
            string result = "";

            using (var context = new NinjaDataContext())
            {
                var existingClan = context.Clans.FirstOrDefault(c => c.ClanName == clanName);
                if (existingClan == null)
                {
                    result = $"Clan [{clanName}] already exists.";
                }
                else
                {
                    try
                    {
                        Clan newClan = new Clan
                        {
                            ClanName = clanName
                        };
                        context.Clans.Add(newClan);
                        context.SaveChanges();
                        result = "Success";
                    }
                    catch
                    {
                        result = "Failure";
                    }
                }
            }
            return result;
        }

        public string AddEquipment(string equipmentName)
        {
            throw new System.NotImplementedException();
        }

        public string AddNinja(string ninjaName)
        {
            throw new System.NotImplementedException();
        }

        public List<Clan> GetAllClans()
        {
            throw new System.NotImplementedException();
        }

        public List<Equipment> GetAllEquipments()
        {
            throw new System.NotImplementedException();
        }

        public List<Ninja> GetAllNinjas()
        {
            throw new System.NotImplementedException();
        }

        public Clan GetClanByName(string clanName)
        {
            throw new System.NotImplementedException();
        }

        public Equipment GetEquipmentByName(string equipment)
        {
            throw new System.NotImplementedException();
        }

        public List<Equipment> GetEquipmentsByClan(string clanName)
        {
            throw new System.NotImplementedException();
        }

        public Ninja GetNinjaByName(string ninjaName)
        {
            throw new System.NotImplementedException();
        }
    }
}
