using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class {
    internal class Masalar {

        List<Masa> masalarList;

        public List<Masa> MasalarList { get { return masalarList; } }

        public static Masalar Instance { get; private set; }
        
        public Masalar() {
            masalarList = new List<Masa>();
            
            if (Instance == null) {
                Instance = this;
            }
            else {
                throw new Exception("Cannot have more than one instance of Masalar!");
            }

            // Masaları database'den ekle
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["adminConnection"].ConnectionString)) {
                connection.Open();
                
                SqlCommand cmd = new SqlCommand("select * from masalar", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    Masa newMasa = new Masa((int) reader[0], (bool) reader[1]);
                    masalarList.Add(newMasa);
                }

                reader.Close();
            }
        }

        public void MasaEkle() {
            Masa masa = new Masa(MasalarList.Count + 1, false);
            
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["adminConnection"].ConnectionString)) {
                connection.Open();

                SqlCommand cmd = new SqlCommand($"INSERT INTO masalar VALUES ({masa.MasaNumarasi}, {(masa.Dolu ? 1 : 0)})", connection);
                cmd.ExecuteNonQuery();
            }

            MasalarList.Add(new Masa(MasalarList.Count + 1, false));
        }

        public void MasaSil() {
            foreach (Siparis siparis in GetLastElement().SiparislerList) {
                Siparisler.Instance.SiparisIptalEt(siparis);
            }

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["adminConnection"].ConnectionString)) {
                connection.Open();

                SqlCommand cmd = new SqlCommand($"DELETE FROM masalar WHERE masa_no = {MasalarList.Count}", connection);
                cmd.ExecuteNonQuery();
            }
            
            masalarList.RemoveAt(masalarList.Count - 1);
        }

        public Masa GetLastElement() {
            if (masalarList.Count == 0) return null;

            return masalarList[masalarList.Count - 1];
        }
    }
}
