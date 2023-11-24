using RestoranKontrolSistemi.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranKontrolSistemi.UserControls {
    public partial class MenuUC : UserControl {

        public static MenuUC Instance { get; private set; }
        string[] kategoriler = { "Başlangıç", "Ana Yemek", "Tatlı", "İçecek" };

        public MenuUC() {
            InitializeComponent();

            if(Instance == null) {
                Instance = this;
            } else {
                throw new Exception("Cannot have more than one instance of MenuUC!");
            }

            menuSplitContainer.Panel2Collapsed = true;

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
            float fiyat;
            string kategori = cbKategori.Text;
            
            if (txtBoxAd.Text.Length == 0) {
                labelWarning.Text = "* Geçersiz Ad!";
                return;
            }

            if (txtBoxAciklama.Text.Length == 0) {
                labelWarning.Text = "* Geçersiz Açıklama!";
                return;
            }

            if (!float.TryParse(txtBoxFiyat.Text.Replace(".", ","), out fiyat)) {
                labelWarning.Text = "* Geçersiz Fiyat!";
                return;
            }

            if (!kategoriler.Contains(kategori)) {
                labelWarning.Text = "* Geçersiz Kategori";
                return;
            }

            Urun yeniUrun = new Urun(ad, aciklama, fiyat, kategori);
            Urunler.Instance.UrunEkle(yeniUrun);
            
            MenuItemUC newMenuItem = new MenuItemUC();
            newMenuItem.UrunuYaz(yeniUrun);
            Console.WriteLine(newMenuItem.Size);
            Console.WriteLine(menuPanel.Size);

            menuPanel.Controls.Add(newMenuItem);
            menuPanel.Width = 510;
            Console.WriteLine(newMenuItem.Size);
            Console.WriteLine(menuPanel.Size);


            TextBoxTemizle();
        }

        private void TextBoxTemizle() {
            txtBoxAd.Clear();
            txtBoxAciklama.Clear();
            txtBoxFiyat.Clear();
            labelWarning.Text = "";
            cbKategori.SelectedIndex = 0;
        }
    }
}
