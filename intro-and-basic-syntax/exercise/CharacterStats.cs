using System;

namespace p05._Character_Stats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string heroName = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {heroName}");
            Console.Write("Health: |");
            Console.Write(new string('|', currentHealth));
            Console.Write(new string('.', maxHealth - currentHealth));
            Console.WriteLine("|");

            Console.Write("Energy: |");
            Console.Write(new string('|', currentEnergy));
            Console.Write(new string('.', maxEnergy - currentEnergy));
            Console.WriteLine("|");
        }
    }
}
