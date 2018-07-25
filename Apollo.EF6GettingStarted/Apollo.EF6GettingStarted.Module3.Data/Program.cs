using Apollo.EFGettingStarted.EFRepo.Implementations;
using Apollo.EFGettingStarted.Shared.Interfaces;

namespace Apollo.EF6GettingStarted.Module3.Intro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            INinja ininja;
            ininja = new EFNinjaOperations();

            ininja.GetAllClans();
            ininja.AddClan("first");
            System.Console.WriteLine("The end.");
            System.Console.ReadLine();
        }
    }
}

