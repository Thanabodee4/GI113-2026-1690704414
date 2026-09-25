/*
 * Student ID : 1690704414
 * Name       : ธนบดี ธัญญาภิวัฒนา
 * Section    : 129D
 * No.        : 12
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  กำหนดค่าคงที่สำหรับชื่อวัสดุ, อัตราหลอมแร่, อัตราย่อยแร่ และจำนวนสูงสุดต่อรอบ
            const string Material = "Iron";
            const double SmeltRate = 0.25;
            const double SalvageRate = 0.30;
            const double MaxBatch = 500.0;

            //  แสดงข้อความต้อนรับและเมนูการใช้งานบนคอนโซล
            Console.WriteLine("------------------------------");
            Console.WriteLine("      Welcome to the Forge");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"=> {Material} Smelting {SmeltRate:0.##} / Salvage {SalvageRate:0.##}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            //  รับข้อความตัวเลือกเมนูจากผู้ใช้
            Console.Write("=> Choose Menu: ");
            string menuInput = Console.ReadLine() ?? "";

            //  รับข้อความจำนวนแร่/แท่งแร่จากผู้ใช้
            Console.Write("=> How much would you like: ");
            string amountInput = Console.ReadLine() ?? "";

            char menu;
            double amount;

            //  ตรวจสอบและแปลงค่าอินพุตด้วย TryParse (แปลงเมนูเป็นตัวอักษร และแปลงจำนวนเป็นตัวเลข)
            bool menuValid = char.TryParse(menuInput, out menu);
            bool amountValid = double.TryParse(amountInput, out amount);

            //  เช็กว่าทั้งเมนูและจำนวนแปลงค่าสำเร็จทั้งคู่หรือไม่
            if (menuValid && amountValid)
            {
                //  เช็กเงื่อนไขว่าจำนวนต้องมากกว่า 0 และไม่เกินค่า MaxBatch (500)
                if (amount > 0 && amount <= MaxBatch)
                {
                    //  ถ้าเลือกเมนู 'S' หรือ 's' ให้คำนวณหลอมแร่เป็นแท่ง (Smelt) แล้วแสดงผล
                    if (menu == 'S' || menu == 's')
                    {
                        double ingot = amount * SmeltRate;
                        Console.WriteLine($"=> {amount:F2} {Material} Ore = {ingot:F2} {Material} Ingot");
                    }
                    //  ถ้าเลือกเมนู 'B' หรือ 'b' ให้คำนวณย่อยแท่งแร่เป็นแร่ดิบ (Breakdown) แล้วแสดงผล
                    else if (menu == 'B' || menu == 'b')
                    {
                        double ore = amount / SalvageRate;
                        Console.WriteLine($"=> {amount:F2} {Material} Ingot = {ore:F2} {Material} Ore");
                    }
                    //  ถ้าใส่เมนูเป็นตัวอักษรอื่นที่ไม่ใช่ S หรือ B ให้แสดง error: menu
                    else
                    {
                        Console.WriteLine("error: menu");
                    }
                }
                //  ถ้าจำนวนไม่อยู่ในช่วง 1 ถึง 500 ให้แสดง error: amount
                else
                {
                    Console.WriteLine("error: amount");
                }
            }
            //  ถ้าผู้ใช้พิมพ์จำนวนไม่ถูกต้อง (ไม่ใช่ตัวเลข) ให้แสดง error: amount
            else if (!amountValid)
            {
                Console.WriteLine("error: amount");
            }
            //  ถ้าแปลงค่าเมนูไม่ผ่าน ให้แสดง error: menu
            else
            {
                Console.WriteLine("error: menu");
            }
        }
    }
}
