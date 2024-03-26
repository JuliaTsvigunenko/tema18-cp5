using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Product> products = new List<Product>();

            // Ввод данных о товарах с клавиатуры
            Console.WriteLine("Введите информацию о товарах (продукты, партии, комплекты). Для выхода введите 'exit'.");
            while (true)
            {
                Console.WriteLine("Введите тип товара (продукт, партия, комплект):");
                string productType = Console.ReadLine().ToLower();

                if (productType == "exit")
                    break;

                switch (productType)
                {
                    case "продукт":
                    case "product":
                        Item item = new Item();
                        item.DisplayInfo();
                        products.Add(item);
                        break;
                    case "партия":
                    case "batch":
                        Batch batch = new Batch();
                        batch.DisplayInfo();
                        products.Add(batch);
                        break;
                    case "комплект":
                    case "kit":
                        Set set = new Set();
                        set.DisplayInfo();
                        products.Add(set);
                        break;
                    default:
                        Console.WriteLine("Некорректный тип товара. Пожалуйста, введите 'продукт', 'партия' или 'комплект'.");
                        break;
                }
            }

            // Displaying full information from the database on the screen
            Console.WriteLine("Полная информация о товарах:");
            foreach (var product in products)
            {
                product.DisplayInfo();
            }

            // Finding expired goods
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("\nПросроченные товары:");
            foreach (var product in products)
            {
                if (product.IsExpired(currentDate))
                {
                    product.DisplayInfo();
                }
            }



            Console.ReadKey();










        }
    }
}
