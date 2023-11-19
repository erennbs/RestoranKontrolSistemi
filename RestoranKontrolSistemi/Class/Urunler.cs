using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class {
    internal class Urunler {
        List<Urun> urunler;

        public List<Urun> UrunlerList { get; private set;}
        public static Urunler Instance { get; private set; }

        public Urunler() {
            urunler = new List<Urun>();
            UrunlerList = urunler;

            if (Instance == null) {
                Instance = this;
            } else {
                throw new Exception("Cannot have more than one instance of Urunler!");
            }
        }

        public void UrunEkle(Urun urun) {
            urunler.Add(urun);
        }

        public void UrunSil(Urun urun) {
            urunler.Remove(urun);
        }
    }
}
