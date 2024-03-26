using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Абстрактный класс Товар
    abstract class Product
    {
        /// <summary>
        /// Поле названия
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Поле цены
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Абстрактный метод вывода информации о товаре
        /// </summary>
        public abstract void DisplayInfo();

        /// <summary>
        /// Виртуальный метод определения соответствия сроку годности
        /// </summary>
        /// <param name="currentDate">текущая дата</param>
        /// <returns></returns>
        public virtual bool IsExpired(DateTime currentDate) // IsExpired - просрочен
        {
            return false; // По умолчанию товар не просрочен
        }






    }
}
