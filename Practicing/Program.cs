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
            stonePaperScissors.StonePaperScissorsFunc();
            
        }
    }
}
