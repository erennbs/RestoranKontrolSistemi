using RestoranKontrolSistemi.UserControls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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

            KayitliUrunleriYaz();
        }

        public void KayitliUrunleriYaz() {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["adminConnection"].ConnectionString)) {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM urunler", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    Urun newUrun = new Urun((string)reader[1], (string)reader[2], (float)reader[4], (string)reader[3], (int)reader[0]);
                    UrunlerList.Add(newUrun);
                }

                reader.Close();
            }
        }

        public void UrunEkle(Urun urun) {
            UrunlerList.Add(urun);
            MasalarUC.Instance.UrunlerListboxYenile();
        }

        public void UrunSil(Urun urun) {
            UrunlerList.Remove(urun);
            MasalarUC.Instance.UrunlerListboxYenile();
        }

        public Urun GetUrunWithID(int ID) {
            return UrunlerList.Where(urun => urun.UrunID == ID).FirstOrDefault();
        }

        public int GenerateUrunID() {
            if (UrunlerList.Count == 0) return 1;

            return UrunlerList[UrunlerList.Count - 1].UrunID + 1;
        }
    }
}
