using System;
using System.Collections.Generic;
using System.Text;

namespace С_Sharp_DZ_5
{
    public class Shop
    {
        public string name { get; set; }
        public string year { get; set; }
        public string description { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public int Area { get; set; }

        public Shop()
        {
            this.name = null;
            this.year = null;
            this.description = null;
            this.phoneNumber = null;
            this.email = null;
            this.Area = 0;
        }

        public Shop(string name, string year, string description, string phoneNumber, string email , int Area)
        {
            this.name = name;
            this.year = year;
            this.description = description;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.Area = Area;
        }


        public void PrintInfo()
        {
            Console.WriteLine($"Виведення інформації про магазин :\n |Назва - {name},\n |Рік випуску - {year}," +
                $"\n |Опис - {description},\n |Контактний телефон - {phoneNumber}, \n |Адрес електроної почти - {email} ,\n |Площа {Area}.");
        }

        public static int operator +(Shop sh, int num)
        {
            return ((int)(sh.Area += num));
        }
        public static int operator -(Shop sh, int num)
        {
            return ((int)(sh.Area -= num));
        }
        public static bool operator ==(Shop sh1, Shop sh2)
        {
            return sh1.Equals(sh2);
        }

        public static bool operator !=(Shop sh1, Shop sh2)
        {
            return !(sh1 == sh2);
        }

        public static bool operator <(Shop sh1, Shop sh2)
        {
            return (sh1.Area < sh2.Area);
        }
        public static bool operator >(Shop sh1, Shop sh2)
        {
            return (sh1.Area > sh2.Area);
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
