using System;

/*
 * Student ID: 1690704414
 * Name: ธนบดี ธัญญาภิวัฒนา
 * Section: 129D
 * No.: -
 * Course: GI113 Computer Programming (GI)
 */

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Eternal Quest";

            var heroName = "Kael";
            var heroRank = 'S';

            int heroLevel = 32;
            float criticalChance = 0.42f;
            double stamina = 76.8;
            bool isPlayable = true;

            Console.WriteLine($"===== {GameTitle} =====");
            Console.WriteLine($"Hero Name      : {heroName}");
            Console.WriteLine($"Rank           : {heroRank}");
            Console.WriteLine($"Level          : {heroLevel}");
            Console.WriteLine($"Critical Chance: {criticalChance}");
            Console.WriteLine($"Stamina        : {stamina}");
            Console.WriteLine($"Playable       : {isPlayable}");
            Console.WriteLine();

            // Implicit Conversion: int -> double
            double levelAsDouble = heroLevel;
            Console.WriteLine(
                $"Level as double (implicit): {levelAsDouble}");

            // Explicit Cast: double -> int
            int staminaCast = (int)stamina;
            Console.WriteLine(
                $"Stamina cast (truncates)  : {staminaCast}");

            // Convert.ToInt32(): double -> int
            int staminaConvert = Convert.ToInt32(stamina);
            Console.WriteLine(
                $"Stamina Convert (rounds)  : {staminaConvert}");
        }
    }
}