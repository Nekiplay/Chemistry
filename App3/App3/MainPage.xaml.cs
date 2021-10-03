using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            ThePeriodictTable table = new ThePeriodictTable();
            string name = e.NewTextValue;
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
            if (element != null)
            {
                string fill = "";
                label1.Text = "";
                label1.Text += "Название: " + element.Name + "\n";
                label1.Text += "Буква: " + element.ShortName + "\n";
                label1.Text += "Порядковый номер: " + element.SerialNumber + "\n";
                if (!string.IsNullOrEmpty(element.Type))
                {
                    label1.Text += "Тип: " + element.Type + "\n";
                }
                label1.Text += "Период: " + element.Period + "\n";
                label1.Text += "Масса: " + element.Mass + "\n";
                label1.Text += "Плотность: " + element.Density + "\n";
                label1.Text += "Точка плавления: " + element.MeltingPoint + "\n";
                label1.Text += fill + "\n";
                label1.Text += "Группа: " + element.Group + "\n";
                if (element.MainGroup)
                {
                    label1.Text += "Под группа: A" + "\n";
                }
                else
                {
                    label1.Text += "Под группа: B" + "\n";
                }
                label1.Text += fill + "\n";
                if (element.Metal)
                {
                    label1.Text += "Метал: Да" + "\n";
                }
                else
                {
                    label1.Text += "Метал: Нет" + "\n";
                }
                if (element.Oxidizer)
                {
                    label1.Text += "Окислитель: Да" + "\n";
                }
                else
                {
                    label1.Text += "Восстановитель: Да" + "\n";
                }
                label1.Text += fill + "\n";
                label1.Text += "Электронная формула: " + element.ElectronicFormula + "\n";
                label1.Text += "Количество орбиталей: " + element.Arbitali.Count + "\n";
                label1.Text += fill + "\n";
                int arbitaltemp = 1;
                foreach (Element.Arbital arbital in element.Arbitali)
                {
                    label1.Text += "Орбиталь: " + arbitaltemp + "\n";
                    label1.Text += "Количество электронов: " + arbital.Electron + "\n";
                    label1.Text += fill + "\n";
                    arbitaltemp++;
                }
            }
        }
    }
}
