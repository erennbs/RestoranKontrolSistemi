using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class {
    public class Urun {
        string urunAdi;
        string urunAciklama;
        string urunKategori;
        float fiyat;

        public string UrunAdi {
            get {return urunAdi;} }

        public string UrunAciklama {
            get { return urunAciklama;}
        }

        public float Fiyat {
            get { return fiyat;}
        }


        public Urun(string urunAdi, string urunAciklama, float fiyat) {
            this.urunAdi = urunAdi;
            this.urunAciklama = urunAciklama;
            this.fiyat = fiyat;
        }
    }
}
