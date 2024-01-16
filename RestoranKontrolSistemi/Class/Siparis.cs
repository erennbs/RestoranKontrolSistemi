using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class
{
    public class Siparis : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public int siparisID {  get; private set; }
        public string UrunAdi { get; private set; }
        public int Miktar { get; set; }
        private double BazFiyat { get; set; }
        public double NetFiyat { get; private set; }
        public bool Hazir {  get; private set; }
        public int MasaNumarasi { get; private set; }
        
        public Siparis(Urun urun, int miktar, int masaNumarasi, int siparisID = -1, bool hazir = false) { 

            this.siparisID = siparisID == -1 ? Siparisler.Instance.GenerateSiparisID(): siparisID;
            this.UrunAdi = urun.UrunAdi;
            this.Miktar = miktar;
            this.BazFiyat = urun.Fiyat;
            this.NetFiyat = miktar * urun.Fiyat;
            this.Hazir = hazir;
            this.MasaNumarasi = masaNumarasi;


            if (siparisID == -1) {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["adminConnection"].ConnectionString)) {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand($"INSERT INTO siparisler VALUES ({this.siparisID}, {urun.UrunID}, {Miktar}, {NetFiyat.ToString(CultureInfo.InvariantCulture)}, {(Hazir ? 1 : 0)}, {MasaNumarasi})", connection);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void MiktarArttır() {
            NetFiyat = NetFiyat / Miktar * ++Miktar;
            
            OnPropertyChanged("NetFiyat");
            OnPropertyChanged("Miktar");

            UpdateMiktarAndFiyatSQL();

            
        }

        public void FiyatGuncelle() {
            NetFiyat = BazFiyat * Miktar;

            OnPropertyChanged("NetFiyat");

            UpdateMiktarAndFiyatSQL();
        }

        public void SiparisHazir() {
            Hazir = true;
        }

        private void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void UpdateMiktarAndFiyatSQL() {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["adminConnection"].ConnectionString)) {
                connection.Open();
                    
                SqlCommand cmd = new SqlCommand($"UPDATE siparisler SET miktar={this.Miktar} WHERE siparis_id = {this.siparisID}", connection);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand($"UPDATE siparisler SET net_fiyat={this.NetFiyat.ToString(CultureInfo.InvariantCulture)} WHERE siparis_id = {this.siparisID}", connection);
                cmd.ExecuteNonQuery();
                
            }
        }
    }
}
