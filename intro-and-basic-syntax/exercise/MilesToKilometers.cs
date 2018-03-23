using System;

namespace _03._Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
	
        {
			//Receive some floating point number (miles) from the console
            var miles = double.Parse(Console.ReadLine());
			
			//Calculating kilometers from inputed value of miles
            var km = miles * 1.60934;

			//Print the result to the console
            Console.WriteLine($"{km:F2}");
        }
    }
}
