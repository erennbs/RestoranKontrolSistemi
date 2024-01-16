using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class {
    public class Urun {

        public int UrunID { get; private set; }
        public string UrunAdi { get; private set; }

        public string UrunAciklama { get; private set; }
        
        public string UrunKategori { get; private set; }

        public double Fiyat { get; private set; }

        public string ImgPath { get; set; }


        public Urun(string urunAdi, string urunAciklama, double fiyat, string kategori, int urunID = -1, string imgPath = null) {
            this.UrunAdi = urunAdi;
            this.UrunAciklama = urunAciklama;
            this.Fiyat = fiyat;
            this.UrunKategori = kategori;
            this.UrunID = urunID == -1 ? Urunler.Instance.GenerateUrunID() : urunID;
            this.ImgPath = imgPath;
        }
    }
}
