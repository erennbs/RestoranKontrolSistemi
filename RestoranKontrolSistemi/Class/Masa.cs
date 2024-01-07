using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using RestoranKontrolSistemi.UserControls;
using System.Configuration;
using System.Data.SqlClient;

namespace RestoranKontrolSistemi.Class
{
    internal class Masa
    {
        public int MasaNumarasi { get; private set; }
        public bool Dolu { get; private set; }
        public BindingList<Siparis> SiparislerList {  get; private set; }


        public Masa(int masaNumarasi, bool dolu) {
            this.MasaNumarasi = masaNumarasi;
            this.Dolu = dolu;
            this.SiparislerList = new BindingList<Siparis>();
        }

        public void MasaAc() {
            Dolu = true;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["adminConnection"].ConnectionString)) { 
                connection.Open();
                SqlCommand cmd = new SqlCommand($"update masalar set dolu = 1 where masa_no = {this.MasaNumarasi}", connection);
                cmd.ExecuteNonQuery();
            }
        }

        public void MasaKapat() {
            foreach (Siparis siparis in SiparislerList) {
                Siparisler.Instance.SiparisIptalEt(siparis);
            }
            SiparislerList.Clear();
            Dolu = false;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["adminConnection"].ConnectionString)) {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"update masalar set dolu = 0 where masa_no = {this.MasaNumarasi}", connection);
                cmd.ExecuteNonQuery();
            }
        }

        public void SiparisEkle(Siparis siparis) {
            SiparislerList.Add(siparis);
            Siparisler.Instance.SırayaEkle(siparis);
        }
    }
}
