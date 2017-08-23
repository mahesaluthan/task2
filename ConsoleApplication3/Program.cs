using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            double phi = 3.14;

            Console.Write("Masukan Jari-jari: ");
            r = int.Parse(Console.ReadLine());

            Console.WriteLine("Luas Lingkaran Adalah: " + r * r * phi);
            Console.WriteLine("keliling linkarannya: " + phi * 2 * r);

            Console.ReadLine();
            

        }
    }
}
