namespace BarkodluSatisUygulamasi
{
    partial class fHizliButonÜrünEkle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHizliButonÜrünEkle));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chTumu = new System.Windows.Forms.CheckBox();
            this.lblButonId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunAra = new System.Windows.Forms.TextBox();
            this.dataUrunler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chTumu);
            this.splitContainer1.Panel1.Controls.Add(this.lblButonId);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtUrunAra);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataUrunler);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 103;
            this.splitContainer1.TabIndex = 0;
            // 
            // chTumu
            // 
            this.chTumu.AutoSize = true;
            this.chTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chTumu.Location = new System.Drawing.Point(285, 73);
            this.chTumu.Name = "chTumu";
            this.chTumu.Size = new System.Drawing.Size(139, 24);
            this.chTumu.TabIndex = 5;
            this.chTumu.Text = "Tümünü Göster";
            this.chTumu.UseVisualStyleBackColor = true;
            this.chTumu.CheckedChanged += new System.EventHandler(this.chTumu_CheckedChanged);
            // 
            // lblButonId
            // 
            this.lblButonId.AutoSize = true;
            this.lblButonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblButonId.Location = new System.Drawing.Point(156, 9);
            this.lblButonId.Name = "lblButonId";
            this.lblButonId.Size = new System.Drawing.Size(84, 20);
            this.lblButonId.TabIndex = 4;
            this.lblButonId.Text = "Buton No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buton Numarası :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ürün Ara\r\n";
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAra.Location = new System.Drawing.Point(3, 66);
            this.txtUrunAra.Multiline = true;
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(263, 29);
            this.txtUrunAra.TabIndex = 3;
            this.txtUrunAra.TextChanged += new System.EventHandler(this.txtUrunAra_TextChanged);
            // 
            // dataUrunler
            // 
            this.dataUrunler.AllowUserToAddRows = false;
            this.dataUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUrunler.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataUrunler.EnableHeadersVisualStyles = false;
            this.dataUrunler.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataUrunler.Location = new System.Drawing.Point(0, 0);
            this.dataUrunler.Margin = new System.Windows.Forms.Padding(1);
            this.dataUrunler.Name = "dataUrunler";
            this.dataUrunler.RowHeadersVisible = false;
            this.dataUrunler.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dataUrunler.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataUrunler.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataUrunler.RowTemplate.Height = 32;
            this.dataUrunler.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUrunler.Size = new System.Drawing.Size(800, 343);
            this.dataUrunler.TabIndex = 2;
            this.dataUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUrunler_CellContentClick);
            this.dataUrunler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUrunler_CellContentDoubleClick);
            // 
            // fHizliButonÜrünEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fHizliButonÜrünEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı Buton Ürün Ekleme";
            this.Load += new System.EventHandler(this.HizliButonÜrünEkle_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataUrunler;
        private System.Windows.Forms.CheckBox chTumu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunAra;
        public System.Windows.Forms.Label lblButonId;
        private System.Windows.Forms.Label label1;
    }
}