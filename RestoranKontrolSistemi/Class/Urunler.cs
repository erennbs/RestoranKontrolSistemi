using RestoranKontrolSistemi.UserControls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                    Urun newUrun = new Urun((string)reader[1], (string)reader[2], (double)reader[4], (string)reader[3], (int)reader[0], ConvertFromDBVal<string>(reader[5]));
                    UrunlerList.Add(newUrun);
                }

                reader.Close();
            }
        }

        public void UrunEkle(Urun urun) {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["adminConnection"].ConnectionString)) {
                connection.Open();

                string img_path = urun.ImgPath == null ? "NULL" : $"'{urun.ImgPath}'";
                Console.WriteLine(img_path.Length.ToString());
                SqlCommand cmd = new SqlCommand($"INSERT INTO urunler VALUES ({urun.UrunID}, '{urun.UrunAdi}', '{urun.UrunAciklama}', '{urun.UrunKategori}', {urun.Fiyat.ToString(CultureInfo.InvariantCulture)}, {img_path})", connection);
                cmd.ExecuteNonQuery();
            }

            UrunlerList.Add(urun);
            MasalarUC.Instance.UrunlerListboxYenile();
        }

        public void UrunSil(Urun urun) {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["adminConnection"].ConnectionString)) {
                connection.Open();

                SqlCommand cmd = new SqlCommand($"DELETE FROM urunler WHERE urun_id = {urun.UrunID}", connection);
                cmd.ExecuteNonQuery();
            }

            File.Delete(Path.Combine(Directory.GetCurrentDirectory(), @"\..\..\Images\ProductImage\", urun.ImgPath));

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

        public static T ConvertFromDBVal<T>(object obj) {
            if (obj == null || obj == DBNull.Value) {
                return default(T); // returns the default value for the type
            }
            else {
                return (T)obj;
            }
        }
    }
}
