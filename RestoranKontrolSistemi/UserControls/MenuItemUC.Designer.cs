namespace RestoranKontrolSistemi.UserControls
{
    partial class MenuItemUC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuItemUC));
            this.labelYemekAdi = new System.Windows.Forms.Label();
            this.labelAciklama = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSil = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureYemek = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureYemek)).BeginInit();
            this.SuspendLayout();
            // 
            // labelYemekAdi
            // 
            this.labelYemekAdi.AutoSize = true;
            this.labelYemekAdi.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYemekAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelYemekAdi.Location = new System.Drawing.Point(164, 15);
            this.labelYemekAdi.Name = "labelYemekAdi";
            this.labelYemekAdi.Size = new System.Drawing.Size(87, 19);
            this.labelYemekAdi.TabIndex = 1;
            this.labelYemekAdi.Text = "Yemek Adı";
            // 
            // labelAciklama
            // 
            this.labelAciklama.AutoSize = true;
            this.labelAciklama.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelAciklama.Location = new System.Drawing.Point(165, 54);
            this.labelAciklama.MaximumSize = new System.Drawing.Size(300, 0);
            this.labelAciklama.Name = "labelAciklama";
            this.labelAciklama.Size = new System.Drawing.Size(57, 15);
            this.labelAciklama.TabIndex = 2;
            this.labelAciklama.Text = "Aciklama";
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelFiyat.Location = new System.Drawing.Point(165, 119);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(40, 16);
            this.labelFiyat.TabIndex = 3;
            this.labelFiyat.Text = "Fiyat";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "noImage.jpg");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // tsmiSil
            // 
            this.tsmiSil.Image = global::RestoranKontrolSistemi.Properties.Resources.trash_svg;
            this.tsmiSil.Name = "tsmiSil";
            this.tsmiSil.Size = new System.Drawing.Size(86, 22);
            this.tsmiSil.Text = "Sil";
            this.tsmiSil.Click += new System.EventHandler(this.tsmiSil_Click);
            // 
            // pictureYemek
            // 
            this.pictureYemek.BackColor = System.Drawing.SystemColors.Control;
            this.pictureYemek.Location = new System.Drawing.Point(15, 15);
            this.pictureYemek.Name = "pictureYemek";
            this.pictureYemek.Size = new System.Drawing.Size(120, 120);
            this.pictureYemek.TabIndex = 0;
            this.pictureYemek.TabStop = false;
            // 
            // MenuItemUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.labelFiyat);
            this.Controls.Add(this.labelAciklama);
            this.Controls.Add(this.labelYemekAdi);
            this.Controls.Add(this.pictureYemek);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(500, 150);
            this.Name = "MenuItemUC";
            this.Size = new System.Drawing.Size(500, 150);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureYemek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureYemek;
        private System.Windows.Forms.Label labelYemekAdi;
        private System.Windows.Forms.Label labelAciklama;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSil;
    }
}
