using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BarkodluSatisUygulamasi
{
    class Araclar
    {
    }
    class LblStandart: Label
    {
        public LblStandart()
        {
            this.ForeColor = Color.Black;
            this.Text = "lblStandart";
            this.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.Name="lblStandart";
        }
    }
    class btnStandart:Button
    {
        public btnStandart()
        {
            this.BackColor = Color.Tomato;
            this.FlatAppearance.BorderColor = Color.Tomato;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Microsoft Sans Serif", 10F,FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = Color.White;
            this.Image = global::BarkodluSatisUygulamasi.Properties.Resources.tl_48;
            this.Location = new Point(1, 0);
            this.Margin = new Padding(1, 0, 0, 0);
            this.Name = "bNakit";
            this.Size = new Size(81, 112);
            this.TabIndex = 0;
            this.Text = "NAKİT\r\n(F1)";
            this.TextImageRelation = TextImageRelation.ImageAboveText;
            this.UseVisualStyleBackColor = false;
        }
    }
    class txtStandart : TextBox
    {
        public txtStandart()
        {
            this.Size = new Size(250, 26);
            this.BackColor = Color.White;
            this.Font = new Font("Microsoft Sans Serif", 12F);
        }
    }
    class txtNumeric:TextBox
    {
        public txtNumeric()
        {
            this.Size = new Size(115, 26);
            this.BackColor = Color.White;
            this.Font = new Font("Microsoft Sans Serif", 12F);
            this.Name = "txtNumeric";
            this.TextAlign = HorizontalAlignment.Right;
            this.Click += TxtNumeric_Click;
            this.KeyPress += TxtNumeric_KeyPress;
        }
        private void TxtNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)==false&&e.KeyChar!=(char)08&&e.KeyChar!=(char)44)
                e.Handled = true;
        }
        private void TxtNumeric_Click(object sender, EventArgs e)
        {
            this.SelectAll();
        }
    }
    class dataOzel:DataGridView
    {
        public dataOzel()
        {
            this.AllowUserToAddRows = false;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.BackgroundColor = SystemColors.GradientActiveCaption;
            this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.BorderStyle = BorderStyle.None;
            this.DefaultCellStyle.BackColor =Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));
            this.DefaultCellStyle.ForeColor = Color.White;
            this.DefaultCellStyle.Padding = new Padding(3);
            this.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            this.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            this.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.ColumnHeadersDefaultCellStyle = this.DefaultCellStyle;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dock = DockStyle.Fill;
            this.EnableHeadersVisualStyles = false;
            this.GridColor = SystemColors.ActiveCaption;
            this.Location = new Point(1, 101);
            this.Margin = new Padding(1);
            this.Name = "dataVeri";
            this.RowHeadersVisible = false;
            this.RowTemplate.DefaultCellStyle.Padding = new Padding(3);
            this.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            this.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.RowTemplate.Height = 32;
            this.ScrollBars = ScrollBars.None;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Size = new Size(409, 358); ;
        }
    }
}
