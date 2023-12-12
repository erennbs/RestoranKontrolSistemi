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

            dataGridSiparis.AutoGenerateColumns = false;
            masalarSplitContainer.Panel2Collapsed = true;

            MasalariEkle();

        }

        void MasalariEkle() {

            for (int i = 0; i < Masalar.Instance.MasalarList.Count(); i++) {
                Button newButton = new Button();
                newButton.Text = "Masa " + (i + 1).ToString();
                newButton.Size = new Size(120, 90);
                newButton.Font = new Font("Microsoft New Tai Lue", 10);
                newButton.Click += button_Click;

                flpMasalar.Controls.Add(newButton);
            }
        }

        public void YeniMasaEkle() {
            Masalar.Instance.MasaEkle();

            Button newButton = new Button();
            newButton.Text = "Masa " + (Masalar.Instance.MasalarList.Count).ToString();
            newButton.Size = new Size(140, 97);
            newButton.Font = new Font("Microsoft New Tai Lue", 10);
            newButton.Click += button_Click;

            flpMasalar.Controls.Add(newButton);

            ProgressBarGuncelle();
        }

        public void MasaSil() {
            if (Masalar.Instance.MasalarList.Count == 0) return;

            if (masaSelected == Masalar.Instance.GetLastElement()) {
                masalarSplitContainer.Panel2Collapsed = true;
            }

            Masalar.Instance.MasaSil();

            flpMasalar.Controls.RemoveAt(flpMasalar.Controls.Count - 1);

            ProgressBarGuncelle();
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

            ToplamFiyatYaz();

            dataGridSiparis.DataSource = masa.SiparislerList;
            if (masa.Dolu == false) {
                btnMasaAcKapa.Text = "Masa Aç";
            } else {
                btnMasaAcKapa.Text = "Masa Kapat";
            }
        }

        private void lbUrunler_SelectedIndexChanged(object sender, EventArgs e) {
            if (!masaSelected.Dolu || lbUrunler.SelectedIndex == -1) return;

            IEnumerable<Urun> urunQuery = Urunler.Instance.UrunlerList.Where<Urun>(urun => urun.UrunAdi == lbUrunler.Text);

            Urun urunFound = urunQuery.FirstOrDefault();

            IEnumerable<Siparis> siparisQuery =
                from siparis in masaSelected.SiparislerList
                where siparis.UrunAdi == lbUrunler.Text
                select siparis;

            Siparis siparisFound = siparisQuery.FirstOrDefault();

            if (siparisFound == null || siparisFound.Hazir) {
                masaSelected.SiparisEkle(new Siparis(urunFound, 1, masaSelected.MasaNumarasi));
            }
            else {
                siparisFound.MiktarArttır();
            }

            ToplamFiyatYaz();
            lbUrunler.ClearSelected();

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

            ProgressBarGuncelle();
        }

        private void ProgressBarGuncelle() {
            float val;
            if (Masalar.Instance.MasalarList.Count == 0) {
                val = 0;
            } else {
                val = (float)Masalar.Instance.MasalarList.Where(masa => masa.Dolu).Count() / Masalar.Instance.MasalarList.Count * 100;
                Console.WriteLine((Masalar.Instance.MasalarList.Where(masa => masa.Dolu).Count() / Masalar.Instance.MasalarList.Count));
            }

            ((frmMain)Application.OpenForms[Application.OpenForms.Count - 1]).SetProgressBar((int)val);
        }

        private void ToplamFiyatYaz() {
            // Secilen masanın siparislerinin toplam fiyatini hesapla.
            float toplam = 0;

            foreach (Siparis siparis in masaSelected.SiparislerList) {
                toplam += siparis.NetFiyat;
            }

            lblToplam.Text = "Toplam: " + toplam.ToString() + " TL";
        }

        private void dataGridSiparis_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            int value;

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (int.TryParse(dataGridSiparis.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out value)) {
                if (value == 0) {
                    Siparisler.Instance.SiparisIptalEt(masaSelected.SiparislerList[e.RowIndex]);
                    masaSelected.SiparislerList.Remove(masaSelected.SiparislerList[e.RowIndex]);
                } else {
                    masaSelected.SiparislerList[e.RowIndex].FiyatGuncelle();
                }
            }
            ToplamFiyatYaz();

        }

        private void dataGridSiparis_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            dataGridSiparis.CancelEdit();
            MessageBox.Show("Miktar Sayı Olmalıdır!", "Hata");
        }

        private void dataGridSiparis_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
            if (e.Row.Index < 0) return;

            // Siparis hazir ise silinmesin
            if (masaSelected.SiparislerList[e.Row.Index].Hazir) {
                e.Cancel = true;
                return;
            }

            Siparisler.Instance.SiparisIptalEt(masaSelected.SiparislerList[e.Row.Index]);
            ToplamFiyatYaz();
        }

        private void dataGridSiparis_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            // Hazır olan siparislerin arka planını yesil yap
            if (masaSelected.SiparislerList.Count > 0 && masaSelected.SiparislerList[e.RowIndex].Hazir) {
                e.CellStyle.BackColor = softGreen;
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.SelectionBackColor = softGreen;
            }
        }

        private void dataGridSiparis_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            // Siparis hazirsa miktar değişmesin
            if (masaSelected.SiparislerList[e.RowIndex].Hazir) {
                e.Cancel = true;
                return;
            }
        }
    }
}
