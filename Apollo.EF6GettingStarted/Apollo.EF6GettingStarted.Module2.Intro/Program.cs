using Apollo.EF6GettingStarted.Module2.Intro.Models;

namespace Apollo.EF6GettingStarted.Module2.Intro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Equipment Eq1 = new Equipment();
            Eq1.Type = EquipmentType.Heavy;
        }
    }
}

