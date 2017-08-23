using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threading
{
    class Program
    {
        static void Main(string[] args)
        {
            int panjang;
            int lebar;

            Console.Write("Masukan Panjang: ");
            panjang = int.Parse(Console.ReadLine());
            Thread.Sleep(1000);
            Console.Write("Masukan Lebarnya: ");
            lebar = int.Parse(Console.ReadLine());
            Thread.Sleep(1000);

            Console.WriteLine("");
            Console.WriteLine("Luas persegi");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.Write(panjang);
            Thread.Sleep(1000);
            Console.Write(" X ");
            Thread.Sleep(1000);
            Console.Write(lebar);
            Thread.Sleep(1000);
            Console.Write(" = ");
            Thread.Sleep(1000);
            Console.Write(panjang * lebar);
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("Luas persegi adalah: {0}", panjang * lebar);

            Console.ReadLine();
            
        }
    }
}
