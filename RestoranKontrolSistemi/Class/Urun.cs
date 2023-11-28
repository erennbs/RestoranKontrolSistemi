using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class {
    public class Urun {

        public string UrunAdi { get; private set; }

        public string UrunAciklama { get; private set; }
        
        public string UrunKategori { get; private set; }

        public float Fiyat { get; private set; }


        public Urun(string urunAdi, string urunAciklama, float fiyat, string kategori) {
            this.UrunAdi = urunAdi;
            this.UrunAciklama = urunAciklama;
            this.Fiyat = fiyat;
            this.UrunKategori = kategori;
        }
    }
}
