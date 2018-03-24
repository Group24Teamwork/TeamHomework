using System;

namespace p05._Character_Stats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
			//Read hero name from console
            string heroName = Console.ReadLine();
			
			//Read and parse hero stats
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

			//Display hero name
            Console.WriteLine($"Name: {heroName}");
			
			//Output health to console
            Console.Write("Health: |");
            Console.Write(new string('|', currentHealth));
            Console.Write(new string('.', maxHealth - currentHealth));
            Console.WriteLine("|");
			
			//Output energy to console
            Console.Write("Energy: |");
            Console.Write(new string('|', currentEnergy));
            Console.Write(new string('.', maxEnergy - currentEnergy));
            Console.WriteLine("|");
        }
    }
}
