using Apollo.EFGettingStarted.Shared.Models;
using System.Collections.Generic;

namespace Apollo.EFGettingStarted.Shared.Interfaces
{
    public interface INinja
    {
        void AddClan(string clanName);

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
