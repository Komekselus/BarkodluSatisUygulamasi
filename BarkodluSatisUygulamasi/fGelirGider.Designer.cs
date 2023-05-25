namespace BarkodluSatisUygulamasi
{
    partial class fGelirGider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGelirGider));
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.txtNakit = new System.Windows.Forms.TextBox();
            this.txtKart = new System.Windows.Forms.TextBox();
            this.dateTarih = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new BarkodluSatisUygulamasi.btnStandart();
            this.lblStandart6 = new BarkodluSatisUygulamasi.LblStandart();
            this.lblStandart5 = new BarkodluSatisUygulamasi.LblStandart();
            this.txtAciklama = new BarkodluSatisUygulamasi.txtStandart();
            this.lblStandart4 = new BarkodluSatisUygulamasi.LblStandart();
            this.lblStandart3 = new BarkodluSatisUygulamasi.LblStandart();
            this.lblStandart2 = new BarkodluSatisUygulamasi.LblStandart();
            this.lblGelirGider = new BarkodluSatisUygulamasi.LblStandart();
            this.SuspendLayout();
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "NAKİT",
            "KART",
            "NAKİT-KART"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(40, 80);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(250, 28);
            this.cmbOdemeTuru.TabIndex = 2;
            this.cmbOdemeTuru.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeTuru_SelectedIndexChanged);
            // 
            // txtNakit
            // 
            this.txtNakit.Enabled = false;
            this.txtNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNakit.Location = new System.Drawing.Point(40, 147);
            this.txtNakit.Name = "txtNakit";
            this.txtNakit.Size = new System.Drawing.Size(120, 26);
            this.txtNakit.TabIndex = 3;
            this.txtNakit.Text = "0";
            this.txtNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKart
            // 
            this.txtKart.Enabled = false;
            this.txtKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKart.Location = new System.Drawing.Point(170, 147);
            this.txtKart.Name = "txtKart";
            this.txtKart.Size = new System.Drawing.Size(120, 26);
            this.txtKart.TabIndex = 3;
            this.txtKart.Text = "0";
            this.txtKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTarih
            // 
            this.dateTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTarih.Location = new System.Drawing.Point(40, 390);
            this.dateTarih.Margin = new System.Windows.Forms.Padding(0);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(250, 26);
            this.dateTarih.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Tomato;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.Location = new System.Drawing.Point(40, 430);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(0);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(250, 53);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblStandart6
            // 
            this.lblStandart6.AutoSize = true;
            this.lblStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart6.ForeColor = System.Drawing.Color.Black;
            this.lblStandart6.Location = new System.Drawing.Point(36, 358);
            this.lblStandart6.Name = "lblStandart6";
            this.lblStandart6.Size = new System.Drawing.Size(44, 20);
            this.lblStandart6.TabIndex = 6;
            this.lblStandart6.Text = "Tarih";
            // 
            // lblStandart5
            // 
            this.lblStandart5.AutoSize = true;
            this.lblStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart5.ForeColor = System.Drawing.Color.Black;
            this.lblStandart5.Location = new System.Drawing.Point(36, 187);
            this.lblStandart5.Name = "lblStandart5";
            this.lblStandart5.Size = new System.Drawing.Size(73, 20);
            this.lblStandart5.TabIndex = 6;
            this.lblStandart5.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.White;
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAciklama.Location = new System.Drawing.Point(40, 210);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(250, 130);
            this.txtAciklama.TabIndex = 5;
            // 
            // lblStandart4
            // 
            this.lblStandart4.AutoSize = true;
            this.lblStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart4.ForeColor = System.Drawing.Color.Black;
            this.lblStandart4.Location = new System.Drawing.Point(166, 124);
            this.lblStandart4.Name = "lblStandart4";
            this.lblStandart4.Size = new System.Drawing.Size(38, 20);
            this.lblStandart4.TabIndex = 4;
            this.lblStandart4.Text = "Kart";
            // 
            // lblStandart3
            // 
            this.lblStandart3.AutoSize = true;
            this.lblStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart3.ForeColor = System.Drawing.Color.Black;
            this.lblStandart3.Location = new System.Drawing.Point(36, 124);
            this.lblStandart3.Name = "lblStandart3";
            this.lblStandart3.Size = new System.Drawing.Size(45, 20);
            this.lblStandart3.TabIndex = 4;
            this.lblStandart3.Text = "Nakit";
            // 
            // lblStandart2
            // 
            this.lblStandart2.AutoSize = true;
            this.lblStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStandart2.ForeColor = System.Drawing.Color.Black;
            this.lblStandart2.Location = new System.Drawing.Point(36, 57);
            this.lblStandart2.Name = "lblStandart2";
            this.lblStandart2.Size = new System.Drawing.Size(97, 20);
            this.lblStandart2.TabIndex = 0;
            this.lblStandart2.Text = "Ödeme Türü";
            // 
            // lblGelirGider
            // 
            this.lblGelirGider.AutoSize = true;
            this.lblGelirGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblGelirGider.ForeColor = System.Drawing.Color.Black;
            this.lblGelirGider.Location = new System.Drawing.Point(35, 9);
            this.lblGelirGider.Name = "lblGelirGider";
            this.lblGelirGider.Size = new System.Drawing.Size(74, 25);
            this.lblGelirGider.TabIndex = 0;
            this.lblGelirGider.Text = "GELİR";
            // 
            // fGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(337, 492);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dateTarih);
            this.Controls.Add(this.lblStandart6);
            this.Controls.Add(this.lblStandart5);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblStandart4);
            this.Controls.Add(this.lblStandart3);
            this.Controls.Add(this.txtKart);
            this.Controls.Add(this.txtNakit);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.lblStandart2);
            this.Controls.Add(this.lblGelirGider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fGelirGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir-Gider İşlemleri";
            this.Load += new System.EventHandler(this.fGelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LblStandart lblGelirGider;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private LblStandart lblStandart2;
        private System.Windows.Forms.TextBox txtNakit;
        private System.Windows.Forms.TextBox txtKart;
        private LblStandart lblStandart3;
        private LblStandart lblStandart4;
        private txtStandart txtAciklama;
        private LblStandart lblStandart5;
        private System.Windows.Forms.DateTimePicker dateTarih;
        private LblStandart lblStandart6;
        private btnStandart btnEkle;
    }
}