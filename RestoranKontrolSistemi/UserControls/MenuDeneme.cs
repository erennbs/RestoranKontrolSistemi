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
    public partial class MenuDeneme : UserControl {

        public static List<Urun> urunler = new List<Urun>();

        public MenuDeneme() {
            InitializeComponent();
            menuSplitContainer.Panel2Collapsed = true;

            foreach (Urun urun in urunler) {
                MenuItemUC item = new MenuItemUC();
                item.UrunuYaz(urun);
                menuPanel.Controls.Add(item);
            }
        }

        public void UrunEKle(Urun urun) {
            urunler.Add(urun);
            Console.WriteLine(urunler.Count);
        }

        public void UrunSil(Urun urun) {
            urunler.Remove(urun);
            Console.WriteLine(urunler.Count);
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

            Urun yeniUrun = new Urun(ad, aciklama, fiyat);
            UrunEKle(yeniUrun);
            
            MenuItemUC newMenuItem = new MenuItemUC();
            newMenuItem.UrunuYaz(yeniUrun);

            menuPanel.Controls.Add(newMenuItem);

            TextBoxTemizle();
        }

        private void TextBoxTemizle() {
            txtBoxAd.Clear();
            txtBoxAciklama.Clear();
            txtBoxFiyat.Clear();
            labelWarning.Text = "";
        }
    }
}
