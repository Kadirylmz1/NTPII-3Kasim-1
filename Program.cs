using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int alan, cevre;
            Dikdortgen yeniDikdortgen = new Dikdortgen(5,6);
            
            cevre = yeniDikdortgen.CevreHesapla();
            alan = yeniDikdortgen.AlanHesapla();

            Console.WriteLine("Alan=" + alan.ToString());
            Console.WriteLine("Cevre=" + cevre.ToString());

            yeniDikdortgen.TarihVer();

            Console.WriteLine("--------------------------------------");

            Ogrenci ogr1 = new Ogrenci("Ahmet", "Yılmaz", "2.Sınıf", 2324001, 123456789, 5550055);
            string ad = ogr1.OgrAdSoyadGonder().Split(';')[0];
            string soyad = ogr1.OgrAdSoyadGonder().Split(';')[1];

            Console.WriteLine("Ad:" + ad);
            Console.WriteLine("Soyad:" + soyad);






            Console.ReadKey();

        }
    }
}
