using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302200052
{
    internal class Penjumlahan
    {
        public static void JumlahTigaAngka<T>(T bil1, T bil2, T bil3)
        {
            dynamic angka1 = bil1;
            dynamic angka2 = bil2;
            dynamic angka3 = bil3;

            Console.WriteLine(angka1 + angka2 + angka3 + "\n");

        }
    }
}
