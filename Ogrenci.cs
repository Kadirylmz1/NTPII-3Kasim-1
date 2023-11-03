using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Ogrenci
    {
        private string _ad, _soyad, _sinif;
        private int _ogrno, _tc, _tel;

        public Ogrenci(string ad, string soyad,
            string sinif, int ogrno, int tc, int tel)
        {
            this._ad = ad;
            this._soyad = soyad;
            this._sinif = sinif;
            this._ogrno = ogrno;
            this._tc = tc;
            this._tel = tel;
        }
        public string OgrAdSoyadGonder()
        {
            return (_ad + ";" + _soyad);
        }
    }
}
