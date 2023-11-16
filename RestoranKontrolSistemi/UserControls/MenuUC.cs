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
    public partial class MenuUC : UserControl
    {
        List<Urun> urunler = new List<Urun>();

        public MenuUC()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++) {
                Urun urun = new Urun("Çorba", "Çorba", 20);
                urunler.Add(urun);
            }

            for (int i = 0; i < 5; i++) {
                MenuItemUC item = new MenuItemUC();
                item.UrunuYaz(urunler[i]);
                this.menuPanel.Controls.Add(item);
            }
        }
    }
}
