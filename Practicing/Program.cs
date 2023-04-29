using System;
using System.Collections.Generic;
using System.Linq;

namespace Practicing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.RomanCalculation();
            //p.SomeLatterFind();
            string TwoLetter = "abc";
            string input=Console.ReadLine();
            List<string> Letters = new List<string>();
            List<string> ResultLetters = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='2')
                {
                    Letters.Add("abc");
                }
                if (input[i] =='3')
                {
                    Letters.Add("def");
                }
              
            }
            foreach (var item in Letters)
            {

                for (int i = 0; i < item.Length; i++)
                {
                    string firstLetter = item.Substring(i, 1);
                    for (int j = 3; j < 7; j++)
                    {
                        string joinLetter = firstLetter[i].ToString() + item[j];
                        ResultLetters.Add(joinLetter);
                    }
                }
            }
            foreach (var item in ResultLetters)
            {
                Console.WriteLine(item);
            }
        }
        public void RomanCalculation()
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
            Console.WriteLine("Roma rakamların toplam degeri= "+TotalNumber);
        }
        public void SomeLatterFind()
        {
            string[] Input = new string[3] { "Domates", "Doy", "Doymam" };
            string CommonLatter = "";
            for (int i = 0; i < Input[0].Length; i++)
            {
                char harf = Input[0][i];
                //Console.WriteLine(harf);
                for (int j = 1; j < 2; j++)
                {
                    if (Input[j].Contains(harf))
                    {
                        CommonLatter += harf;
                    }
                }
            }
            Console.WriteLine($"Kelimler içindeki benzer harfler={CommonLatter}");
        }
    }
}
