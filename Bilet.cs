using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Bilet : Musteri
    {
        private int _fiyat;
        private int _ekonomikFiyat;
        private int _businessFiyat;
        private int _tabanFiyat;


        public Bilet(int ekonomikFiyat, int businessFiyat,int tabanFiyat)
        {
            EkonomikFiyat = ekonomikFiyat;
            BusinessFiyat = businessFiyat;
            TabanFiyat = tabanFiyat;
        }
        public int adet { get; set; }
        
        public int fiyat
        {
            get => _fiyat;
            set => _fiyat = value;
        }

        public int BusinessFiyat
        {
            get => _businessFiyat;
            set => _businessFiyat = value;
        }

        public int EkonomikFiyat
        {
            get => _ekonomikFiyat;
            set => _ekonomikFiyat = value;
        }

        public int TabanFiyat
        {
            get => _tabanFiyat;
            set => _tabanFiyat = value;
        }
    }
}
