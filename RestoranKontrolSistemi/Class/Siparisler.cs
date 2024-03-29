﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranKontrolSistemi.Class {
    
    internal class Siparisler {
        
        public static Siparisler Instance { get; private set; }

        public BindingList<Siparis> SiparislerQueue { get; private set; }
        
        int maxID = 1;


        public Siparisler() { 
            if (Instance == null) {
                Instance = this;
            } else {
                throw new Exception("Cannot have more than one instance of Siparisler!");
            }

            SiparislerQueue = new BindingList<Siparis>();

            KayıtlıSiparisleriYaz();
        }

        public void KayıtlıSiparisleriYaz() {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["adminConnection"].ConnectionString)) {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT siparis_id, s.urun_id, miktar, masa_no, hazir FROM siparisler s LEFT JOIN urunler u ON u.urun_id = s.urun_id", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    Urun urun = Urunler.Instance.GetUrunWithID((int)reader[1]);
                    if (urun != null) {
                        Siparis newSiparis = new Siparis(urun, (int) reader[2], (int) reader[3], siparisID: (int) reader[0], (bool)reader[4]);

                        Masalar.Instance.MasalarList[(int)reader[3] - 1].SiparisEkle(newSiparis);
                    }

                    if ((int)reader[0] > maxID) maxID = (int)reader[0];

                }

                reader.Close();
            }
        }

        public void SırayaEkle(Siparis siparis) {
            SiparislerQueue.Add(siparis);
        }

        public Siparis SıradanCikar() {
            // Removes and returns the Siparis in the beginning of the list.
            if (SiparislerQueue.Count == 0) return null;
            
            Siparis siparis = SiparislerQueue[0];
            siparis.SiparisHazir();

            // Database urunu hazir hale getir
            SetReadySQL(siparis);

            SiparislerQueue.RemoveAt(0);
            return siparis;
        }

        public void SiparisIptalEt(Siparis siparis) {
            DeleteSiparisSQL(siparis);

            SiparislerQueue.Remove(siparis);
        }

        public int GenerateSiparisID() {
            return ++maxID;
        }

        private void DeleteSiparisSQL(Siparis siparis) {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["adminConnection"].ConnectionString)) {
                connection.Open();

                SqlCommand cmd = new SqlCommand($"DELETE FROM siparisler WHERE siparis_id = {siparis.siparisID}", connection);
                cmd.ExecuteNonQuery();
            }
        }

        private void SetReadySQL(Siparis siparis) {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["adminConnection"].ConnectionString)) {
                connection.Open();

                SqlCommand cmd = new SqlCommand($"UPDATE siparisler SET hazir = 1 WHERE siparis_id = {siparis.siparisID}", connection);
                cmd.ExecuteNonQuery();
            }
        }

    }


}
