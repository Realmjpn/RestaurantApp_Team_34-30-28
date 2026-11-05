using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp_Team_34_30_28
{
    //เอาไว้ใน Namespace
    class Restaurant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }
    }

    internal class Program
    {
        static List<Restaurant> restaurants = new List<Restaurant>
    {
        new Restaurant { Name = "McDonald's", Type = "Fast Food", Rating = 4.2 },
        new Restaurant { Name = "Suki Teenoi", Type = "Suki", Rating = 4.7 },
        new Restaurant { Name = "Shinkanzen", Type = "Japanese", Rating = 4.8 },
        new Restaurant { Name = "Burger King", Type = "Fast Food", Rating = 4.5 },
        new Restaurant { Name = "Momo Paradise", Type = "Suki", Rating = 4.6 },
        new Restaurant { Name = "Izakaya", Type = "Japanese", Rating = 4.4 }
    };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Restaurant Menu =====");
                Console.WriteLine("1. Add Restaurant");
                Console.WriteLine("2. Show Good Rating");
                Console.WriteLine("3. Show Summary");
                Console.WriteLine("0. Exit");
                Console.Write("Select Menu: ");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        AddRestaurant();
                        break;
                    case "2":
                        ShowGoodRating();
                        break;
                    case "3":
                        ShowSummary();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid Menu");
                        break;
                }
            }
        }

        // เอ็ม รับผิดชอบ
        static void AddRestaurant()
        {
            Console.WriteLine("Not completed");
        }

        // ไนท์ รับผิดชอบ
        static void ShowGoodRating()
        {
            Console.WriteLine("Not completed");
        }

        // เดียว รับผิดชอบ
        static void ShowSummary()
        {
            Console.WriteLine("Not completed");
        }
    }


}
