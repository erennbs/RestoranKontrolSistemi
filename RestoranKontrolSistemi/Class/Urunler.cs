using RestoranKontrolSistemi.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class {
    internal class Urunler {
        public List<Urun> UrunlerList { get; private set; }
        public static Urunler Instance { get; private set; }

        public Urunler() {
            UrunlerList = new List<Urun>();

            if (Instance == null) {
                Instance = this;
            } else {
                throw new Exception("Cannot have more than one instance of Urunler!");
            }

            UrunlerList.Add(new Urun("Mercimek Çorbası", "Mis gibi, sıcacık...", 35, "Başlangıç"));
            UrunlerList.Add(new Urun("Kuru Fasülye", "Etli", 45, "Ana Yemek"));
            UrunlerList.Add(new Urun("Pilav", "Kuru fasülye ile ayrılmayan ikili", 40, "Ana Yemek"));
            UrunlerList.Add(new Urun("Ayran", "Köpüklü", 10, "İçecek"));
        }

        public void UrunEkle(Urun urun) {
            UrunlerList.Add(urun);
            MasalarUC.Instance.UrunlerListboxYenile();
        }

        public void UrunSil(Urun urun) {
            UrunlerList.Remove(urun);
            MasalarUC.Instance.UrunlerListboxYenile();
        }
    }
}
