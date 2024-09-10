using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double Gio = 0, loaico = 0,co = 0;
            bool count = true;
            while (count)
            {
                Console.WriteLine("Vui long chon loai gay ban muon su dung !");
                Console.WriteLine("\t Gay thuong (30k/h) => Bam phim 1");
                Console.WriteLine("\t Gay Vip (50k/h) => Bam phim 2");
                Console.Write("\t\t Lua chon cua ban la :"); a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    loaico = 30000;
                }
                else if (a == 2)
                {
                    loaico = 50000;
                }
                else
                {
                    continue;
                }
                Console.WriteLine("Ban co su dung them don co khong ?");
                Console.WriteLine("\t Co => Bam phim 1");
                Console.WriteLine("\t Khong => Bam phim 2");
                Console.Write("\t\t Lua chon cua ban la :"); b = int.Parse(Console.ReadLine());
                if (b == 1)
                {
                    co = 10000;
                }
                else if (b == 2)
                {
                    co = 0;
                }
                else
                {
                    continue;
                }
                Console.Write("Ban choi trong bao lau (gio) :"); string input = Console.ReadLine();
                if (double.TryParse(input, out Gio) && Gio > 0)
                {
                    count = false;
                }
                else
                {
                    continue;
                }
            }
            double tongTien = (loaico+co)*Gio;
            Console.WriteLine($"\t Tong tien phai tra la: {tongTien} VND");
            Console.ReadLine();
        }
    }
}

