namespace RestoranKontrolSistemi
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnSiparisler = new System.Windows.Forms.Button();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMasalar = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progresBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmMasaCikar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMasaEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.topPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.topPanel.Controls.Add(this.btnSiparisler);
            this.topPanel.Controls.Add(this.btnMenu);
            this.topPanel.Controls.Add(this.btnMasalar);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1184, 59);
            this.topPanel.TabIndex = 0;
            // 
            // btnSiparisler
            // 
            this.btnSiparisler.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSiparisler.FlatAppearance.BorderSize = 0;
            this.btnSiparisler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.btnSiparisler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisler.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisler.ForeColor = System.Drawing.Color.White;
            this.btnSiparisler.ImageIndex = 3;
            this.btnSiparisler.ImageList = this.imageListIcons;
            this.btnSiparisler.Location = new System.Drawing.Point(242, 0);
            this.btnSiparisler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSiparisler.Name = "btnSiparisler";
            this.btnSiparisler.Size = new System.Drawing.Size(121, 59);
            this.btnSiparisler.TabIndex = 2;
            this.btnSiparisler.Text = "Siparişler";
            this.btnSiparisler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSiparisler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSiparisler.UseVisualStyleBackColor = true;
            this.btnSiparisler.Click += new System.EventHandler(this.btnSiparisler_Click);
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "table-svg.png");
            this.imageListIcons.Images.SetKeyName(1, "book-svg.png");
            this.imageListIcons.Images.SetKeyName(2, "card-svg.png");
            this.imageListIcons.Images.SetKeyName(3, "card-svg2.png");
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.ImageIndex = 1;
            this.btnMenu.ImageList = this.imageListIcons;
            this.btnMenu.Location = new System.Drawing.Point(121, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(121, 59);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menü";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMasalar
            // 
            this.btnMasalar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMasalar.FlatAppearance.BorderSize = 0;
            this.btnMasalar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.btnMasalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasalar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasalar.ForeColor = System.Drawing.Color.White;
            this.btnMasalar.ImageIndex = 0;
            this.btnMasalar.ImageList = this.imageListIcons;
            this.btnMasalar.Location = new System.Drawing.Point(0, 0);
            this.btnMasalar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMasalar.Name = "btnMasalar";
            this.btnMasalar.Size = new System.Drawing.Size(121, 59);
            this.btnMasalar.TabIndex = 0;
            this.btnMasalar.Text = "Masalar";
            this.btnMasalar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMasalar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMasalar.UseVisualStyleBackColor = true;
            this.btnMasalar.Click += new System.EventHandler(this.btnMasalar_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.White;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 59);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1184, 530);
            this.bottomPanel.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSaat,
            this.progresBar,
            this.toolStripSplitButton1});
            this.statusStrip.Location = new System.Drawing.Point(0, 589);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip.TabIndex = 2;
            // 
            // tssSaat
            // 
            this.tssSaat.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssSaat.ForeColor = System.Drawing.Color.White;
            this.tssSaat.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.tssSaat.Name = "tssSaat";
            this.tssSaat.Size = new System.Drawing.Size(11, 17);
            this.tssSaat.Text = " ";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // progresBar
            // 
            this.progresBar.Margin = new System.Windows.Forms.Padding(20, 3, 1, 3);
            this.progresBar.Name = "progresBar";
            this.progresBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMasaEkle,
            this.tsmMasaCikar});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Margin = new System.Windows.Forms.Padding(10, 2, 0, 0);
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // tsmMasaCikar
            // 
            this.tsmMasaCikar.Name = "tsmMasaCikar";
            this.tsmMasaCikar.Size = new System.Drawing.Size(180, 22);
            this.tsmMasaCikar.Text = "Masa Çıkar";
            this.tsmMasaCikar.Click += new System.EventHandler(this.tsmMasaCikar_Click);
            // 
            // tsmMasaEkle
            // 
            this.tsmMasaEkle.Name = "tsmMasaEkle";
            this.tsmMasaEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmMasaEkle.Text = "Masa Ekle";
            this.tsmMasaEkle.Click += new System.EventHandler(this.tsmMasaEkle_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "frmMain";
            this.Text = "Restoran Kontrol";
            this.topPanel.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnMasalar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button btnSiparisler;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssSaat;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.ToolStripProgressBar progresBar;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem tsmMasaEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmMasaCikar;
    }
}

