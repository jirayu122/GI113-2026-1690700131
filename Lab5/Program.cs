/*
* Student ID : 1690700131
* Name       : jirayu usaneesawatchai
* Section    : 129A
* No.        :
* Course     : GI113 Computer Programming (GI
*/

namespace Lad05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===> BATTLE MAGE <===");
            Console.WriteLine("Heoro vs. Monsters -- Fight Calculator ");

            // User input of Hero stats

            Console.Write("Hero Health: ");

            bool isHeroHp = int.TryParse(Console.ReadLine(), out int heroHp);

            Console.Write("Hero Attack: ");

            bool isHeroAtk = int.TryParse(Console.ReadLine(), out int heroAtk);

            Console.Write("Hero Defence: ");

            bool isHeroDef = int.TryParse(Console.ReadLine(), out int heroDef);

            // User input of Monster stats

            Console.Write("Monster Health: ");

            bool isMonHp = int.TryParse(Console.ReadLine(), out int monHp);

            Console.Write("Monster Attack: ");

            bool isMonAtk = int.TryParse(Console.ReadLine(), out int monAtk);

            Console.Write("Monster Defence: ");

            bool sMonDef = int.TryParse(Console.ReadLine(), out int monDef);

            // Check if player input is valid
            bool allHeroValid = isHeroHp && isHeroAtk && isHeroDef;
            bool allMonValid = isMonHp && isMonAtk && sMonDef;
            Console.WriteLine($"stats Validation: HERO: {allHeroValid}, MONSTER: {allMonValid}");
            Console.WriteLine($" [HERO]      HP: {heroHp} ATK: {heroAtk} DEF: {heroDef}");
            Console.WriteLine($" [MONSTER]   HP: {monHp} ATK: {monAtk} DEF: {monDef}");

            // คำนวน damage normal attack (Arithmetic + Math)
            int normalDamage = Math.Max(0, heroAtk - monDef);
            Console.WriteLine($"Normal Attack deal: {normalDamage} DMG");

            // คำนวน power attack (Predence iumwinom on rme au)
            int powerDamage = Math.Max(0, heroAtk * 2 - monDef); // เวียบลำดับ * มาก่อน - ไม่จำเป็นต้องมี()
            Console.WriteLine($"Power Attack deal: {powerDamage} DMG");

            // คำนวน Monster Attack
            int counterDamge = Math.Max(0, monAtk - heroDef);
            Console.WriteLine($"Monster Counter Attach deal: {counterDamge} DMG");

            // un Cri Chance
            Random rng = new Random();
            int roll = rng.Next(1, 101); // i Cri 1-100
            bool isCrit = roll <= 10; // 10|
            int criDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // โอกาส 10% ติดคริ เลขได้ 1
            Console.WriteLine($"\nCritical hit roll: (roll) (critical: {isCrit})");
            Console.WriteLine($"Normal Attack would deal Critical: {criDamage} DMG");
        }
    }
}