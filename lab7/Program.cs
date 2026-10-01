/*
* Student ID : 1690700131
* Name       : jirayu usaneesawatchai
* Section    : 129A
* No.        :
* Course     : GI113 Computer Programming (GI
*/

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: ตั้งค่าการต่อสู้
            const int MonsterHp = 10;

            Console.Write("Monster Defense: ");
            int monsterDefense = 0;
            int.TryParse(Console.ReadLine(), out monsterDefense);

            Console.WriteLine($"A Slime appears! HP {MonsterHp}, DEF {monsterDefense}");
            Console.WriteLine();

            // Step 2: เมนูและ switch statement
            Console.WriteLine("=== BATTLE MENU ===");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Run");
            Console.WriteLine("5) Ice Spear"); // เพิ่ม Part B
            Console.Write("Choose (1-5): ");

            int command = 0;
            int.TryParse(Console.ReadLine(), out command);

            switch (command)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword!");
                    break;
                case 2:
                    Console.WriteLine("Hero casts Fire!");
                    break;
                case 3:
                    Console.WriteLine("Hero raises the shield.");
                    break;
                case 4:
                    Console.WriteLine("Hero looks for a way out...");
                    break;
                case 5:
                    Console.WriteLine("Hero hurls Ice Spear!");
                    break;
                default:
                    Console.WriteLine("Hero hesitates. Invalid command!");
                    break;
            }
            Console.WriteLine();

            // Step 3: พลังโจมตีด้วย switch expression
            int power = command switch
            {
                1 => 12,
                2 => 18,
                5 => 15, // Part B: Ice Spear
                _ => 0
            };

            int damage = Math.Max(0, power - monsterDefense);
            Console.WriteLine($"Damage: {damage}");

            // Step 4: ให้เกรดการโจมตีด้วย relational patterns
            string rating = damage switch
            {
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };
            Console.WriteLine($"Rating: {rating}");

            // Step 5: Slime ล้มหรือยัง? — ไม่ใช้ Ternary Operator
            string monsterStatus;
            if (damage >= MonsterHp)
            {
                monsterStatus = "DEFEATED";
            }
            else
            {
                monsterStatus = "still standing";
            }
            Console.WriteLine($"Slime: {monsterStatus}");
            Console.WriteLine();

            // Step 6: หนีจริงไหม? — หลาย label ใน section เดียว
            Console.Write("Really run away? (y/n): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n.");
                    break;
            }
        }
    }
}