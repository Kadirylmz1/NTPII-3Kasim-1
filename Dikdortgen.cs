using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Dikdortgen
    {
        private int a, b;
        public Dikdortgen(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int AlanHesapla()
        {
            return a*b;
        }
        public int CevreHesapla()
        {
            return 2 * (a + b);
        }
        public void TarihVer()
        {
            Console.WriteLine("3 Kasım 2023");
        }
    }
}
