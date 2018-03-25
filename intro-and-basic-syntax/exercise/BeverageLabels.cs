using System;
    class BeverageLabels
    {
        static void Main()
        {
        string typeOfDrink = Console.ReadLine();
        int volume = int.Parse(Console.ReadLine());
        int energy = int.Parse(Console.ReadLine());
        int sugar = int.Parse(Console.ReadLine());

        double energyContent = (volume * energy) / 100.00;
        double sugarContent = (volume * sugar) / 100.00;

        Console.WriteLine("{0}ml {1}:", volume, typeOfDrink);
        Console.WriteLine("{0}kcal, {1}g sugars", energyContent, sugarContent);

        }
    }
 