namespace RestoranKontrolSistemi
{
    partial class AdminGiris
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
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnSifreUnut = new System.Windows.Forms.Button();
            this.labelKullanici = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.txtBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.btnAdminGiris.FlatAppearance.BorderSize = 0;
            this.btnAdminGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminGiris.ForeColor = System.Drawing.Color.White;
            this.btnAdminGiris.Location = new System.Drawing.Point(195, 191);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(107, 42);
            this.btnAdminGiris.TabIndex = 0;
            this.btnAdminGiris.Text = "Giriş Yap";
            this.btnAdminGiris.UseVisualStyleBackColor = false;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // btnSifreUnut
            // 
            this.btnSifreUnut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.btnSifreUnut.FlatAppearance.BorderSize = 0;
            this.btnSifreUnut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreUnut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifreUnut.ForeColor = System.Drawing.Color.White;
            this.btnSifreUnut.Location = new System.Drawing.Point(317, 191);
            this.btnSifreUnut.Name = "btnSifreUnut";
            this.btnSifreUnut.Size = new System.Drawing.Size(107, 42);
            this.btnSifreUnut.TabIndex = 1;
            this.btnSifreUnut.Text = "Şifremi Unuttum";
            this.btnSifreUnut.UseVisualStyleBackColor = false;
            // 
            // labelKullanici
            // 
            this.labelKullanici.AutoSize = true;
            this.labelKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKullanici.Location = new System.Drawing.Point(115, 103);
            this.labelKullanici.Name = "labelKullanici";
            this.labelKullanici.Size = new System.Drawing.Size(109, 18);
            this.labelKullanici.TabIndex = 2;
            this.labelKullanici.Text = "Kullanıcı Adı :";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSifre.Location = new System.Drawing.Point(161, 153);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(53, 18);
            this.labelSifre.TabIndex = 3;
            this.labelSifre.Text = "Şifre :";
            // 
            // txtBoxKullaniciAdi
            // 
            this.txtBoxKullaniciAdi.Location = new System.Drawing.Point(230, 103);
            this.txtBoxKullaniciAdi.Name = "txtBoxKullaniciAdi";
            this.txtBoxKullaniciAdi.Size = new System.Drawing.Size(164, 20);
            this.txtBoxKullaniciAdi.TabIndex = 4;
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Location = new System.Drawing.Point(230, 150);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(164, 20);
            this.txtBoxSifre.TabIndex = 5;
            // 
            // AdminGiris
            // 
            this.AcceptButton = this.btnAdminGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 381);
            this.Controls.Add(this.txtBoxSifre);
            this.Controls.Add(this.txtBoxKullaniciAdi);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelKullanici);
            this.Controls.Add(this.btnSifreUnut);
            this.Controls.Add(this.btnAdminGiris);
            this.MaximumSize = new System.Drawing.Size(610, 420);
            this.MinimumSize = new System.Drawing.Size(610, 420);
            this.Name = "AdminGiris";
            this.Text = "Admin Giriş";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminGiris_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnSifreUnut;
        private System.Windows.Forms.Label labelKullanici;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.TextBox txtBoxKullaniciAdi;
        private System.Windows.Forms.TextBox txtBoxSifre;
    }
}