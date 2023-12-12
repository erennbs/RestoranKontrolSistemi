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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        private bool GirisBasarili()
        {
            string dogruKullaniciAdi = "admin";
            string dogruSifre = "12345";

            string girilenKullaniciAdi = txtBoxKullaniciAdi.Text; 
            string girilenSifre = txtBoxSifre.Text; 

            if (girilenKullaniciAdi == dogruKullaniciAdi && girilenSifre == dogruSifre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            if (GirisBasarili())
            {
                this.Close();

                frmMain form1 = Application.OpenForms.OfType<frmMain>().FirstOrDefault();

                if (form1 != null)
                {
                    form1.BringToFront();
                }
                else
                {
                    form1 = new frmMain();
                    form1.Show();
                }
            }
            else
            {
                MessageBox.Show("Giriş başarısız. Lütfen bilgilerinizi kontrol edin.");
            }

        }

        private void AdminGiris_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
