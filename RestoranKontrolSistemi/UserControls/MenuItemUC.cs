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
        public MenuItemUC(string yemekAdi, string aciklama, float fiyat)
        {
            InitializeComponent();
            
            this.Controls.Find("labelYemekAdi", false)[0].Text = yemekAdi;
            this.Controls.Find("labelAciklama", false)[0].Text = aciklama;
            this.Controls.Find("labelFiyat", false)[0].Text = fiyat.ToString() + " TL";
        }
    }
}
