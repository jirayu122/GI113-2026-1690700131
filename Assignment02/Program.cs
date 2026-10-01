/*
* Student ID : 1690700131
* Name       : jirayu usaneesawatchai
* Section    : 129A
* No.        :
* Course     : GI113 Computer Programming (GI
*/

using System;

namespace Assignment02
{
    class Program
    {
        const double SmeltRate = 0.70;
        const double SalvageRate = 0.85;
        const double MaxBatch = 300;

        static void Main(string[] args)
        {
            Console.WriteLine("====== SILVER FORGE ======");
            Console.WriteLine("S : Smelt Silver Ore");
            Console.WriteLine("B : Breakdown Silver Ingot");
            Console.WriteLine("Smelt Rate : " + SmeltRate);
            Console.WriteLine("Salvage Rate : " + SalvageRate);

            Console.Write("Choose Menu : ");
            string inputMenu = Console.ReadLine();

            char menu;
            if (!char.TryParse(inputMenu, out menu))
            {
                Console.WriteLine("Invalid menu.");
                return;
            }

            menu = char.ToUpper(menu);

            if (menu != 'S' && menu != 'B')
            {
                Console.WriteLine("Invalid menu.");
                return;
            }

            Console.Write("Enter amount : ");
            string inputAmount = Console.ReadLine();

            double amount;
            if (!double.TryParse(inputAmount, out amount))
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than 0.");
                return;
            }
            else if (amount > MaxBatch)
            {
                Console.WriteLine("Amount is over the limit.");
                return;
            }

            double result;

            if (menu == 'S')
            {
                result = amount * SmeltRate;

                Console.WriteLine(
                    $"{amount:F2} Silver Ore -> {result:F2} Silver Ingot"
                );
            }
            else
            {
                result = amount / SalvageRate;

                Console.WriteLine(
                    $"{amount:F2} Silver Ingot -> {result:F2} Silver Ore"
                );
            }

            Console.WriteLine("Forge complete.");
        }
    }
}