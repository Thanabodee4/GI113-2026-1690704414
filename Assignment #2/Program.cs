/*
 * Student ID : 1690704414
 * Name       : ธนบดี ธัญญาภิวัฒนา
 * Section    : 129D
 * No.        : -
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Material = "Iron";
            const double SmeltRate = 0.25;
            const double SalvageRate = 0.30;
            const double MaxBatch = 500.0;

            Console.WriteLine("------------------------------");
            Console.WriteLine("      Welcome to the Forge");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"=> {Material} Smelting {SmeltRate:0.##} / Salvage {SalvageRate:0.##}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            Console.Write("=> Choose Menu: ");
            string menuInput = Console.ReadLine() ?? "";

            Console.Write("=> How much would you like: ");
            string amountInput = Console.ReadLine() ?? "";

            char menu;
            double amount;

            bool menuValid = char.TryParse(menuInput, out menu);
            bool amountValid = double.TryParse(amountInput, out amount);

            if (menuValid && amountValid)
            {
                if (amount > 0 && amount <= MaxBatch)
                {
                    if (menu == 'S' || menu == 's')
                    {
                        double ingot = amount * SmeltRate;
                        Console.WriteLine($"=> {amount:F2} {Material} Ore = {ingot:F2} {Material} Ingot");
                    }
                    else if (menu == 'B' || menu == 'b')
                    {
                        double ore = amount / SalvageRate;
                        Console.WriteLine($"=> {amount:F2} {Material} Ingot = {ore:F2} {Material} Ore");
                    }
                    else
                    {
                        Console.WriteLine("error: menu");
                    }
                }
                else
                {
                    Console.WriteLine("error: amount");
                }
            }
            else if (!amountValid)
            {
                Console.WriteLine("error: amount");
            }
            else
            {
                Console.WriteLine("error: menu");
            }
        }
    }
}