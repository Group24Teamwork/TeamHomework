//CONFIRMED from nigosto

using System;
    class BeverageLabels
    {
        static void Main()
        {
        //In the next 4 lines we receive the type of the drink , its volume,energy and sugar content per 100 ml
        string typeOfDrink = Console.ReadLine();
        int volume = int.Parse(Console.ReadLine());
        int energy = int.Parse(Console.ReadLine());
        int sugar = int.Parse(Console.ReadLine());

        //In the next 2 lines we calculate the energy and sugar content for the given drink
        double energyContent = (volume * energy) / 100.00;
        double sugarContent = (volume * sugar) / 100.00;

        //Lastly we print the volume followed by the name of the drink and on the next line we print the energy and sugar content of the current drink
        Console.WriteLine("{0}ml {1}:", volume, typeOfDrink);
        Console.WriteLine("{0}kcal, {1}g sugars", energyContent, sugarContent);

        }
    }
 