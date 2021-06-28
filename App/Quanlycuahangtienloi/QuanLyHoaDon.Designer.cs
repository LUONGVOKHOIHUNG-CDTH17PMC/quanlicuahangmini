
namespace Quanlycuahangtienloi
{
    partial class QuanLyHoaDon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nglaphhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttimkiemHD = new MetroFramework.Controls.MetroTextBox();
            this.btntimkiemHD = new MetroFramework.Controls.MetroButton();
            this.btnthemHD = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.manv,
            this.makh,
            this.nglaphhd,
            this.ghichu});
            this.dataGridView1.Location = new System.Drawing.Point(1, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(804, 310);
            this.dataGridView1.TabIndex = 1;
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "mahd";
            this.mahd.HeaderText = "Mã Hóa Đơn";
            this.mahd.Name = "mahd";
            this.mahd.Width = 162;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã Nhân Viên";
            this.manv.Name = "manv";
            this.manv.Width = 162;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã Khách Hàng";
            this.makh.Name = "makh";
            this.makh.Width = 162;
            // 
            // nglaphhd
            // 
            this.nglaphhd.DataPropertyName = "nglaphd";
            this.nglaphhd.HeaderText = "Ngày Lập HĐ";
            this.nglaphhd.Name = "nglaphhd";
            this.nglaphhd.Width = 162;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 162;
            // 
            // txttimkiemHD
            // 
            // 
            // 
            // 
            this.txttimkiemHD.CustomButton.Image = null;
            this.txttimkiemHD.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.txttimkiemHD.CustomButton.Name = "";
            this.txttimkiemHD.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txttimkiemHD.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttimkiemHD.CustomButton.TabIndex = 1;
            this.txttimkiemHD.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttimkiemHD.CustomButton.UseSelectable = true;
            this.txttimkiemHD.CustomButton.Visible = false;
            this.txttimkiemHD.Lines = new string[0];
            this.txttimkiemHD.Location = new System.Drawing.Point(459, 110);
            this.txttimkiemHD.MaxLength = 32767;
            this.txttimkiemHD.Name = "txttimkiemHD";
            this.txttimkiemHD.PasswordChar = '\0';
            this.txttimkiemHD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttimkiemHD.SelectedText = "";
            this.txttimkiemHD.SelectionLength = 0;
            this.txttimkiemHD.SelectionStart = 0;
            this.txttimkiemHD.ShortcutsEnabled = true;
            this.txttimkiemHD.Size = new System.Drawing.Size(267, 23);
            this.txttimkiemHD.TabIndex = 13;
            this.txttimkiemHD.UseSelectable = true;
            this.txttimkiemHD.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttimkiemHD.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btntimkiemHD
            // 
            this.btntimkiemHD.Location = new System.Drawing.Point(360, 94);
            this.btntimkiemHD.Name = "btntimkiemHD";
            this.btntimkiemHD.Size = new System.Drawing.Size(75, 39);
            this.btntimkiemHD.TabIndex = 11;
            this.btntimkiemHD.Text = "Tìm Kiếm";
            this.btntimkiemHD.UseSelectable = true;
            // 
            // btnthemHD
            // 
            this.btnthemHD.Location = new System.Drawing.Point(108, 94);
            this.btnthemHD.Name = "btnthemHD";
            this.btnthemHD.Size = new System.Drawing.Size(75, 39);
            this.btnthemHD.TabIndex = 12;
            this.btnthemHD.Text = "Thêm";
            this.btnthemHD.UseSelectable = true;
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 573);
            this.Controls.Add(this.txttimkiemHD);
            this.Controls.Add(this.btntimkiemHD);
            this.Controls.Add(this.btnthemHD);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyHoaDon";
            this.Text = "Quản Lý Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txttimkiemHD;
        private MetroFramework.Controls.MetroButton btntimkiemHD;
        private MetroFramework.Controls.MetroButton btnthemHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nglaphhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}