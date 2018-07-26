using Apollo.EFGettingStarted.EFRepo.DataModels;
using Apollo.EFGettingStarted.Shared.Interfaces;
using Apollo.EFGettingStarted.Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;

namespace Apollo.EFGettingStarted.EFRepo.Implementations
{
    public class EFNinjaOperations : INinja
    {
        public void AddClan(string clanName)
        {
            int a = 0;
            try
            {
                using (var context = new NinjaDataContext())
                {
                    Clan newClan = new Clan
                    {
                        ClanName = clanName
                    };
                    context.Clans.Add(newClan);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                if (ex is DbUpdateException dbUpdateEx)
                {
                    if (true
                        //dbUpdateEx.InnerException != null
                            //&& dbUpdateEx.InnerException.InnerException != null
                            )
                    {
                        if (dbUpdateEx.InnerException.InnerException is SqlException sqlException)
                        {
                            a = sqlException.Number;
                            switch (sqlException.Number)
                            {
                                case 2627:  // Unique constraint error
                                case 547:   // Constraint check violation
                                case 2601:  // Duplicated key row error
                                            // Constraint violation exception
                                            // A custom exception of yours for concurrency issues
                                    break;

                                default:
                                    // A custom exception of yours for other DB issues
                                    throw new Exception(
                                      dbUpdateEx.Message, dbUpdateEx.InnerException);
                            }
                        }

                        throw new Exception(dbUpdateEx.Message, dbUpdateEx.InnerException);
                    }
                    
                }
                
            }
            finally
            {
                Console.WriteLine(a);
                Console.ReadLine();
            }
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

        List<Clan> INinja.GetAllClans()
        {
            List<Clan> clans = new List<Clan>();
            using (var context = new NinjaDataContext())
            {
                clans = context.Clans.ToList();
            }
            return clans;
        }

        List<Equipment> INinja.GetAllEquipments()
        {
            throw new System.NotImplementedException();
        }

        List<Ninja> INinja.GetAllNinjas()
        {
            throw new System.NotImplementedException();
        }

        Clan INinja.GetClanByName(string clanName)
        {
            throw new System.NotImplementedException();
        }

        Equipment INinja.GetEquipmentByName(string equipment)
        {
            throw new System.NotImplementedException();
        }

        List<Equipment> INinja.GetEquipmentsByClan(string clanName)
        {
            throw new System.NotImplementedException();
        }

        Ninja INinja.GetNinjaByName(string ninjaName)
        {
            throw new System.NotImplementedException();
        }
    }
}
