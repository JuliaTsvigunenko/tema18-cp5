using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Производный класс Комплект
    class Set : Product
    {



        public List<Item> Products { get; set; }

        /// <summary>
        /// Переопределение метода вывода информации о товаре
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Комплект: {Name}, Цена: {Price}");
            Console.WriteLine("Продукты в комплекте:");
            foreach (var product in Products)
            {
                product.DisplayInfo();
            }
        }







    }
}
