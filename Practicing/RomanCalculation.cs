using System;
using System.Collections.Generic;
using System.Text;

namespace Practicing
{
    public class RomanCalculation
    {
        public void RomanCalculationFonc()
        {
            string Input = "";
            int TotalNumber = 0;
            List<char> Output = new List<char>();
            Input = Console.ReadLine();
            for (int i = 0; i < Input.Length - 1; i++)
            {
                string kelimeler = Input.Substring(i, 2);
                if (kelimeler == "CM" && kelimeler != "MC")
                {
                    TotalNumber += 900;
                    Input = Input.Remove(i, 2);
                    i -= 1;
                }
                if (kelimeler == "MX" && kelimeler != "XM")
                {
                    TotalNumber += 900;
                    Input = Input.Remove(i, 2);
                    i -= 1;
                }
                if (kelimeler == "XC" && kelimeler != "CX")
                {
                    TotalNumber += 90;
                    Input = Input.Remove(i, 2);
                    i -= 1;
                }
                if (kelimeler == "IV" && kelimeler != "VI")
                {
                    TotalNumber += 4;
                    Input = Input.Remove(i, 2);
                    i -= 1;
                }
            }
            foreach (var item in Input)
            {
                Output.Add(item);
            }
            foreach (var item in Output)
            {
                Console.WriteLine(item);
                if (item == 'I')
                {
                    TotalNumber += 1;
                }
                else if (item == 'V')
                {
                    TotalNumber += 5;
                }
                else if (item == 'X')
                {
                    TotalNumber += 10;
                }
                else if (item == 'L')
                {
                    TotalNumber += 50;
                }
                else if (item == 'C')
                {
                    TotalNumber += 100;
                }
                else if (item == 'D')
                {
                    TotalNumber += 500;
                }
                else if (item == 'M')
                {
                    TotalNumber += 1000;
                }
            }
            Console.WriteLine("Roma rakamların toplam degeri= " + TotalNumber);
        }
    }
}
