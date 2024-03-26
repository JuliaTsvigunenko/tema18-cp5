using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Производный класс Продукт
    class Item : Product
    {
        /// <summary>
        /// Поле даты производства
        /// </summary>
        public DateTime ProductionDate { get; set; }

        /// <summary>
        /// Поле срока годности
        /// </summary>
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Переопределение метода вывода информации о товаре
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Продукт: {Name}\nЦена: {Price}\nДата производства: {ProductionDate}\nСрок годности: {ExpiryDate}");
        }

        /// <summary>
        /// Переопределение метода определения соответствия сроку годности
        /// </summary>
        /// <param name="currentDate">текущая дата</param>
        /// <returns></returns>
        public override bool IsExpired(DateTime currentDate)
        {
            return currentDate > ExpiryDate; // текущая дата > срок годности
        }








    }
}
