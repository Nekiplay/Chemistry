using Chemistry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string fill = "=================================";
            ThePeriodictTable table = new ThePeriodictTable();
            start:
            Console.Write("Напишите название или порядковый номер элемента: ");
            string name = Console.ReadLine();
            int number = -1;
            int.TryParse(name, out number);
            Element element = null;
            if (number == 0)
            {
                element = table.GetElementByName(name);
                if (element == null)
                {
                    element = table.GetElementByShortName(name);
                }
            }
            else if (number > 0)
            {
                element = table.GetElementBySerialNumber(number);
            }
            if (element == null)
            {
                Console.Clear();
                Console.WriteLine("Элемент не найден");
                goto start;
            }
            Console.Clear();
            Console.WriteLine("Название: " + element.Name);
            Console.WriteLine("Буква: " + element.ShortName);
            Console.WriteLine("Порядковый номер: " + element.SerialNumber);
            if (!string.IsNullOrEmpty(element.Type))
            {
                Console.WriteLine("Тип: " + element.Type);
            }
            Console.WriteLine("Период: " + element.Period);
            Console.WriteLine("Масса: " + element.Mass);
            Console.WriteLine("Плотность: " + element.Density);
            Console.WriteLine("Точка плавления: " + element.MeltingPoint);
            Console.WriteLine(fill);
            Console.WriteLine("Группа: " + element.Group);
            if (element.MainGroup)
            {
                Console.WriteLine("Под группа: A");
            }
            else
            {
                Console.WriteLine("Под группа: B");
            }
            Console.WriteLine(fill);
            if (element.Metal)
            {
                Console.WriteLine("Метал: Да");
            }
            else
            {
                Console.WriteLine("Метал: Нет");
            }
            if (element.Oxidizer)
            {
                Console.WriteLine("Окислитель: Да");
            }
            else
            {
                Console.WriteLine("Восстановитель: Да");
            }
            Console.WriteLine(fill);
            Console.WriteLine("Электронная формула: " + element.ElectronicFormula);
            Console.WriteLine("Количество орбиталей: " + element.Arbitali.Count);
            Console.WriteLine(fill);
            int arbitaltemp = 1;
            foreach (Element.Arbital arbital in element.Arbitali)
            {
                Console.WriteLine("Орбиталь: " + arbitaltemp);
                Console.WriteLine("Количество электронов: " + arbital.Electron);
                Console.WriteLine(fill);
                arbitaltemp++;
            }
            Console.ReadKey();
            Console.Clear();
            goto start;
        }
    }
}
