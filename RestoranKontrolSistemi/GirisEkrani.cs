﻿using System;
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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        private bool MasaGirisi()
        {
            string dogruMasa = "1";


            string girilenMasa = txtboxMasaNum.Text;


            if (girilenMasa == dogruMasa)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void linkLabelAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            this.Hide(); 

            AdminGiris adminForm = Application.OpenForms.OfType<AdminGiris>().FirstOrDefault();

            if (adminForm != null)
            {
                adminForm.BringToFront();
            }
            else
            {
                adminForm = new AdminGiris();
                adminForm.Show();
            }
        }

        private void GirisEkrani_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
