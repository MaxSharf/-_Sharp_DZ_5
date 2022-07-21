using System;
using System.Collections.Generic;
using System.Text;

namespace С_Sharp_DZ_5
{
    public class Magazin
    {
        private string name { get; set; }
        private string years { get; set; }
        private string bescription { get; set; }
        private string phoneNumber { get; set; }
        private string email { get; set; }
        private int quantityEmployees { get; set; }
        public Magazin()
        {
            this.name = null;
            this.years = null;
            this.bescription = null;
            this.phoneNumber = null;
            this.email = null;
            this.quantityEmployees = 0;
        }


        public Magazin(string name, string year, string description, string phoneNumber, string email, int quantityEmployees) : this()
        {
            this.name = name;
            years = year;
            bescription = description;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.quantityEmployees = quantityEmployees;
        }

        public void EnterInfo()
        {
            Console.WriteLine("\nEnter data: ");
            Console.Write("Name  "); name = Console.ReadLine();
            Console.Write("Year  "); years = Console.ReadLine();
            Console.Write("Description "); bescription = Console.ReadLine();
            Console.Write("Phone Number "); phoneNumber = Console.ReadLine();
            Console.Write("Email "); email = Console.ReadLine();
            Console.Write("Quantity Employees "); quantityEmployees = Convert.ToInt32(Console.ReadLine());

        }

        public  void Out()
        {
            Console.WriteLine($"\n Інформація про клас Builder : \n Ім'я - {name} ,\n Вік - {years} ," +
                $"\n Опис - {bescription}  , \n Номер телефону - {phoneNumber} , \n Адрес електроної почти {email} , \n Кількість працівників {quantityEmployees} .");
        }


        public static int operator +(Magazin mgz, int num)
        {
            return ((int)(mgz.quantityEmployees += num));
        }
        public static int operator -(Magazin mgz, int num)
        {
            return ((int)(mgz.quantityEmployees -= num));
        }
        public static bool operator ==(Magazin mgz1, Magazin mgz2)
        {
            return mgz1.Equals(mgz2);
        }

        public static bool operator !=(Magazin mgz1, Magazin mgz2)
        {
            return !(mgz1 == mgz2);
        }

        public static bool operator <(Magazin mgz1, Magazin mgz2)
        {
            return (mgz1.quantityEmployees < mgz2.quantityEmployees);
        }
        public static bool operator >(Magazin mgz1, Magazin mgz2)
        {
            return (mgz1.quantityEmployees > mgz2.quantityEmployees);
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }




    }
}
