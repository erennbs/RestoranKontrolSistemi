using RestoranKontrolSistemi.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranKontrolSistemi.UserControls {
    public partial class MenuUC : UserControl {

        public static MenuUC Instance { get; private set; }
        string[] kategoriler = { "Başlangıç", "Ana Yemek", "Tatlı", "İçecek" };

        string productImageDir = Directory.GetCurrentDirectory() + @"\..\..\Images\ProductImage\";

        public MenuUC() {
            InitializeComponent();
            
            if(Instance == null) {
                Instance = this;
            } else {
                throw new Exception("Cannot have more than one instance of MenuUC!");
            }

            menuSplitContainer.Panel2Collapsed = true;

            UrunleriYaz();
            
        }

        public void UrunleriYaz() {
            foreach (Urun urun in Urunler.Instance.UrunlerList) {
                MenuItemUC item = new MenuItemUC();
                item.UrunuYaz(urun);
                menuPanel.Controls.Add(item);
            }
        }
        
        private void tsmiUrunEkle_Click(object sender, EventArgs e) {
            menuSplitContainer.Panel2Collapsed = false;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            menuSplitContainer.Panel2Collapsed = true;
        }

        private void btnEkle_Click(object sender, EventArgs e) {
            string ad = txtBoxAd.Text;
            string aciklama = txtBoxAciklama.Text;
            double fiyat;
            string kategori = cbKategori.Text;
            
            if (txtBoxAd.Text.Length == 0) {
                labelWarning.Text = "* Geçersiz Ad!";
                return;
            }

            if (!double.TryParse(txtBoxFiyat.Text.Replace(".", ","), out fiyat)) {
                labelWarning.Text = "* Geçersiz Fiyat!";
                return;
            }

            if (!kategoriler.Contains(kategori)) {
                labelWarning.Text = "* Geçersiz Kategori";
                return;
            }

            Urun yeniUrun = new Urun(ad, aciklama, fiyat, kategori, imgPath: ofdResim.FileName);

            if (ofdResim.FileName != "") {
                string img_path = ofdResim.FileName;
                File.Copy(img_path, Path.Combine(productImageDir, yeniUrun.UrunID.ToString() + ".png"));
                yeniUrun.ImgPath = productImageDir + yeniUrun.UrunID.ToString() + ".png";
            }

            Urunler.Instance.UrunEkle(yeniUrun);

            MenuItemUC newMenuItem = new MenuItemUC();
            newMenuItem.UrunuYaz(yeniUrun);
            newMenuItem.Width = 582;

            menuPanel.Controls.Add(newMenuItem);

            TextBoxTemizle();
        }

        private void TextBoxTemizle() {
            txtBoxAd.Clear();
            txtBoxAciklama.Clear();
            txtBoxFiyat.Clear();
            labelWarning.Text = "";
            cbKategori.SelectedIndex = 0;
            ofdResim.FileName = "";
            btnResimSec.Text = "Seç";
        }

        private void btnResimSec_Click(object sender, EventArgs e) {
            DialogResult result = ofdResim.ShowDialog();
            if (result == DialogResult.OK) {
                btnResimSec.Text = GetFileNameFromPath(ofdResim.FileName);
            }
        }

        private void tsmiDosyayaYaz_Click(object sender, EventArgs e) {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            
            StreamWriter file = new StreamWriter(desktopPath + @"\Menu.txt");

            foreach (Urun urun in Urunler.Instance.UrunlerList) {
                file.WriteLine(urun.UrunAdi + " - " + urun.Fiyat + "TL");
            }

            file.Close();
        }

        private string GetFileNameFromPath(string img_path) {
            string[] path = img_path.Split(Path.DirectorySeparatorChar);
            return path[path.Length - 1];
        }
    }
}
