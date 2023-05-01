using System;
using System.Collections.Generic;
using System.Linq;
namespace Practicing
{
    public class StonePaperScissors
    {
       public void StonePaperScissorsFunc()
        {
            string Firstplayer, Lastplayer;
            Console.WriteLine("Taş-Kagıt-Makas a hoş geldiniz*****");
            Console.WriteLine("                          ");
            Console.WriteLine("Lütfen 1.oyuncu seçim yapsın");
            Console.WriteLine("1-Taş \n2-Kagıt \n3-Makas \n4-Rastgele Seçim");
            Firstplayer = Console.ReadLine();
            Console.WriteLine("  1.Oyuncu Seçimi=" + Firstplayer);
            Console.WriteLine("          ");
            Console.WriteLine("Lütfen 2.oyuncu seçim yapsın");
            Console.WriteLine("1-Taş \n2-Kagıt \n3-Makas \n4-Rastgele Seçim");
            Lastplayer = Console.ReadLine();
            Console.WriteLine(" 2.Oyuncu Seçimi=" + Lastplayer);
            Console.WriteLine("              ");
            if (Firstplayer == "4")
            {
                Random random = new Random();
                Firstplayer = random.Next(1, 4).ToString();
            }
            if (Lastplayer == "4")
            {
                Random random = new Random();
                Lastplayer = random.Next(1, 4).ToString();
            }
            if (Firstplayer == "1" && Lastplayer == "1")
            {
                Console.WriteLine("Taş-Taş=Durum berabere");
            }
            else if (Firstplayer == "1" && Lastplayer == "2")
            {
                Console.WriteLine("Taş-Kagıt=Kazanan 2.Oyuncu");
            }
            else if (Firstplayer == "1" && Lastplayer == "3")
            {
                Console.WriteLine("Taş-Makas=Kazanan 1.Oyuncu");
            }

            if (Firstplayer == "2" && Lastplayer == "1")
            {
                Console.WriteLine("Kagıt-Taş=Kazanan 1.Oyuncu");
            }
            else if (Firstplayer == "2" && Lastplayer == "2")
            {
                Console.WriteLine("Kagıt-Kagıt=Durum Berabere");
            }
            else if (Firstplayer == "2" && Lastplayer == "3")
            {
                Console.WriteLine("Kagıt-Makas=Kazanan 2.Oyuncu");
            }

            if (Firstplayer == "3" && Lastplayer == "1")
            {
                Console.WriteLine("Makas-Taş=Kazanan 2.Oyuncu");
            }
            else if (Firstplayer == "3" && Lastplayer == "2")
            {
                Console.WriteLine("Makas-Kagıt=Kazanan 2.Oyuncu");
            }
            else if (Firstplayer == "3" && Lastplayer == "3")
            {
                Console.WriteLine("Makas-Makas=Durum Berabere ");
            }
            if (Firstplayer != "1" && Firstplayer != "2" && Firstplayer != "3" && Firstplayer != "4")
            {
                Console.WriteLine("1.Oyuncu Geçersiz seçime");
            }
            if (Lastplayer != "1" && Lastplayer != "2" && Lastplayer != "3" && Lastplayer != "4")
            {
                Console.WriteLine("2.Oyuncu Geçersiz seçime");
            }
        }
    }
}
