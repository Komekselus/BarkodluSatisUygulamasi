namespace BarkodluSatisUygulamasi
{
    partial class fNakit_Kart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNakit_Kart));
            this.txtNakit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.bHesapNokta = new System.Windows.Forms.Button();
            this.bHesap0 = new System.Windows.Forms.Button();
            this.bHesapSil = new System.Windows.Forms.Button();
            this.bHesap9 = new System.Windows.Forms.Button();
            this.bHesap8 = new System.Windows.Forms.Button();
            this.bHesap7 = new System.Windows.Forms.Button();
            this.bHesap6 = new System.Windows.Forms.Button();
            this.bHesap5 = new System.Windows.Forms.Button();
            this.bHesap4 = new System.Windows.Forms.Button();
            this.bHesap3 = new System.Windows.Forms.Button();
            this.bHesap2 = new System.Windows.Forms.Button();
            this.bHesap1 = new System.Windows.Forms.Button();
            this.bNakit = new System.Windows.Forms.Button();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNakit
            // 
            this.txtNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNakit.Location = new System.Drawing.Point(4, 32);
            this.txtNakit.Multiline = true;
            this.txtNakit.Name = "txtNakit";
            this.txtNakit.Size = new System.Drawing.Size(260, 29);
            this.txtNakit.TabIndex = 0;
            this.txtNakit.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            this.txtNakit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNakit_KeyDown);
            this.txtNakit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNakit_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(2, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nakit Miktarını Giriniz:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 65);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(262, 245);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 243);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Controls.Add(this.bHesapNokta, 2, 3);
            this.tableLayoutPanel8.Controls.Add(this.bHesap0, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.bHesapSil, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.bHesap9, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.bHesap8, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.bHesap7, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.bHesap6, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.bHesap5, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.bHesap4, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.bHesap3, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.bHesap2, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.bHesap1, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(260, 243);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // bHesapNokta
            // 
            this.bHesapNokta.BackColor = System.Drawing.Color.DimGray;
            this.bHesapNokta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bHesapNokta.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bHesapNokta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHesapNokta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHesapNokta.ForeColor = System.Drawing.Color.White;
            this.bHesapNokta.Location = new System.Drawing.Point(173, 181);
            this.bHesapNokta.Margin = new System.Windows.Forms.Padding(1);
            this.bHesapNokta.Name = "bHesapNokta";
            this.bHesapNokta.Size = new System.Drawing.Size(86, 61);
            this.bHesapNokta.TabIndex = 11;
            this.bHesapNokta.Text = ",";
            this.bHesapNokta.UseVisualStyleBackColor = false;
            this.bHesapNokta.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bHesap0
            // 
            this.bHesap0.BackColor = System.Drawing.Color.DimGray;
            this.bHesap0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bHesap0.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bHesap0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHesap0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHesap0.ForeColor = System.Drawing.Color.White;
            this.bHesap0.Location = new System.Drawing.Point(87, 181);
            this.bHesap0.Margin = new System.Windows.Forms.Padding(1);
            this.bHesap0.Name = "bHesap0";
            this.bHesap0.Size = new System.Drawing.Size(84, 61);
            this.bHesap0.TabIndex = 10;
            this.bHesap0.Text = "0";
            this.bHesap0.UseVisualStyleBackColor = false;
            this.bHesap0.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bHesapSil
            // 
            this.bHesapSil.BackColor = System.Drawing.Color.DimGray;
            this.bHesapSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bHesapSil.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bHesapSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHesapSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHesapSil.ForeColor = System.Drawing.Color.White;
            this.bHesapSil.Location = new System.Drawing.Point(1, 181);
            this.bHesapSil.Margin = new System.Windows.Forms.Padding(1);
            this.bHesapSil.Name = "bHesapSil";
            this.bHesapSil.Size = new System.Drawing.Size(84, 61);
            this.bHesapSil.TabIndex = 9;
            this.bHesapSil.Text = "<";
            this.bHesapSil.UseVisualStyleBackColor = false;
            this.bHesapSil.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bHesap9
            // 
            this.bHesap9.BackColor = System.Drawing.Color.DimGray;
            this.bHesap9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bHesap9.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bHesap9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHesap9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHesap9.ForeColor = System.Drawing.Color.White;
            this.bHesap9.Location = new System.Drawing.Point(173, 121);
            this.bHesap9.Margin = new System.Windows.Forms.Padding(1);
            this.bHesap9.Name = "bHesap9";
            this.bHesap9.Size = new System.Drawing.Size(86, 58);
            this.bHesap9.TabIndex = 8;
            this.bHesap9.Text = "9";
            this.bHesap9.UseVisualStyleBackColor = false;
            this.bHesap9.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bHesap8
            // 
            this.bHesap8.BackColor = System.Drawing.Color.DimGray;
            this.bHesap8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bHesap8.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bHesap8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHesap8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHesap8.ForeColor = System.Drawing.Color.White;
            this.bHesap8.Location = new System.Drawing.Point(87, 121);
            this.bHesap8.Margin = new System.Windows.Forms.Padding(1);
            this.bHesap8.Name = "bHesap8";
            this.bHesap8.Size = new System.Drawing.Size(84, 58);
            this.bHesap8.TabIndex = 7;
            this.bHesap8.Text = "8";
            this.bHesap8.UseVisualStyleBackColor = false;
            this.bHesap8.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bHesap7
            // 
            this.bHesap7.BackColor = System.Drawing.Color.DimGray;
            this.bHesap7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bHesap7.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bHesap7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHesap7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHesap7.ForeColor = System.Drawing.Color.White;
            this.bHesap7.Location = new System.Drawing.Point(1, 121);
            this.bHesap7.Margin = new System.Windows.Forms.Padding(1);
            this.bHesap7.Name = "bHesap7";
            this.bHesap7.Size = new System.Drawing.Size(84, 58);
            this.bHesap7.TabIndex = 6;
            this.bHesap7.Text = "7";
            this.bHesap7.UseVisualStyleBackColor = false;
            this.bHesap7.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bHesap6
            // 
            this.bHesap6.BackColor = System.Drawing.Color.DimGray;
            this.bHesap6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bHesap6.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bHesap6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHesap6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHesap6.ForeColor = System.Drawing.Color.White;
            this.bHesap6.Location = new System.Drawing.Point(173, 61);
            this.bHesap6.Margin = new System.Windows.Forms.Padding(1);
            this.bHesap6.Name = "bHesap6";
            this.bHesap6.Size = new System.Drawing.Size(86, 58);
            this.bHesap6.TabIndex = 5;
            this.bHesap6.Text = "6";
            this.bHesap6.UseVisualStyleBackColor = false;
            this.bHesap6.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bHesap5
            // 
            this.bHesap5.BackColor = System.Drawing.Color.DimGray;
            this.bHesap5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bHesap5.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bHesap5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHesap5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHesap5.ForeColor = System.Drawing.Color.White;
            this.bHesap5.Location = new System.Drawing.Point(87, 61);
            this.bHesap5.Margin = new System.Windows.Forms.Padding(1);
            this.bHesap5.Name = "bHesap5";
            this.bHesap5.Size = new System.Drawing.Size(84, 58);
            this.bHesap5.TabIndex = 4;
            this.bHesap5.Text = "5";
            this.bHesap5.UseVisualStyleBackColor = false;
            this.bHesap5.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bHesap4
            // 
            this.bHesap4.BackColor = System.Drawing.Color.DimGray;
            this.bHesap4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bHesap4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bHesap4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHesap4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHesap4.ForeColor = System.Drawing.Color.White;
            this.bHesap4.Location = new System.Drawing.Point(1, 61);
            this.bHesap4.Margin = new System.Windows.Forms.Padding(1);
            this.bHesap4.Name = "bHesap4";
            this.bHesap4.Size = new System.Drawing.Size(84, 58);
            this.bHesap4.TabIndex = 3;
            this.bHesap4.Text = "4";
            this.bHesap4.UseVisualStyleBackColor = false;
            this.bHesap4.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bHesap3
            // 
            this.bHesap3.BackColor = System.Drawing.Color.DimGray;
            this.bHesap3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bHesap3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bHesap3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHesap3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHesap3.ForeColor = System.Drawing.Color.White;
            this.bHesap3.Location = new System.Drawing.Point(173, 1);
            this.bHesap3.Margin = new System.Windows.Forms.Padding(1);
            this.bHesap3.Name = "bHesap3";
            this.bHesap3.Size = new System.Drawing.Size(86, 58);
            this.bHesap3.TabIndex = 2;
            this.bHesap3.Text = "3";
            this.bHesap3.UseVisualStyleBackColor = false;
            this.bHesap3.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bHesap2
            // 
            this.bHesap2.BackColor = System.Drawing.Color.DimGray;
            this.bHesap2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bHesap2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bHesap2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHesap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHesap2.ForeColor = System.Drawing.Color.White;
            this.bHesap2.Location = new System.Drawing.Point(87, 1);
            this.bHesap2.Margin = new System.Windows.Forms.Padding(1);
            this.bHesap2.Name = "bHesap2";
            this.bHesap2.Size = new System.Drawing.Size(84, 58);
            this.bHesap2.TabIndex = 1;
            this.bHesap2.Text = "2";
            this.bHesap2.UseVisualStyleBackColor = false;
            this.bHesap2.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bHesap1
            // 
            this.bHesap1.BackColor = System.Drawing.Color.DimGray;
            this.bHesap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bHesap1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bHesap1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHesap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bHesap1.ForeColor = System.Drawing.Color.White;
            this.bHesap1.Location = new System.Drawing.Point(1, 1);
            this.bHesap1.Margin = new System.Windows.Forms.Padding(1);
            this.bHesap1.Name = "bHesap1";
            this.bHesap1.Size = new System.Drawing.Size(84, 58);
            this.bHesap1.TabIndex = 0;
            this.bHesap1.Text = "1";
            this.bHesap1.UseVisualStyleBackColor = false;
            this.bHesap1.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bNakit
            // 
            this.bNakit.BackColor = System.Drawing.Color.Tomato;
            this.bNakit.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bNakit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bNakit.ForeColor = System.Drawing.Color.White;
            this.bNakit.Location = new System.Drawing.Point(4, 311);
            this.bNakit.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.bNakit.Name = "bNakit";
            this.bNakit.Size = new System.Drawing.Size(262, 72);
            this.bNakit.TabIndex = 1;
            this.bNakit.Text = "Onayla";
            this.bNakit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bNakit.UseVisualStyleBackColor = false;
            this.bNakit.Click += new System.EventHandler(this.bNakit_Click);
            // 
            // fNakit_Kart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(269, 385);
            this.Controls.Add(this.bNakit);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNakit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fNakit_Kart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fNakit_Kart";
            this.Load += new System.EventHandler(this.fNakit_Kart_Load);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNakit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button bHesapNokta;
        private System.Windows.Forms.Button bHesap0;
        private System.Windows.Forms.Button bHesapSil;
        private System.Windows.Forms.Button bHesap9;
        private System.Windows.Forms.Button bHesap8;
        private System.Windows.Forms.Button bHesap7;
        private System.Windows.Forms.Button bHesap6;
        private System.Windows.Forms.Button bHesap5;
        private System.Windows.Forms.Button bHesap4;
        private System.Windows.Forms.Button bHesap3;
        private System.Windows.Forms.Button bHesap2;
        private System.Windows.Forms.Button bHesap1;
        private System.Windows.Forms.Button bNakit;
    }
}