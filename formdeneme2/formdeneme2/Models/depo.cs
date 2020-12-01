using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace formdeneme2.Models
{
    public class depo
    {
        private static List<ogrenci> _ogrencis = new List<ogrenci>();


        public static List<ogrenci> ogrencis
        {
            get
            {
                return _ogrencis;
            }
        }

     
        public static void Addogrenci(ogrenci ogrenci)
        {
            _ogrencis.Add(ogrenci);
        }

    }
}

