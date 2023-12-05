using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class
{
    internal class Siparis : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public string UrunAdi { get; private set; }
        public int Miktar { get; set; }
        public float BazFiyat { get; private set; }
        public float NetFiyat { get; private set; }
        
        public Siparis(Urun urun, int miktar) { 

            this.UrunAdi = urun.UrunAdi;
            this.Miktar = miktar;
            this.BazFiyat = urun.Fiyat;
            this.NetFiyat = miktar * urun.Fiyat;
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

        private void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
