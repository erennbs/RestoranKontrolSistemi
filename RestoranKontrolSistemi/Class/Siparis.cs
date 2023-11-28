using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class
{
    internal class Siparis {

        public string UrunAdi { get; private set; }
        public int Miktar { get; set; }
        public float NetFiyat { get; private set; }
        
        public Siparis(Urun urun, int miktar) { 

            this.UrunAdi = urun.UrunAdi;
            this.Miktar = miktar;
            this.NetFiyat = miktar * urun.Fiyat;
        }
    }
}
