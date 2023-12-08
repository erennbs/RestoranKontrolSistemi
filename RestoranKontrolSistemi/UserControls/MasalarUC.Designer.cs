namespace RestoranKontrolSistemi.UserControls
{
    partial class MasalarUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.masalarSplitContainer = new System.Windows.Forms.SplitContainer();
            this.flpMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblToplam = new System.Windows.Forms.Label();
            this.dataGridSiparis = new System.Windows.Forms.DataGridView();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMasaAcKapa = new System.Windows.Forms.Button();
            this.lbUrunler = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMasa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masalarSplitContainer)).BeginInit();
            this.masalarSplitContainer.Panel1.SuspendLayout();
            this.masalarSplitContainer.Panel2.SuspendLayout();
            this.masalarSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // masalarSplitContainer
            // 
            this.masalarSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masalarSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.masalarSplitContainer.Name = "masalarSplitContainer";
            // 
            // masalarSplitContainer.Panel1
            // 
            this.masalarSplitContainer.Panel1.Controls.Add(this.flpMasalar);
            // 
            // masalarSplitContainer.Panel2
            // 
            this.masalarSplitContainer.Panel2.AutoScroll = true;
            this.masalarSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(228)))));
            this.masalarSplitContainer.Panel2.Controls.Add(this.lblToplam);
            this.masalarSplitContainer.Panel2.Controls.Add(this.dataGridSiparis);
            this.masalarSplitContainer.Panel2.Controls.Add(this.btnMasaAcKapa);
            this.masalarSplitContainer.Panel2.Controls.Add(this.lbUrunler);
            this.masalarSplitContainer.Panel2.Controls.Add(this.btnClose);
            this.masalarSplitContainer.Panel2.Controls.Add(this.lblMasa);
            this.masalarSplitContainer.Size = new System.Drawing.Size(1039, 547);
            this.masalarSplitContainer.SplitterDistance = 709;
            this.masalarSplitContainer.TabIndex = 0;
            // 
            // flpMasalar
            // 
            this.flpMasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMasalar.Location = new System.Drawing.Point(0, 0);
            this.flpMasalar.Name = "flpMasalar";
            this.flpMasalar.Padding = new System.Windows.Forms.Padding(30);
            this.flpMasalar.Size = new System.Drawing.Size(709, 547);
            this.flpMasalar.TabIndex = 0;
            // 
            // lblToplam
            // 
            this.lblToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplam.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lblToplam.Location = new System.Drawing.Point(141, 233);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(166, 23);
            this.lblToplam.TabIndex = 17;
            this.lblToplam.Text = "Toplam: 0 TL";
            this.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridSiparis
            // 
            this.dataGridSiparis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSiparis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSiparis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSiparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunAdi,
            this.Miktar,
            this.Fiyat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSiparis.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSiparis.Location = new System.Drawing.Point(18, 63);
            this.dataGridSiparis.Name = "dataGridSiparis";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridSiparis.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSiparis.Size = new System.Drawing.Size(289, 154);
            this.dataGridSiparis.TabIndex = 16;
            this.dataGridSiparis.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridSiparis_CellBeginEdit);
            this.dataGridSiparis.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridSiparis_CellFormatting);
            this.dataGridSiparis.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSiparis_CellValueChanged);
            this.dataGridSiparis.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridSiparis_DataError);
            this.dataGridSiparis.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridSiparis_UserDeletingRow);
            // 
            // UrunAdi
            // 
            this.UrunAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunAdi.DataPropertyName = "UrunAdi";
            this.UrunAdi.HeaderText = "UrunAdi";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.ReadOnly = true;
            // 
            // Miktar
            // 
            this.Miktar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Miktar.DataPropertyName = "Miktar";
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            this.Miktar.Width = 61;
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fiyat.DataPropertyName = "NetFiyat";
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.ReadOnly = true;
            // 
            // btnMasaAcKapa
            // 
            this.btnMasaAcKapa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasaAcKapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.btnMasaAcKapa.FlatAppearance.BorderSize = 0;
            this.btnMasaAcKapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasaAcKapa.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaAcKapa.ForeColor = System.Drawing.Color.White;
            this.btnMasaAcKapa.Location = new System.Drawing.Point(18, 502);
            this.btnMasaAcKapa.Name = "btnMasaAcKapa";
            this.btnMasaAcKapa.Size = new System.Drawing.Size(289, 29);
            this.btnMasaAcKapa.TabIndex = 15;
            this.btnMasaAcKapa.Text = "Masa Aç";
            this.btnMasaAcKapa.UseVisualStyleBackColor = false;
            this.btnMasaAcKapa.Click += new System.EventHandler(this.btnMasaAcKapa_Click);
            // 
            // lbUrunler
            // 
            this.lbUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUrunler.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUrunler.FormattingEnabled = true;
            this.lbUrunler.ItemHeight = 16;
            this.lbUrunler.Location = new System.Drawing.Point(18, 323);
            this.lbUrunler.Name = "lbUrunler";
            this.lbUrunler.Size = new System.Drawing.Size(289, 148);
            this.lbUrunler.TabIndex = 14;
            this.lbUrunler.SelectedIndexChanged += new System.EventHandler(this.lbUrunler_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(196)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(284, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "✖";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMasa
            // 
            this.lblMasa.AutoSize = true;
            this.lblMasa.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lblMasa.Location = new System.Drawing.Point(14, 10);
            this.lblMasa.Name = "lblMasa";
            this.lblMasa.Size = new System.Drawing.Size(76, 22);
            this.lblMasa.TabIndex = 0;
            this.lblMasa.Text = "Masa 1";
            // 
            // MasalarUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.masalarSplitContainer);
            this.Name = "MasalarUC";
            this.Size = new System.Drawing.Size(1039, 547);
            this.masalarSplitContainer.Panel1.ResumeLayout(false);
            this.masalarSplitContainer.Panel2.ResumeLayout(false);
            this.masalarSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masalarSplitContainer)).EndInit();
            this.masalarSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer masalarSplitContainer;
        private System.Windows.Forms.FlowLayoutPanel flpMasalar;
        private System.Windows.Forms.Label lblMasa;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbUrunler;
        private System.Windows.Forms.Button btnMasaAcKapa;
        private System.Windows.Forms.DataGridView dataGridSiparis;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.Label lblToplam;
    }
}
