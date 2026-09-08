/*
* Student ID : 1690700131
* Name       : jirayu usaneesawatchai
* Section    : 129A
* No.        :
* Course     : GI113 Computer Programming (GI
*/

using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. const (PascalCase) - ชื่อยานพาหนะ/ระบบ
            const string VesselName = "Starbound Dreadnought";

            // 2. var (camelCase) - ใช้กับ string และ char รวมกัน 2 ตัว
            var pilotCallsign = "Valkyrie-09";      // var บน string
            var engineClass = 'X';                 // var บน char

            // 3. ชนิดข้อมูลพื้นฐาน 6 แบบ (ครบถ้วนตามเกณฑ์):
            // string: pilotCallsign (ผ่าน var)
            // char: engineClass (ผ่าน var)
            // int: warpLevel
            // float: shieldPercentage
            // double: fuelCellLevel
            // bool: hyperdriveReady
            int warpLevel = 8;
            float shieldPercentage = 0.85f;
            double fuelCellLevel = 67.8;          // เลือกเลขหลังจุดเป็น .8 เพื่อให้ผลปัดเศษต่างกัน
            bool hyperdriveReady = true;

            // Display Output - เปลี่ยนเป็นธีม Dashboard ยานอวกาศ (ใช้ String Interpolation $ ทั้งหมด)
            Console.WriteLine($"/=========================================\\");
            Console.WriteLine($"|          VESSEL STATUS DASHBOARD        |");
            Console.WriteLine($"|-----------------------------------------|");
            Console.WriteLine($"| VESSEL    : {VesselName}");
            Console.WriteLine($"| PILOT     : {pilotCallsign}");
            Console.WriteLine($"| ENGINE    : CLASS-{engineClass}");
            Console.WriteLine($"| WARP LVL  : {warpLevel}");
            Console.WriteLine($"| SHIELD    : {shieldPercentage}");
            Console.WriteLine($"| FUEL CELL : {fuelCellLevel}%");
            Console.WriteLine($"| HYPERDRIVE: {hyperdriveReady}");
            Console.WriteLine($"\\=========================================/");
            Console.WriteLine();

            // 4. Implicit Conversion (เปลี่ยน int เป็น double โดยไม่มี cast)
            double warpLevelAsDouble = warpLevel;
            Console.WriteLine($"[LOG] Warp Level (Implicit Double): {warpLevelAsDouble}");

            // 5. Explicit Cast vs Convert.ToInt32() (ผลลัพธ์ต่างกันจริง)
            // (int) จะทำการตัดเศษทิ้งเสมอ -> 67
            int fuelTruncated = (int)fuelCellLevel;

            // Convert.ToInt32() จะทำการปัดเศษตามหลักคณิตศาสตร์ -> 68
            int fuelRounded = Convert.ToInt32(fuelCellLevel);

            Console.WriteLine($"[CAST] Fuel Level (Truncated)      : {fuelTruncated}");
            Console.WriteLine($"[CONV] Fuel Level (Rounded)        : {fuelRounded}");
            Console.WriteLine($"===========================================");
        }
    }
}