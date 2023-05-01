using System;
using System.Collections.Generic;
using System.Text;

namespace Practicing
{
    public class SomeLatterFind
    {
        public void SomeLatterFindFonc()
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
