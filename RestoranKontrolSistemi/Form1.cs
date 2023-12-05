using RestoranKontrolSistemi.Class;
using RestoranKontrolSistemi.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranKontrolSistemi
{
    public partial class frmMain : Form
    {
        readonly Color buttonColor = Color.FromArgb(79, 111, 82);
        readonly Color buttonSelectedColor = Color.FromArgb(58, 77, 57);

        Button selectedButton = null;

        public frmMain()
        {
            InitializeComponent();

            // Initialize Urunler and Masalar
            Urunler urunler = new Urunler();
            Masalar masalar = new Masalar();

            // Start application with Masalar selected
            selectedButton = btnMasalar;
            btnMasalar.BackColor = buttonSelectedColor;

            MasalarUC masalarUC = new MasalarUC();
            masalarUC.Dock = DockStyle.Fill;
            bottomPanel.Controls.Add(masalarUC);

            
        }

        private void btnMasalar_Click(object sender, EventArgs e)
        {
            if(selectedButton != null) {
                selectedButton.BackColor = buttonColor;
            }
            selectedButton = btnMasalar;
            btnMasalar.BackColor = buttonSelectedColor;

            if (!(bottomPanel.Controls[0] is MasalarUC)) {
                bottomPanel.Controls.RemoveAt(0);
                
                if (MasalarUC.Instance != null) {
                    bottomPanel.Controls.Add(MasalarUC.Instance);
                } else {
                    MasalarUC masalarUC = new MasalarUC();
                    masalarUC.Dock = DockStyle.Fill;
                    bottomPanel.Controls.Add(masalarUC);
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (selectedButton != null) {
                selectedButton.BackColor = buttonColor;
            }
            selectedButton = btnMenu;
            btnMenu.BackColor = buttonSelectedColor;

            if (!(bottomPanel.Controls[0] is MenuUC))
            {
                bottomPanel.Controls.RemoveAt(0);
                
                if (MenuUC.Instance != null) {
                    bottomPanel.Controls.Add(MenuUC.Instance);
                } else { 
                MenuUC menuUC = new MenuUC();
                menuUC.Dock = DockStyle.Fill;
                bottomPanel.Controls.Add(menuUC);
                }
            }
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            if (selectedButton != null) {
                selectedButton.BackColor = buttonColor;
            }
            selectedButton = btnSiparisler;
            btnSiparisler.BackColor = buttonSelectedColor;

            if (!(bottomPanel.Controls[0] is MasalarUC))
            {
                bottomPanel.Controls.RemoveAt(0);
                SiparislerUC siparislerUC = new SiparislerUC();
                siparislerUC.Dock = DockStyle.Fill;
                bottomPanel.Controls.Add(siparislerUC);
            }
        }
        
    }
}
