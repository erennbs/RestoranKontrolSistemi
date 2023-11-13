using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class
{
    internal class Urun
    {
        string urunAdi;
        string urunAciklama;
        float  fiyat;

        public Urun(string urunAdi, string urunAciklama, float fiyat) {
            this.urunAdi = urunAdi;
            this.urunAciklama = urunAciklama;
            this.fiyat = fiyat;
        }
    }
}
