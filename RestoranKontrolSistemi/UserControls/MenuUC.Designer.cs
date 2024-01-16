namespace RestoranKontrolSistemi.UserControls {
    partial class MenuUC {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.menuSplitContainer = new System.Windows.Forms.SplitContainer();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUrunEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDosyayaYaz = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.labelResim = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.labelKategori = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.labelYeniUrun = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBoxFiyat = new System.Windows.Forms.TextBox();
            this.txtBoxAciklama = new System.Windows.Forms.TextBox();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.labelAciklama = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.ofdResim = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.menuSplitContainer)).BeginInit();
            this.menuSplitContainer.Panel1.SuspendLayout();
            this.menuSplitContainer.Panel2.SuspendLayout();
            this.menuSplitContainer.SuspendLayout();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSplitContainer
            // 
            this.menuSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.menuSplitContainer.Name = "menuSplitContainer";
            // 
            // menuSplitContainer.Panel1
            // 
            this.menuSplitContainer.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuSplitContainer.Panel1.ContextMenuStrip = this.cmsMenu;
            this.menuSplitContainer.Panel1.Controls.Add(this.menuPanel);
            // 
            // menuSplitContainer.Panel2
            // 
            this.menuSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(228)))));
            this.menuSplitContainer.Panel2.Controls.Add(this.btnResimSec);
            this.menuSplitContainer.Panel2.Controls.Add(this.labelResim);
            this.menuSplitContainer.Panel2.Controls.Add(this.cbKategori);
            this.menuSplitContainer.Panel2.Controls.Add(this.labelKategori);
            this.menuSplitContainer.Panel2.Controls.Add(this.labelWarning);
            this.menuSplitContainer.Panel2.Controls.Add(this.btnEkle);
            this.menuSplitContainer.Panel2.Controls.Add(this.labelYeniUrun);
            this.menuSplitContainer.Panel2.Controls.Add(this.btnClose);
            this.menuSplitContainer.Panel2.Controls.Add(this.txtBoxFiyat);
            this.menuSplitContainer.Panel2.Controls.Add(this.txtBoxAciklama);
            this.menuSplitContainer.Panel2.Controls.Add(this.txtBoxAd);
            this.menuSplitContainer.Panel2.Controls.Add(this.labelFiyat);
            this.menuSplitContainer.Panel2.Controls.Add(this.labelAciklama);
            this.menuSplitContainer.Panel2.Controls.Add(this.labelAd);
            this.menuSplitContainer.Size = new System.Drawing.Size(999, 589);
            this.menuSplitContainer.SplitterDistance = 713;
            this.menuSplitContainer.SplitterWidth = 2;
            this.menuSplitContainer.TabIndex = 0;
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUrunEkle,
            this.tsmiDosyayaYaz});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(186, 48);
            // 
            // tsmiUrunEkle
            // 
            this.tsmiUrunEkle.Image = global::RestoranKontrolSistemi.Properties.Resources.add_svg;
            this.tsmiUrunEkle.Name = "tsmiUrunEkle";
            this.tsmiUrunEkle.Size = new System.Drawing.Size(185, 22);
            this.tsmiUrunEkle.Text = "Urun Ekle";
            this.tsmiUrunEkle.Click += new System.EventHandler(this.tsmiUrunEkle_Click);
            // 
            // tsmiDosyayaYaz
            // 
            this.tsmiDosyayaYaz.Image = global::RestoranKontrolSistemi.Properties.Resources.write_svg;
            this.tsmiDosyayaYaz.Name = "tsmiDosyayaYaz";
            this.tsmiDosyayaYaz.Size = new System.Drawing.Size(185, 22);
            this.tsmiDosyayaYaz.Text = "Menüyü Dosyaya Yaz";
            this.tsmiDosyayaYaz.Click += new System.EventHandler(this.tsmiDosyayaYaz_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.menuPanel.AutoScroll = true;
            this.menuPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuPanel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPanel.Location = new System.Drawing.Point(100, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.MaximumSize = new System.Drawing.Size(510, 2000);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(5);
            this.menuPanel.Size = new System.Drawing.Size(510, 589);
            this.menuPanel.TabIndex = 1;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResimSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.btnResimSec.FlatAppearance.BorderSize = 0;
            this.btnResimSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResimSec.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimSec.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnResimSec.Location = new System.Drawing.Point(111, 253);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(147, 23);
            this.btnResimSec.TabIndex = 10;
            this.btnResimSec.Text = "Seç";
            this.btnResimSec.UseVisualStyleBackColor = false;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // labelResim
            // 
            this.labelResim.AutoSize = true;
            this.labelResim.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelResim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelResim.Location = new System.Drawing.Point(27, 256);
            this.labelResim.Name = "labelResim";
            this.labelResim.Size = new System.Drawing.Size(50, 16);
            this.labelResim.TabIndex = 5;
            this.labelResim.Text = "Resim";
            // 
            // cbKategori
            // 
            this.cbKategori.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKategori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbKategori.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKategori.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "Başlangıç",
            "Ana Yemek",
            "Tatlı",
            "İçecek"});
            this.cbKategori.Location = new System.Drawing.Point(111, 216);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(147, 23);
            this.cbKategori.TabIndex = 9;
            this.cbKategori.Text = "Başlangıç";
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelKategori.Location = new System.Drawing.Point(27, 218);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(67, 16);
            this.labelKategori.TabIndex = 4;
            this.labelKategori.Text = "Kategori";
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWarning.ForeColor = System.Drawing.Color.Firebrick;
            this.labelWarning.Location = new System.Drawing.Point(108, 301);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 16);
            this.labelWarning.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(32, 553);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(228, 26);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // labelYeniUrun
            // 
            this.labelYeniUrun.AutoSize = true;
            this.labelYeniUrun.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYeniUrun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelYeniUrun.Location = new System.Drawing.Point(25, 9);
            this.labelYeniUrun.Name = "labelYeniUrun";
            this.labelYeniUrun.Size = new System.Drawing.Size(112, 26);
            this.labelYeniUrun.TabIndex = 0;
            this.labelYeniUrun.Text = "Yeni Ürün";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(196)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(243, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 35);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "✖";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBoxFiyat
            // 
            this.txtBoxFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFiyat.BackColor = System.Drawing.Color.White;
            this.txtBoxFiyat.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxFiyat.Location = new System.Drawing.Point(111, 178);
            this.txtBoxFiyat.Name = "txtBoxFiyat";
            this.txtBoxFiyat.Size = new System.Drawing.Size(147, 23);
            this.txtBoxFiyat.TabIndex = 8;
            // 
            // txtBoxAciklama
            // 
            this.txtBoxAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAciklama.BackColor = System.Drawing.Color.White;
            this.txtBoxAciklama.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAciklama.Location = new System.Drawing.Point(111, 118);
            this.txtBoxAciklama.Multiline = true;
            this.txtBoxAciklama.Name = "txtBoxAciklama";
            this.txtBoxAciklama.Size = new System.Drawing.Size(147, 51);
            this.txtBoxAciklama.TabIndex = 7;
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAd.BackColor = System.Drawing.Color.White;
            this.txtBoxAd.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAd.Location = new System.Drawing.Point(111, 85);
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(147, 23);
            this.txtBoxAd.TabIndex = 6;
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelFiyat.Location = new System.Drawing.Point(27, 180);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(40, 16);
            this.labelFiyat.TabIndex = 3;
            this.labelFiyat.Text = "Fiyat";
            // 
            // labelAciklama
            // 
            this.labelAciklama.AutoSize = true;
            this.labelAciklama.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelAciklama.Location = new System.Drawing.Point(27, 120);
            this.labelAciklama.Name = "labelAciklama";
            this.labelAciklama.Size = new System.Drawing.Size(68, 16);
            this.labelAciklama.TabIndex = 2;
            this.labelAciklama.Text = "Açıklama";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(228)))));
            this.labelAd.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelAd.Location = new System.Drawing.Point(27, 87);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(25, 16);
            this.labelAd.TabIndex = 1;
            this.labelAd.Text = "Ad";
            // 
            // ofdResim
            // 
            this.ofdResim.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            // 
            // MenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuSplitContainer);
            this.Name = "MenuUC";
            this.Size = new System.Drawing.Size(999, 589);
            this.menuSplitContainer.Panel1.ResumeLayout(false);
            this.menuSplitContainer.Panel2.ResumeLayout(false);
            this.menuSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuSplitContainer)).EndInit();
            this.menuSplitContainer.ResumeLayout(false);
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer menuSplitContainer;
        private System.Windows.Forms.FlowLayoutPanel menuPanel;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiUrunEkle;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label labelAciklama;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.TextBox txtBoxFiyat;
        private System.Windows.Forms.TextBox txtBoxAciklama;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelYeniUrun;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.OpenFileDialog ofdResim;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.Label labelResim;
        private System.Windows.Forms.ToolStripMenuItem tsmiDosyayaYaz;
    }
}
