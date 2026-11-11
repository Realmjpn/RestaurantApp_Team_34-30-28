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
            // เพิ่มร้านอาหารใหม่
            Console.WriteLine("\n===== Add Restaurant =====");
            // รับข้อมูลร้านอาหารจากผู้ใช้
            Console.Write("ใส่ชื่อร้าน : ");
            string name = Console.ReadLine();

            Console.Write("ใส่ประเภทร้าน : ");
            string type = Console.ReadLine();

            Console.Write("ใส่คะแนนร้าน : ");
            double rating = double.Parse(Console.ReadLine());
            // เพิ่มร้านอาหารใหม่ลงในรายการ
            restaurants.Add(new Restaurant { Name = name, Type = type, Rating = rating });
            Console.WriteLine("เพิ่มร้านอาหารเรียบร้อยแล้ว");

            Console.WriteLine("\n===== Show Restaurant =====");
            restaurants.ForEach(r => Console.WriteLine($"Name: {r.Name} Type: {r.Type} Rating: {r.Rating}"));
        }

        // ไนท์ รับผิดชอบ
        static void ShowGoodRating()
        {
            Console.WriteLine("\n===== Good Restaurants =====");

            foreach (var restaurant in restaurants)
            {
                if (restaurant.Rating >= 4.5)
                {
                    Console.WriteLine($"Name: {restaurant.Name} | Type: {restaurant.Type} | Rating: {restaurant.Rating}");
                }
            }
        }

        // เดียว รับผิดชอบ
        static void ShowSummary()
        {
            Restaurant highest = restaurants[0];
            Restaurant lowest = restaurants[0];

            foreach (Restaurant r in restaurants)
            {
                if (r.Rating > highest.Rating)
                {
                    highest = r;
                }

                if (r.Rating < lowest.Rating)
                {
                    lowest = r;
                }
            }

            Console.WriteLine("*********************************");
            Console.WriteLine("ร้านคะแนนสูงสุด: " + highest.Name);
            Console.WriteLine("คะแนน: " + highest.Rating);
            Console.WriteLine("*********************************");
            Console.WriteLine("ร้านคะแนนต่ำสุด: " + lowest.Name);
            Console.WriteLine("คะแนน: " + lowest.Rating);
            Console.WriteLine("*********************************");

        }
    }


}
