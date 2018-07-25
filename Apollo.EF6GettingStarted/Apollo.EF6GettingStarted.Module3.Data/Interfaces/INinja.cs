using Apollo.EF6GettingStarted.Module3.Intro.Models;
using System.Collections.Generic;

namespace Apollo.EF6GettingStarted.Module3.Data.Interfaces
{
    public interface INinja
    {
        string AddClan(string clanName);

        string AddNinja(string ninjaName);

        string AddEquipment(string equipmentName);

        List<Ninja> GetAllNinjas();

        List<Clan> GetAllClans();

        List<Equipment> GetAllEquipments();

        Ninja GetNinjaByName(string ninjaName);

        Clan GetClanByName(string clanName);

        Equipment GetEquipmentByName(string equipment);

        List<Equipment> GetEquipmentsByClan(string clanName);
    }
}
