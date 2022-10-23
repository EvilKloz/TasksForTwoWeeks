﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.SarbaevZlokazov.Price
{
    public static class MarketAction
    {
        public static void SortPrice(ref List<Market> markets)
        {
            for (int i = 0; i < markets.Count; i++)
            {
                for (int j = 0; j < markets.Count - 1; j++)
                {
                    if (AlphabetSort(markets[i].MarketPlace, markets[j].MarketPlace))
                    {
                        Market empty = markets[i];
                        markets[i] = markets[j];
                        markets[j] = empty;
                    }
                }

            }
        }
        static public void Inicialise(ref List<Market> markets1, int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("Введите название продукта");

                string product = Console.ReadLine();
                Console.WriteLine("Введите название магазина");
                string marketplace = Console.ReadLine();
                Console.WriteLine("Введите цену товара");
                decimal price = 0;
                if (Decimal.TryParse(Console.ReadLine(), out price) == false || price <0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректное значение. По умолчанию установлен 0");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                markets1.Add(new Market(product, marketplace, price));
            }
        }
        private static bool AlphabetSort(string a, string b)
        {
            string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string aUp = a.ToUpper();
            string bUp = b.ToUpper();

            int counter = (a.Length < b.Length) ? a.Length : b.Length;

            for (int i = 0; i < counter; i++)
            {
                if (Alphabet.IndexOf(aUp[i]) < Alphabet.IndexOf(bUp[i]))
                {
                    return true;
                }
                else if (Alphabet.IndexOf(aUp[i]) == Alphabet.IndexOf(bUp[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }
        public static void FindMarketplace(string name, List<Market> markets1)
        {
            bool checker = false;
            Console.WriteLine("\nПо вашему запросу найдено\n");
            for (int i = 0; i < markets1.Count; i++)
            {
                if (markets1[i].MarketPlace == name)
                {
                    checker = true;
                    Console.WriteLine(markets1[i]);
                }
            }
            if (!checker)
            {
                Console.WriteLine("Ничего");
            }
        }

    }
}
