namespace Lab05

{

    internal class Program
    {

        static void Main(string[] args)

        {

            Console.WriteLine("==> MY VIDEO GAME <==");

            Console.WriteLine("Hero vs. Villain -- Fight Damage Calculator\n");


            Console.WriteLine("Hero Health:");

            bool heroHealthValid = int.TryParse(Console.ReadLine(), out int heroHealth);

            Console.WriteLine("Hero Attack:");

            bool heroAttackValid = int.TryParse(Console.ReadLine(), out int heroAttack);

            Console.WriteLine("Hero Defense:");

            bool heroDefenseValid = int.TryParse(Console.ReadLine(), out int heroDefense);


            Console.WriteLine("Villain Health:");

            bool villainHealthValid = int.TryParse(Console.ReadLine(), out int villainHealth);

            Console.WriteLine("Villain Attack:");

            bool villainAttackValid = int.TryParse(Console.ReadLine(), out int villainAttack);

            Console.WriteLine("Villain Defense:");

            bool villainDefenseValid = int.TryParse(Console.ReadLine(), out int villainDefense);


            bool heroStartValid = heroHealthValid && heroAttackValid && heroDefenseValid;

            bool villainStartValid = villainHealthValid || villainAttackValid || villainDefenseValid;

            Console.WriteLine($"\nHero Start : {heroStartValid}");

            Console.WriteLine($"Villain Start : {villainStartValid}");

            Console.WriteLine($"[HERO]  HP: {heroHealth}  ATK: {heroAttack}  DEF: {heroDefense}");

            Console.WriteLine($"[VILLAIN]  HP: {villainHealth}  ATK: {villainAttack}  DEF: {villainDefense}");


            int potionHealth = 10;


            heroHealth += potionHealth;


            Console.WriteLine($"\nHero drinks a potion, heals  {potionHealth} HP . Hero HP: {heroHealth}");


            int normalDamage = Math.Max(0, heroAttack - villainDefense);

            Console.WriteLine($"Hero would deal normal  {normalDamage} damage.");


            int powerAttackDamage = Math.Max(0, (heroAttack * 2) - villainDefense);

            Console.WriteLine($"Hero would deal powerful {powerAttackDamage} damage.");


            Random rng = new Random();

            int criticalRoll = rng.Next(1, 101);

            bool isCritical = criticalRoll <= 25;


            int criticalDamage = normalDamage + Convert.ToInt32(isCritical) * normalDamage;

            Console.WriteLine($"Critical Roll: {criticalRoll} Critical Hit: {isCritical}");

            Console.WriteLine($"If critical hit player would deal {criticalDamage} damage.");

        }

    }

}