using RestoranKontrolSistemi.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranKontrolSistemi.UserControls
{
    public partial class MasalarUC : UserControl
    {
        public static MasalarUC Instance {  get; private set; }

        Color softRed = Color.FromArgb(187, 37, 37);
        Color softGreen = Color.FromArgb(115, 144, 114);
        
        Masa masaSelected;
        Button masaButtonSelected;

        public MasalarUC()
        {
            InitializeComponent();

            if (Instance == null) {
                Instance = this;
            }
            else {
                throw new Exception("Cannot have more than one instance of MasalarUC!");
            }

            UrunlerListboxYenile();
            
            masalarSplitContainer.Panel2Collapsed = true;

            MasalariEkle();

            //for (int i = 0; i < 10; i++) {
            //    Button newButton = new Button();
            //    newButton.Size = new Size(120, 90);
            //    newButton.Text = "Masa " + i.ToString();
            //    newButton.Click += button_Click;

            //    flpMasalar.Controls.Add(newButton);
            //}

        }

        void MasalariEkle() {

            for (int i = 0; i < Masalar.Instance.MasalarList.Count(); i++) {
                Button newButton = new Button();
                newButton.Text = "Masa " + (i + 1).ToString();
                newButton.Size = new Size(120, 90);
                newButton.Click += button_Click;

                flpMasalar.Controls.Add(newButton);
            }
        }

        public void UrunlerListboxYenile() {
            lbUrunler.Items.Clear();
            
            foreach(Urun urun in Urunler.Instance.UrunlerList) {
                lbUrunler.Items.Add(urun.UrunAdi);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            masalarSplitContainer.Panel2Collapsed = true;
        }

        private void button_Click(object sender, EventArgs e) {
            Button button_clicked = (Button)sender;
            int index = flpMasalar.Controls.IndexOf(button_clicked);

            Masa masa = Masalar.Instance.MasalarList[index];
            masaSelected = masa;
            masaButtonSelected = button_clicked;

            masalarSplitContainer.Panel2Collapsed = false;
            lblMasa.Text = "Masa " + masa.MasaNumarasi;

            dataGridSiparis.DataSource = masa.SiparislerList;
        }

        private void lbUrunler_SelectedIndexChanged(object sender, EventArgs e) {
            if (!masaSelected.Dolu || lbUrunler.SelectedIndex == -1) return;

            IEnumerable<Urun> urunQuery = Urunler.Instance.UrunlerList.Where<Urun>(urun => urun.UrunAdi == lbUrunler.Text);
                //from urun in Urunler.Instance.UrunlerList
                //where urun.UrunAdi == lbUrunler.Text
                //select urun;

            Urun urunFound = urunQuery.FirstOrDefault();

            IEnumerable<Siparis> siparisQuery =
                from siparis in masaSelected.SiparislerList
                where siparis.UrunAdi == lbUrunler.Text
                select siparis;

            Siparis siparisFound = siparisQuery.FirstOrDefault();

            if (siparisFound == null) {
                masaSelected.SiparisEkle(new Siparis(urunFound, 1));
            } else {
                siparisFound.MiktarArttır();
            }

            lbUrunler.ClearSelected();
            DataGridYenile();

        }

        private void btnMasaAcKapa_Click(object sender, EventArgs e) {
            if (masaSelected.Dolu) {
                masaSelected.MasaKapat();
                btnMasaAcKapa.Text = "Masa Aç";
                masaButtonSelected.BackColor = SystemColors.ControlLightLight;
                masaButtonSelected.ForeColor = SystemColors.WindowText;
            }
            else {
                masaSelected.MasaAc();
                btnMasaAcKapa.Text = "Masa Kapat";
                masaButtonSelected.BackColor = softRed;
                masaButtonSelected.ForeColor = Color.White;
            }
            
            DataGridYenile();
        }

        private void DataGridYenile() {
            dataGridSiparis.ResetBindings();
        }

        private void dataGridSiparis_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            int value;

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if(int.TryParse(dataGridSiparis.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out value)) {
                masaSelected.SiparislerList[e.RowIndex].FiyatGuncelle();
            } else {
                
            }

        }

        private void dataGridSiparis_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            dataGridSiparis.CancelEdit();
            MessageBox.Show("Miktar Sayı Olmalıdır!", "Hata");
        }

        private void dataGridSiparis_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {
            Console.WriteLine(masaSelected.SiparislerList.Count.ToString());
        }
    }
}
