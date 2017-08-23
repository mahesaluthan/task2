using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nama;
            string Alamat;
            string umur;
            string Golongan_darah;

            Console.Write("Masukan nama Anda: ");
            Nama = Console.ReadLine();

            Console.Write("Masukan alamat Anda: ");
            Alamat = Console.ReadLine();

            Console.Write("Masukan umur Anda: ");
            umur = Console.ReadLine();

            Console.Write("Masukan golongan darah Anda: ");
            Golongan_darah = Console.ReadLine();

            Console.WriteLine("------------------------");
            Console.WriteLine("Nama anda adalah " + Nama);
            Console.WriteLine("Umur anda " + umur);
            Console.WriteLine("Anda tinggal di " + Alamat);
            Console.WriteLine("dan Golongan darah Anda adalah " + Golongan_darah);

            Console.ReadLine();

        }
    }
}
