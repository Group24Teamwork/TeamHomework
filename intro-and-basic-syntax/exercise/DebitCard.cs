
using System;

namespace DebitCard
{
    class Program
    {
        static void Main(string[] args)
        {
			//Receive four random integer numbers - max length: 4 digits.
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var fourthNumber = int.Parse(Console.ReadLine());

			//Print the entered four numbers in debit card format
            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", firstNumber, secondNumber, thirdNumber, fourthNumber);
        }
    }
}
