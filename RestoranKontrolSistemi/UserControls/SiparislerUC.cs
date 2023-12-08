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
    public partial class SiparislerUC : UserControl
    {
        public static SiparislerUC Instance { get; private set; }


        public SiparislerUC()
        {
            InitializeComponent();

            if (Instance == null) {
                Instance = this;
            } else {
                throw new Exception("Cannot have more than one instance of SiparislerUC!");
            }

            dataGridSiparisQueue.AutoGenerateColumns = false;
            dataGridSiparisQueue.DataSource = Siparisler.Instance.SiparislerQueue;
        }

        private void btnBitir_Click(object sender, EventArgs e) {
            Siparis siparis = Siparisler.Instance.SıradanCikar();
        }
    }
}
