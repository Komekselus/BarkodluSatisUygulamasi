namespace BarkodluSatisUygulamasi
{
    partial class fGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGiris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGiris = new BarkodluSatisUygulamasi.btnStandart();
            this.lblStandart3 = new BarkodluSatisUygulamasi.LblStandart();
            this.lblStandart2 = new BarkodluSatisUygulamasi.LblStandart();
            this.txtSifre = new BarkodluSatisUygulamasi.txtStandart();
            this.lblStandart1 = new BarkodluSatisUygulamasi.LblStandart();
            this.txtKullaniciAdi = new BarkodluSatisUygulamasi.txtStandart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.DarkRed;
            this.btnGiris.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.Image")));
            this.btnGiris.Location = new System.Drawing.Point(344, 87);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(105, 63);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblStandart3
            // 
            this.lblStandart3.AutoSize = true;
            this.lblStandart3.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lblStandart3.ForeColor = System.Drawing.Color.Black;
            this.lblStandart3.Location = new System.Drawing.Point(114, 25);
            this.lblStandart3.Name = "lblStandart3";
            this.lblStandart3.Size = new System.Drawing.Size(320, 43);
            this.lblStandart3.TabIndex = 3;
            this.lblStandart3.Text = "Barkodlu Satış Programı";
            // 
            // lblStandart2
            // 
            this.lblStandart2.AutoSize = true;
            this.lblStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblStandart2.ForeColor = System.Drawing.Color.White;
            this.lblStandart2.Location = new System.Drawing.Point(75, 130);
            this.lblStandart2.Name = "lblStandart2";
            this.lblStandart2.Size = new System.Drawing.Size(52, 20);
            this.lblStandart2.TabIndex = 1;
            this.lblStandart2.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSifre.Location = new System.Drawing.Point(144, 127);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(170, 26);
            this.txtSifre.TabIndex = 1;
            // 
            // lblStandart1
            // 
            this.lblStandart1.AutoSize = true;
            this.lblStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblStandart1.ForeColor = System.Drawing.Color.White;
            this.lblStandart1.Location = new System.Drawing.Point(27, 93);
            this.lblStandart1.Name = "lblStandart1";
            this.lblStandart1.Size = new System.Drawing.Size(111, 20);
            this.lblStandart1.TabIndex = 1;
            this.lblStandart1.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(144, 90);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(170, 26);
            this.txtKullaniciAdi.TabIndex = 0;
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtStandart1_TextChanged);
            // 
            // fGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(458, 161);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblStandart3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStandart2);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblStandart1);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGiris_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private txtStandart txtKullaniciAdi;
        private LblStandart lblStandart1;
        private txtStandart txtSifre;
        private LblStandart lblStandart2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LblStandart lblStandart3;
        private btnStandart btnGiris;
    }
}