/*
 * Student ID : 1690704414
 * Name       :ธนบดี ธัญญาภิวัฒนา
 * Section    :129D
 * No.        :-
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Monster Battle ===");
            Console.WriteLine("A: Attack");
            Console.WriteLine("B: Run Away");
            Console.WriteLine("C: Heal");
            Console.Write("Choose your action: ");
            bool choiceOk = char.TryParse(Console.ReadLine(), out char choice);
            if (!choiceOk || (choice != 'A' && choice != 'a' &&
                              choice != 'B' && choice != 'b' &&
                              choice != 'C' && choice != 'c'))
            {
                Console.WriteLine("Invalid action. Please choose A, B or C.");
            }
            else if (choice == 'A' || choice == 'a')
            {
                Console.Write("Enter your HP: ");
                bool hpOk = int.TryParse(Console.ReadLine(), out int heroHp);
                if (!hpOk || heroHp <= 0)
                {
                    Console.WriteLine("Invalid HP. Please enter a positive number.");
                }
                else if (heroHp >= 50)
                {
                    Console.WriteLine("You attack the monster for 30 damage.");
                    Console.WriteLine("You defeat the monster!");
                }
                else
                {
                    Console.WriteLine("You attack the monster for 30 damage.");
                    Console.WriteLine("The monster hits you back!");
                }
            }
            else if (choice == 'B' || choice == 'b')
            {
                Console.Write("Enter your HP: ");
                bool hpOk = int.TryParse(Console.ReadLine(), out int heroHp);
                if (!hpOk || heroHp <= 0)
                {
                    Console.WriteLine("Invalid HP. Please enter a positive number.");
                }
                else if (heroHp >= 50)
                {
                    Console.WriteLine("You run away safely!");
                }
                else
                {
                    Console.WriteLine("The monster attacks you while you escape!");
                }
            }
            else
            {
                Console.Write("Enter your HP: ");
                bool hpOk = int.TryParse(Console.ReadLine(), out int heroHp);
                if (!hpOk || heroHp <= 0)
                {
                    Console.WriteLine("Invalid HP. Please enter a positive number.");
                }
                else if (heroHp >= 50)
                {
                    Console.WriteLine("You heal 20 HP and are ready to fight!");
                }
                else
                {
                    Console.WriteLine("You heal 20 HP and recover!");
                }
            }
            Console.WriteLine("Game Over.");
        }
    }
}
