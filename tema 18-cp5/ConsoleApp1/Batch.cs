using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Производный класс Партия
    class Batch : Product
    {

        /// <summary>
        /// поле Количество
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// поле Дата Производства
        /// </summary>
        public DateTime ProductionDate { get; set; }
        /// <summary>
        /// поле Срок Годности
        /// </summary>
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Переопределение метода вывода информации о товаре
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Партия: {Name}\nЦена за единицу: {Price}\nКоличество: {Quantity}\nДата производства: {ProductionDate}\nСрок годности: {ExpiryDate}");
        }

        /// <summary>
        ///  Переопределение метода определения соответствия сроку годности
        /// </summary>
        /// <param name="currentDate">текущая дата</param>
        /// <returns></returns>
        public override bool IsExpired(DateTime currentDate)
        {
            return currentDate > ExpiryDate;
        }







    }
}
