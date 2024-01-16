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

            if (urun.ImgPath != null) {
                try {
                    pictureYemek.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), @"\..\..\Images\ProductImage\", urun.ImgPath));
                } catch (Exception e){
                    Console.WriteLine("Can't load image from " + urun.ImgPath);
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void tsmiSil_Click(object sender, EventArgs e) {
            pictureYemek.Image.Dispose();
            Urunler.Instance.UrunSil(this.urun);
            this.Parent.Controls.Remove(this);
        }



        

    }
}
