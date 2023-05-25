namespace BarkodluSatisUygulamasi
{
    partial class fUrunGrubuEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUrunGrubuEkle));
            this.listUrunGrup = new System.Windows.Forms.ListBox();
            this.btnEkle = new BarkodluSatisUygulamasi.btnStandart();
            this.txtUrunGrupAd = new BarkodluSatisUygulamasi.txtStandart();
            this.lblStandart1 = new BarkodluSatisUygulamasi.LblStandart();
            this.btnSil = new BarkodluSatisUygulamasi.btnStandart();
            this.SuspendLayout();
            // 
            // listUrunGrup
            // 
            this.listUrunGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listUrunGrup.FormattingEnabled = true;
            this.listUrunGrup.ItemHeight = 20;
            this.listUrunGrup.Location = new System.Drawing.Point(12, 64);
            this.listUrunGrup.Name = "listUrunGrup";
            this.listUrunGrup.Size = new System.Drawing.Size(299, 164);
            this.listUrunGrup.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Tomato;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.Location = new System.Drawing.Point(162, 231);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(149, 68);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnStandart1_Click);
            // 
            // txtUrunGrupAd
            // 
            this.txtUrunGrupAd.BackColor = System.Drawing.Color.White;
            this.txtUrunGrupAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUrunGrupAd.Location = new System.Drawing.Point(12, 32);
            this.txtUrunGrupAd.Name = "txtUrunGrupAd";
            this.txtUrunGrupAd.Size = new System.Drawing.Size(299, 26);
            this.txtUrunGrupAd.TabIndex = 1;
            // 
            // lblStandart1
            // 
            this.lblStandart1.AutoSize = true;
            this.lblStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart1.ForeColor = System.Drawing.Color.Black;
            this.lblStandart1.Location = new System.Drawing.Point(12, 9);
            this.lblStandart1.Name = "lblStandart1";
            this.lblStandart1.Size = new System.Drawing.Size(120, 20);
            this.lblStandart1.TabIndex = 0;
            this.lblStandart1.Text = "Ürün Grubu Adı";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Maroon;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(12, 231);
            this.btnSil.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(149, 68);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // fUrunGrubuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 308);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.listUrunGrup);
            this.Controls.Add(this.txtUrunGrupAd);
            this.Controls.Add(this.lblStandart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fUrunGrubuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Grubu İşlemleri";
            this.Load += new System.EventHandler(this.fUrunGrubuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LblStandart lblStandart1;
        private txtStandart txtUrunGrupAd;
        private System.Windows.Forms.ListBox listUrunGrup;
        private btnStandart btnEkle;
        private btnStandart btnSil;
    }
}