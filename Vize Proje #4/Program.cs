using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_Proje__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yemekSecim, tatlisecim, icecekSecim, yemekPara, tatliPara, icecekPara, toplamHesap;
            string secim;
            while (true)
            {
                Console.WriteLine("YEMEKLER       TATLILAR       İÇECEKLER\n1-Lahmacun     1-Sütlaç       1-Ayran\n2-İskender     2-Baklava      2-Soda");
                Console.WriteLine("3-Döner        3-Katmer       3-Çay\n4-Köfte        4-Tiramisu     4-Su");
                Console.WriteLine("Not: Yemek,tatlı veya içecek sipariş etmek istemezsenin 0'a basınız.");
                Console.Write("Yemek seçiniz(1,2,3,4): ");
                yemekSecim=int.Parse(Console.ReadLine());
                Console.Write("Tatlınızı seçiniz(1,2,3,4):");
                tatlisecim=int.Parse(Console.ReadLine());
                Console.Write("İçeceğinizi seçiniz(1,2,3,4): ");
                icecekSecim=int.Parse(Console.ReadLine());
                if (yemekSecim == 1)
                {
                    yemekPara = 80;
                    Console.WriteLine("Lahmacun "+yemekPara+"TL");
                }
                else if (yemekSecim == 2)
                {
                    yemekPara = 150;
                    Console.WriteLine("İskender "+yemekPara+"TL");
                }
                else if (yemekSecim == 3)
                {
                    yemekPara = 75;
                    Console.WriteLine("Döner "+yemekPara+"TL");
                }
                else if (yemekSecim == 4)
                {
                    yemekPara = 90;
                    Console.WriteLine("Köfte "+yemekPara+"TL");
                }
                else
                {
                    yemekPara = 0;
                }


                if (tatlisecim == 1)
                {
                    tatliPara = 35;
                    Console.WriteLine("Sütlaç " + tatliPara + "TL");
                }
                else if (tatlisecim == 2)
                {
                    tatliPara = 45;
                    Console.WriteLine("Baklava " + tatliPara + "TL");
                }
                else if (tatlisecim == 3)
                {
                    tatliPara = 40;
                    Console.WriteLine("Katmer " + tatliPara + "TL");
                }
                else if (tatlisecim == 4)
                {
                    tatliPara = 43;
                    Console.WriteLine("Tiramisu " + tatliPara + "TL");
                }
                else
                {
                    tatliPara = 0;
                }


                if (icecekSecim == 1)
                {
                    icecekPara = 18;
                    Console.WriteLine("Ayran " + icecekPara + "TL");
                }
                else if (icecekSecim == 2)
                {
                    icecekPara = 15;
                    Console.WriteLine("Soda " + icecekPara + "TL");
                }
                else if (icecekSecim == 3)
                {
                    icecekPara =5;
                    Console.WriteLine("Çay " + icecekPara + "TL");
                }
                else if (icecekSecim == 4)
                {
                    icecekPara = 2;
                    Console.WriteLine("Su " + icecekPara + "TL");
                }
                else
                {
                    icecekPara = 0;
                }

                toplamHesap=yemekPara+tatliPara+icecekPara;
                Console.WriteLine("Ödenecek hesap tutarı: {0}\nÖdemenizi yapabilirsiniz.",toplamHesap);

                Console.WriteLine("\n\nTekrar sipariş vermek için: t\nMenüden çıkış yapmak için: q\n\nSeçiniz: ");
                secim=Console.ReadLine();

                if (secim == "t")
                {
                    Console.WriteLine("Yeniden sipariş verebilirsiniz.\n\n");
                }
                else if (secim == "q")
                {
                    Console.WriteLine("Menüden çıkış yapılıyor. Yine bekleriz.");
                    break;
                }

            }
            Console.ReadKey();
        }
    }
}
