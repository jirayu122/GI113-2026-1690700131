/*
* Student ID : 1690700131
* Name       : jirayu usaneesawatchai
* Section    : 129A
* No.        :
* Course     : GI113 Computer Programming (GI
*/

class lab6
{
    static void Main()
    {
        Console.WriteLine("=== HERO VS MONSTER ===");
        Console.WriteLine("One Round Battle");
        Console.WriteLine();

        Console.Write("Enter Hero HP: ");
        bool ok1 = int.TryParse(Console.ReadLine(), out int heroHP);

        Console.Write("Enter Monster HP: ");
        bool ok2 = int.TryParse(Console.ReadLine(), out int monsterHP);

        Console.Write("Enter Hero Damage: ");
        bool ok3 = int.TryParse(Console.ReadLine(), out int heroDamage);

        Console.Write("Enter Monster Damage: ");
        bool ok4 = int.TryParse(Console.ReadLine(), out int monsterDamage);

        if (!ok1 || !ok2 || !ok3 || !ok4 ||
            heroHP <= 0 || monsterHP <= 0 ||
            heroDamage <= 0 || monsterDamage <= 0)
        {
            Console.WriteLine("Invalid input.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("--- Hero Turn ---");
            Console.WriteLine("Hero attacks the Monster!");

            monsterHP = monsterHP - heroDamage;

            if (monsterHP <= 0)
            {
                Console.WriteLine("Monster is defeated!");
                Console.WriteLine("Hero wins!");
            }
            else
            {
                Console.WriteLine("Monster HP: " + monsterHP);
                Console.WriteLine();
                Console.WriteLine("--- Monster Turn ---");
                Console.WriteLine("Monster attacks the Hero!");

                heroHP = heroHP - monsterDamage;

                if (heroHP <= 0)
                {
                    Console.WriteLine("Hero is defeated!");
                    Console.WriteLine("Monster wins!");
                }
                else if (heroHP > 0 && monsterHP > 0)
                {
                    Console.WriteLine("Hero HP: " + heroHP);
                    Console.WriteLine("Monster HP: " + monsterHP);
                    Console.WriteLine("The battle continues.");
                }
                else
                {
                    Console.WriteLine("Something went wrong.");
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Game Over.");
    }
}
