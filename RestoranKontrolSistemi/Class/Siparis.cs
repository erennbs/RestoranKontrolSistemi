using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class
{
    public class Siparis : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public string UrunAdi { get; private set; }
        public int Miktar { get; set; }
        private float BazFiyat { get; set; }
        public float NetFiyat { get; private set; }
        public bool Hazir {  get; private set; }
        public int MasaNumarasi { get; private set; }
        
        public Siparis(Urun urun, int miktar, int masaNumarasi) { 

            this.UrunAdi = urun.UrunAdi;
            this.Miktar = miktar;
            this.BazFiyat = urun.Fiyat;
            this.NetFiyat = miktar * urun.Fiyat;
            this.Hazir = false;
            this.MasaNumarasi = masaNumarasi;
        }

        public void MiktarArttır() {
            NetFiyat = NetFiyat / Miktar * ++Miktar;
            
            OnPropertyChanged("NetFiyat");
            OnPropertyChanged("Miktar");
        }

        public void FiyatGuncelle() {
            NetFiyat = BazFiyat * Miktar;

            OnPropertyChanged("NetFiyat");
        }

        public void SiparisHazir() {
            Hazir = true;
        }

        private void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
