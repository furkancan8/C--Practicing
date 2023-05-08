using System;
using System.Collections.Generic;
using System.Linq;

namespace Practicing
{
    public class Program
    {
        static void Main(string[] args)
        {
            SomeLatterFind someLatterFind = new SomeLatterFind();
            RomanCalculation romanCalculation = new RomanCalculation();
            StonePaperScissors stonePaperScissors = new StonePaperScissors();
            //romanCalculation.RomanCalculationFonc();
            //someLatterFind.SomeLatterFindFonc();
            //stonePaperScissors.StonePaperScissorsFunc();
            double Price = 45;
            double Kdv=0.15;
            double CompanyShare = 0.10;
            double KdvPrice = Price * Kdv;
            double OtherTaxPrice = Price * CompanyShare;
            double SellerPrice = Price - (OtherTaxPrice + KdvPrice);
            Console.WriteLine("Satıcıya kalan miktar=" + SellerPrice);

        }
       
    }
}
