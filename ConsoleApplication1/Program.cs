using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Info()
        {
            Console.WriteLine("\nTekan \"ESC \" untuk berhenti, atau tekan tombol lain untuk melanjutkan");
        }
        static void Main(string[] args)
        {
            Info();
            ConsoleKeyInfo C = Console.ReadKey();
            while (C.Key !=ConsoleKey.Escape)
            {
                int panjang;
                int lebar;

                Console.Write("Masukan panjang: ");
                panjang = int.Parse(Console.ReadLine());
                Thread.Sleep(1000);

                Console.Write("Masukan lebar: ");
                lebar = int.Parse(Console.ReadLine());
                Thread.Sleep(1000);

                Console.WriteLine("---------------");
                Console.WriteLine("luas persegi panjang: " + panjang * lebar);
                Thread.Sleep(1000);
                Console.WriteLine("keliling persegi: " + (2 * panjang) + (2 * lebar));
                Thread.Sleep(1000);
                Console.WriteLine("---------------");

                Info();
                C = Console.ReadKey();
            }
            
        }
    }
}
