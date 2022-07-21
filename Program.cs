using System;

namespace С_Sharp_DZ_5
{
   public class Program
    {
        static void Main()
        {
            //Program1();
            Program2();
            Console.ReadKey(true);
        }

        static void Program1()
        {
            var testMagazine = new Magazin("Forbs", "2022", "The richest people", "+1892229222", "Forbs@mail.com", 100);
            testMagazine.Out();
            var testMagazine2 = new Magazin();
            testMagazine2.EnterInfo();
            testMagazine2.Out();
        }

        public static void Program2()
        {
            var testShop = new Shop("Nike", "1964",
                "Sport produkt", "+1293746235", "nike@mail.com", 100000);
            testShop.PrintInfo();
        }



    }
}
