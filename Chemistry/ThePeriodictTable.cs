﻿using System.Collections.Generic;

namespace Chemistry.NETFramework.Library
{
    public class ThePeriodictTable
    {
        public Element GetElementByName(string name)
        {
            foreach (Element element in Elements)
            {
                if (element.Name == name)
                {
                    return element;
                }
            }
            return null;
        }
        public Element GetElementByShortName(string shortname)
        {
            foreach (Element element in Elements)
            {
                if (element.ShortName == shortname)
                {
                    return element;
                }
            }
            return null;
        }
        public Element GetElementBySerialNumber(int serialnumber)
        {
            foreach (Element element in Elements)
            {
                if (element.SerialNumber == serialnumber)
                {
                    return element;
                }
            }
            return null;
        }

        public List<Element> Elements
        {
            get
            {
                List<Element> temp = new List<Element>();
                /* Первый период */
                temp.Add(new Element("Водород", "H", "1s¹", 1, 1, 7, (float)0.0807, -259.1, 1.00794, true, false, new List<Element.Arbital> { new Element.Arbital(1) }));
                temp.Add(new Element("Гелий", "He", "1s²", 2, 1, 8, (float)0.00017, -272.2, 4.002602, true, false, new List<Element.Arbital> { new Element.Arbital(1) }));
                /* Второй период */
                temp.Add(new Element("Литий", "Li", "1s² 2s1", 3, 2, 1, (float)0.53, 180.5, 6.941, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(1) }));
                temp.Add(new Element("Берилий", "Be", "1s² 2s²", 4, 2, 2, (float)1.85, 1278, 9.012182, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(2) }));
                temp.Add(new Element("Бор", "B", "1s² 2s² 2p1", 5, 2, 3, (float)2.46, 2300, 10.811, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(3) }));
                temp.Add(new Element("Углерод", "C", "1s² 2s² 2p²", 6, 2, 4, (float)3.51, 3550, 12.0107, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(4) }));
                temp.Add(new Element("Азот", "N", "1s² 2s² 2p³", 7, 2, 5, (float)0.00117, -209.9, 14.0067, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(5) }));
                temp.Add(new Element("КислородТип", "O", "1s² 2s² 2p⁴", 8, 2, 6, (float)0.00133, -218.4, 15.9994, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(6) }));
                temp.Add(new Element("Фтор", "F", "1s² 2s² 2p⁵", 9, 2, 7, (float)0.00158, -219.6, 18.9984032, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(7) }));
                temp.Add(new Element("Неон", "F", "1s² 2s² 2p⁶", 10, 2, 8, (float)0.00084, -248.7, 20.1797, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8) }));
                /* Третий период */
                temp.Add(new Element("Натрий", "Na", "1s² 2s² 2p⁶ 3s¹", 11, 3, 1, (float)0.97, 97.8, 22.98976928, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(1) }));
                temp.Add(new Element("Магний", "Mg", "1s² 2s² 2p⁶ 3s²", 12, 3, 2, (float)1.74, 648.8, 24.3050, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(2) }));
                temp.Add(new Element("Алюминий", "Al", "1s² 2s² 2p⁶ 3s² 3p¹", 13, 3, 3, (float)2.7, 660.5, 26.9815386, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(3) }));
                temp.Add(new Element("Кремний", "Si", "1s² 2s² 2p⁶ 3s² 3p²", 14, 3, 4, (float)2.33, 1410, 28.0855, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(4) }));
                temp.Add(new Element("Фосвор", "P", "1s² 2s² 2p⁶ 3s² 3p³", 15, 3, 5, (float)1.82, 44, 30.973762, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(5) }));
                temp.Add(new Element("Сера", "S", "1s² 2s² 2p⁶ 3s² 3p⁴", 16, 3, 6, (float)2.06, 113, 32.065, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(6) }));
                temp.Add(new Element("Хлор", "Ci", "1s² 2s² 2p⁶ 3s² 3p⁵", 17, 3, 7, (float)0.00295, -101, 35.453, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(7) }));
                temp.Add(new Element("Аргон", "Ar", "1s² 2s² 2p⁶ 3s² 3p⁶", 18, 3, 8, (float)0.00166, -189.4, 39.948, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(8) }));
                /* Четвертый период #1 */
                temp.Add(new Element("Калий", "K", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s1", 19, 4, 8, (float)0.86, 63.7, 39.0983, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(8), new Element.Arbital(1) }));
                temp.Add(new Element("Кальций", "Ca", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s²", 20, 4, 1, (float)1.54, 839, 40.078, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(8), new Element.Arbital(2) }));
                temp.Add(new Element("Скандий", "Sc", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d1", 21, 2, 3, (float)2.99, 1539, 44.955912, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(9), new Element.Arbital(2) }));
                temp.Add(new Element("Титан", "Ti", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d2", 22, 4, 3, (float)4.51, 1660, 47.867, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(10), new Element.Arbital(2) }));
                temp.Add(new Element("Ванадин", "V", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d3", 23, 4, 4, (float)6.09, 1890, 50.9415, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(11), new Element.Arbital(2) }));
                temp.Add(new Element("Хром", "Cr", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s1 3d5", 24, 4, 5, (float)7.14, 1857, 51.9961, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(13), new Element.Arbital(1) }));
                temp.Add(new Element("Марганец", "Mn", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d5", 25, 6, 8, (float)7.44, 1244, 54.938045, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(13), new Element.Arbital(2) }));
                temp.Add(new Element("Железо", "Fe", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d6", 26, 4, 7, (float)7.87, 1535, 55.845, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(14), new Element.Arbital(2) }));
                temp.Add(new Element("Кобальт", "Co", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d7", 27, 4, 8, (float)8.89, 1495, 58.933195, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(15), new Element.Arbital(2) }));
                temp.Add(new Element("Никель", "Co", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d7", 28, 4, 8, (float)8.91, 1453, 58.6934, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(16), new Element.Arbital(2) }));
                /* Четвертый период #2 */
                temp.Add(new Element("Медь", "Cu", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s1 3d¹⁰", 29, 4, 1, (float)8.92, 1083.5, 63.546, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(1) }));
                temp.Add(new Element("Цинк", "Zn", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰", 30, 4, 2, (float)7.14, 419.6, 65.409, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(2) }));
                temp.Add(new Element("Галлий", "Ga", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p¹", 31, 4, 3, (float)5.91, 29.8, 69.723, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(3) }));
                temp.Add(new Element("Германий", "Ge", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p²", 32, 4, 4, (float)5.32, 937.4, 72.64, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(4) }));
                temp.Add(new Element("Мышьяк", "As", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p³", 33, 4, 5, (float)5.72, 613, 74.92160, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(5) }));
                temp.Add(new Element("Селен", "Se", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁴", 34, 4, 6, (float)4.82, 217, 78.96, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(6) }));
                temp.Add(new Element("Бром", "Br", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁵", 35, 4, 7, (float)3.14, -7.3, 79.904, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(7) }));
                temp.Add(new Element("Криптон", "Kr", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶", 36, 4, 8, (float)0.00348, -156.6, 83.798, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(8) }));
                /* Пятый период #1 */
                temp.Add(new Element("Рубидий", "Rb", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s¹", 37, 5, 1, (float)1.53, 39, 85.4678, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(8), new Element.Arbital(1) }));
                temp.Add(new Element("Стронций", "Sr", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s²", 38, 5, 2, (float)2.63, 769, 87.62, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(8), new Element.Arbital(2) }));
                temp.Add(new Element("Иттрий", "Y", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹", 39, 5, 3, (float)4.47, 1523, 88.90585, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(9), new Element.Arbital(2) }));
                temp.Add(new Element("Цирконий", "Zr", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d²", 40, 5, 4, (float)6.51, 1852, 91.224, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(10), new Element.Arbital(2) }));
                temp.Add(new Element("Ниобий", "Nb", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s¹ 4d4", 41, 5, 5, (float)8.58, 2468, 92.90638, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(12), new Element.Arbital(1) }));
                temp.Add(new Element("Молибден", "Mo", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s¹ 4d⁵", 42, 5, 6, (float)10.28, 2617, 95.94, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(13), new Element.Arbital(1) }));
                temp.Add(new Element("Технеций", "Tc", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d⁵", 43, 5, 7, (float)11.49, 2172, 98.9063, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(13), new Element.Arbital(2) }));
                temp.Add(new Element("Рутений", "Ru", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s¹ 4d⁷", 44, 5, 8, (float)12.45, 2310, 101.07, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(15), new Element.Arbital(1) }));
                temp.Add(new Element("Родий", "Rh", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s¹ 4d⁸", 45, 5, 9, (float)12.41, 1966, 102.90550, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(16), new Element.Arbital(1) }));
                temp.Add(new Element("Палладий", "Pd", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 4d¹⁰", 46, 5, 9, (float)12.02, 1552, 106.42, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(18) }));
                /* Пятый период #2 */
                temp.Add(new Element("Серебро", "Ag", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s¹ 4d¹⁰", 47, 5, 1, (float)10.49, 961.9, 107.8682, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(18), new Element.Arbital(1) }));
                temp.Add(new Element("Кадмий", "Cd", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰", 48, 5, 2, (float)8.64, 321, 112.411, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(18), new Element.Arbital(2) }));
                temp.Add(new Element("Индий", "In", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5s¹", 49, 5, 3, (float)7.31, 156.2, 114.818, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(18), new Element.Arbital(3) }));
                temp.Add(new Element("Олово", "Sn", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5s²", 50, 5, 4, (float)7.29, 232, 118.710, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(18), new Element.Arbital(4) }));
                temp.Add(new Element("Сурьма", "Sb", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p³", 51, 5, 5, (float)6.69, 630.7, 121.760, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(18), new Element.Arbital(5) }));
                temp.Add(new Element("Теллур", "Te", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁴", 52, 5, 6, (float)6.25, 449.6, 127.60, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(18), new Element.Arbital(6) }));
                temp.Add(new Element("Йод", "I", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁵", 53, 5, 7, (float)113.5, 4.94, 126.90447, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(18), new Element.Arbital(7) }));
                temp.Add(new Element("Ксенона", "Xe", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶", 54, 5, 8, (float)-111.9, 0.00449, 131.293, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(18), new Element.Arbital(8) }));
                /* Шестой период #1 */
                temp.Add(new Element("Цезий", "Cs", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s¹", 55, 6, 1, (float)28.4, 1.9, 132.9054519, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(18), new Element.Arbital(8), new Element.Arbital(1) }));
                temp.Add(new Element("Барий", "Ba", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s²", 56, 6, 2, 725, 3.65, 137.327, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(18), new Element.Arbital(8), new Element.Arbital(2) }));
                temp.Add(new Element("Лантан", "La", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 5d¹", 57, 6, 3, 920, 6.16, 138.90547, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(18), new Element.Arbital(9), new Element.Arbital(2) }));
                temp.Add(new Element("Гафний", "Hf", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d²", 72, 6, 4, 2150, 13.31, 178.49, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(10), new Element.Arbital(2) }));
                temp.Add(new Element("Тантал", "Ta", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d³", 73, 6, 5, 2996, 16.68, 180.9479, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(11), new Element.Arbital(2) }));
                temp.Add(new Element("Вольфрам", "W", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d⁴", 74, 6, 6, 3407, 19.26, 183.84, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(12), new Element.Arbital(2) }));
                temp.Add(new Element("Рений", "Re", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d⁵", 75, 6, 7, 3180, 21.03, 186.207, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(13), new Element.Arbital(2) }));
                temp.Add(new Element("Осмий", "Os", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d⁶", 76, 6, 8, 3045, 22.61, 190.23, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(14), new Element.Arbital(2) }));
                temp.Add(new Element("Иридий", "Ir", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d⁶", 77, 6, 9, 2410, 22.56, 192.217, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(15), new Element.Arbital(2) }));
                temp.Add(new Element("Платина", "Pt", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s¹ 4f¹⁴ 5d⁹", 78, 6, 9, 1772, 21.45, 195.084, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(17), new Element.Arbital(1) }));
                /* Шестой период #2 */
                temp.Add(new Element("Золото", "Au", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s¹ 4f¹⁴ 5d¹⁰", 79, 6, 1, (float)1064.4, 19.32, 196.966569, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(18), new Element.Arbital(1) }));
                temp.Add(new Element("Ртуть", "Hg", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰", 80, 6, 2, (float)-38.9, 13.55, 200.59, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(18), new Element.Arbital(2) }));
                temp.Add(new Element("Таллий", "Ti", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p¹", 81, 6, 3, (float)303.6, 11.85, 204.3833, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(18), new Element.Arbital(3) }));
                temp.Add(new Element("Свинец", "Pb", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p²", 82, 6, 4, (float)327.5, 11.34, 207.2, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(18), new Element.Arbital(4) }));
                temp.Add(new Element("Висмут", "Bi", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p³", 83, 6, 5, (float)271.4, 9.8, 208.98040, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(18), new Element.Arbital(5) }));
                temp.Add(new Element("Полоний", "Po", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁴", 84, 6, 6, 254, 9.2, 208.9824, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(18), new Element.Arbital(6) }));
                temp.Add(new Element("Астат", "At", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁵", 85, 6, 7, 302, 6.4, 209.9871, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(18), new Element.Arbital(7) }));
                temp.Add(new Element("Радон", "Rn", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶", 86, 6, 8, -71, 0.00923, 222.0176, true, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(18), new Element.Arbital(8) }));
                /* Седьмой период */
                temp.Add(new Element("Франций", "Fr", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s¹", 87, 7, 1, 27, 1.87, 223.0197, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(18), new Element.Arbital(8), new Element.Arbital(1) }));
                temp.Add(new Element("Радий", "Ra", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s²", 88, 7, 2, 700, 5.5, 226.0254, true, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(18), new Element.Arbital(8), new Element.Arbital(2) }));
                temp.Add(new Element("Активий", "Ac", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 6d¹", 89, 7, 3, 1047, 10.07, 227.0278, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(18), new Element.Arbital(9), new Element.Arbital(2) }));
                temp.Add(new Element("Резерфордий", "Rf", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f¹⁴ 6d²", 104, 7, 4, 0, 0, 267, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(32), new Element.Arbital(10), new Element.Arbital(2) }));
                temp.Add(new Element("Дубний", "Db", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f¹⁴ 6d³", 105, 7, 5, 0, 0, 268, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(32), new Element.Arbital(11), new Element.Arbital(2) }));
                temp.Add(new Element("Сиборгий", "Sg", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f¹⁴ 6d⁴", 106, 7, 6, 0, 0, 269, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(32), new Element.Arbital(12), new Element.Arbital(2) }));
                temp.Add(new Element("Борий", "Bh", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f¹⁴ 6d⁵", 107, 7, 7, 0, 0, 270, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(32), new Element.Arbital(13), new Element.Arbital(2) }));
                temp.Add(new Element("Хассий", "Hs", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f¹⁴ 6d⁶", 108, 7, 8, 0, 0, 277, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(32), new Element.Arbital(14), new Element.Arbital(2) }));
                temp.Add(new Element("Мейтнерий", "Mt", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f¹⁴ 6d⁷", 109, 7, 9, 0, 0, 278, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(32), new Element.Arbital(15), new Element.Arbital(2) }));
                temp.Add(new Element("Дармштадтий", "Ds", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f¹⁴ 6d⁸", 110, 7, 9, 0, 0, 281, false, false, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(32), new Element.Arbital(16), new Element.Arbital(2) }));
                /* Лантанойды */
                temp.Add(new Element("Церий", "Ce", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹ 5d¹", 58, -1, -1, 920, 6.16, 140.116, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(19), new Element.Arbital(9), new Element.Arbital(2) }, "Лантанойды"));
                temp.Add(new Element("Празеодим", "Pr", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f³", 59, -1, -1, 931, 6.48, 140.90765, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(21), new Element.Arbital(8), new Element.Arbital(2) }, "Лантанойды"));
                temp.Add(new Element("Неодим", "Nd", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f⁴", 60, -1, -1, 1010, 7, 144.242, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(22), new Element.Arbital(8), new Element.Arbital(2) }, "Лантанойды"));
                temp.Add(new Element("Прометий", "Pm", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f⁵", 61, -1, -1, 1080, 7.22, 146.9151, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(23), new Element.Arbital(8), new Element.Arbital(2) }, "Лантанойды"));
                temp.Add(new Element("Самарий", "Sm", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f⁶", 62, -1, -1, 1072, 7.54, 150.36, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(24), new Element.Arbital(8), new Element.Arbital(2) }, "Лантанойды"));
                temp.Add(new Element("Европий", "Eu", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f⁷", 63, -1, -1, 822, 5.25, 151.964, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(25), new Element.Arbital(8), new Element.Arbital(2) }, "Лантанойды"));
                temp.Add(new Element("Гадолоний", "Gd", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f⁷ 5d¹", 64, -1, -1, 1311, 7.89, 157.25, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(25), new Element.Arbital(9), new Element.Arbital(2) }, "Лантанойды"));
                temp.Add(new Element("Тербий", "Tb", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f⁹", 65, -1, -1, 1311, 7.89, 158.92535, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(27), new Element.Arbital(8), new Element.Arbital(2) }, "Лантанойды"));
                temp.Add(new Element("Диспрозий", "Dy", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁰", 66, -1, -1, 1409, 8.56, 162.500, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(28), new Element.Arbital(8), new Element.Arbital(2) }, "Лантанойды"));
                temp.Add(new Element("Гольмий", "Ho", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹¹", 67, -1, -1, 1470, 8.78, 164.93032, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(29), new Element.Arbital(8), new Element.Arbital(2) }, "Лантанойды"));
                temp.Add(new Element("Эрбий", "Er", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹²", 68, -1, -1, 1522, 9.05, 167.259, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(30), new Element.Arbital(8), new Element.Arbital(2) }, "Лантанойды"));
                temp.Add(new Element("Тулий", "Tm", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹³", 69, -1, -1, 1545, 9.32, 168.93421, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(31), new Element.Arbital(8), new Element.Arbital(2) }, "Лантанойды"));
                temp.Add(new Element("Иттербий", "Yb", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴", 70, -1, -1, 824, 6.97, 173.04, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(8), new Element.Arbital(2) }, "Лантанойды"));
                temp.Add(new Element("Лютеций", "Lu", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹", 71, -1, -1, 1656, 9.84, 174.967, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(9), new Element.Arbital(2) }, "Лантанойды"));
                /* Актинойды */
                temp.Add(new Element("Торий", "Th", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 6d²", 90, -2, -2, 1750, 11.72, 232.03806, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(18), new Element.Arbital(10), new Element.Arbital(2) }, "Актинойды"));
                temp.Add(new Element("Практоний", "Pa", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f² 6d¹", 91, -2, -2, 1554, 15.37, 231.03588, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(20), new Element.Arbital(9), new Element.Arbital(2) }, "Актинойды"));
                temp.Add(new Element("Уран", "U", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f³ 6d¹", 92, -2, -2, (float)1132.4, 18.97, 238.02891, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(21), new Element.Arbital(9), new Element.Arbital(2) }, "Актинойды"));
                temp.Add(new Element("Нептуний", "Np", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f⁴ 6d¹", 93, -2, -2, 640, 20.48, 237.0482, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(22), new Element.Arbital(9), new Element.Arbital(2) }, "Актинойды"));
                temp.Add(new Element("Плутоний", "Pu", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f⁶", 94, -2, -2, 641, 19.74, 244.0642, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(24), new Element.Arbital(8), new Element.Arbital(2) }, "Актинойды"));
                temp.Add(new Element("Америций", "Am", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f⁶", 95, -2, -2, 994, 13.67, 243.0614, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(25), new Element.Arbital(8), new Element.Arbital(2) }, "Актинойды"));
                temp.Add(new Element("Кюрий", "Cm", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f⁷ 6d¹", 96, -2, -2, 1340, 13.51, 247.0703, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(25), new Element.Arbital(9), new Element.Arbital(2) }, "Актинойды"));
                temp.Add(new Element("Берклий", "Bk", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f⁹", 97, -2, -2, 986, 13.25, 247.0703, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(27), new Element.Arbital(8), new Element.Arbital(2) }, "Актинойды"));
                temp.Add(new Element("Калифорний", "Cf", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f¹⁰", 98, -2, -2, 900, 15.1, 251.0796, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(28), new Element.Arbital(8), new Element.Arbital(2) }, "Актинойды"));
                temp.Add(new Element("Энштейн", "Es", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f¹¹", 99, -2, -2, 860, 13.5, 252.0829, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(29), new Element.Arbital(8), new Element.Arbital(2) }, "Актинойды"));
                temp.Add(new Element("Фермий", "Fm", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f¹²", 100, -2, -2, 0, 0, 257.0951, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(30), new Element.Arbital(8), new Element.Arbital(2) }, "Актинойды"));
                temp.Add(new Element("Менделейвий", "Md", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f¹³", 101, -2, -2, 0, 0, 258.0986, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(31), new Element.Arbital(8), new Element.Arbital(2) }, "Актинойды"));
                temp.Add(new Element("Необелий", "No", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f¹⁴", 102, -2, -2, 0, 0, 259.1009, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(32), new Element.Arbital(8), new Element.Arbital(2) }, "Актинойды"));
                temp.Add(new Element("Лоуренсий", "Lr", "1s² 2s² 2p⁶ 3s² 3p⁶ 4s² 3d¹⁰ 4p⁶ 5s² 4d¹⁰ 5p⁶ 6s² 4f¹⁴ 5d¹⁰ 6p⁶ 7s² 5f¹⁴ 6d¹", 103, -2, -2, 0, 0, 266, false, true, new List<Element.Arbital> { new Element.Arbital(2), new Element.Arbital(8), new Element.Arbital(18), new Element.Arbital(32), new Element.Arbital(32), new Element.Arbital(9), new Element.Arbital(2) }, "Актинойды"));
                return temp;
            }
        }
    }
}