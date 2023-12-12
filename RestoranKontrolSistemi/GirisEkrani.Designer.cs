namespace RestoranKontrolSistemi
{
    partial class GirisEkrani
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
            this.btnGöster = new System.Windows.Forms.Button();
            this.linkLabelAdmin = new System.Windows.Forms.LinkLabel();
            this.txtboxMasaNum = new System.Windows.Forms.TextBox();
            this.lblMasaNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGöster
            // 
            this.btnGöster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.btnGöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGöster.ForeColor = System.Drawing.Color.White;
            this.btnGöster.Location = new System.Drawing.Point(259, 189);
            this.btnGöster.Name = "btnGöster";
            this.btnGöster.Size = new System.Drawing.Size(188, 40);
            this.btnGöster.TabIndex = 0;
            this.btnGöster.Text = "Göster";
            this.btnGöster.UseVisualStyleBackColor = false;
            // 
            // linkLabelAdmin
            // 
            this.linkLabelAdmin.AutoSize = true;
            this.linkLabelAdmin.Location = new System.Drawing.Point(147, 204);
            this.linkLabelAdmin.Name = "linkLabelAdmin";
            this.linkLabelAdmin.Size = new System.Drawing.Size(61, 13);
            this.linkLabelAdmin.TabIndex = 1;
            this.linkLabelAdmin.TabStop = true;
            this.linkLabelAdmin.Text = "Admin Girişi";
            this.linkLabelAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAdmin_LinkClicked);
            // 
            // txtboxMasaNum
            // 
            this.txtboxMasaNum.Location = new System.Drawing.Point(259, 151);
            this.txtboxMasaNum.Name = "txtboxMasaNum";
            this.txtboxMasaNum.Size = new System.Drawing.Size(188, 20);
            this.txtboxMasaNum.TabIndex = 2;
            // 
            // lblMasaNum
            // 
            this.lblMasaNum.AutoSize = true;
            this.lblMasaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasaNum.Location = new System.Drawing.Point(108, 151);
            this.lblMasaNum.Name = "lblMasaNum";
            this.lblMasaNum.Size = new System.Drawing.Size(145, 18);
            this.lblMasaNum.TabIndex = 3;
            this.lblMasaNum.Text = "Masa Numaranız :";
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 378);
            this.Controls.Add(this.lblMasaNum);
            this.Controls.Add(this.txtboxMasaNum);
            this.Controls.Add(this.linkLabelAdmin);
            this.Controls.Add(this.btnGöster);
            this.Name = "GirisEkrani";
            this.Text = "Giriş Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GirisEkrani_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGöster;
        private System.Windows.Forms.LinkLabel linkLabelAdmin;
        private System.Windows.Forms.TextBox txtboxMasaNum;
        private System.Windows.Forms.Label lblMasaNum;
    }
}