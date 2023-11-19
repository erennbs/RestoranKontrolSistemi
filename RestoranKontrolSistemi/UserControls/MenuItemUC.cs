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

namespace RestoranKontrolSistemi.UserControls
{
    public partial class MenuItemUC : UserControl
    {
        Urun urun;

        public MenuItemUC()
        {
            InitializeComponent();
        }

        public void UrunuYaz(Urun urun) {
            this.urun = urun;
            this.Controls.Find("labelYemekAdi", false)[0].Text = urun.UrunAdi;
            this.Controls.Find("labelAciklama", false)[0].Text = urun.UrunAciklama;
            this.Controls.Find("labelFiyat", false)[0].Text = urun.Fiyat.ToString("f") + " TL";
        }

        private void tsmiSil_Click(object sender, EventArgs e) {
            MenuDeneme.urunler.Remove(this.urun);
            Console.WriteLine(MenuDeneme.urunler.Count);
            this.Parent.Controls.Remove(this);
        }
    }
}
