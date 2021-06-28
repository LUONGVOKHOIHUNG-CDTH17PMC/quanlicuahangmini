
namespace Quanlycuahangtienloi
{
    partial class QuanLyKhachHang
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
            this.dgv_KH = new System.Windows.Forms.DataGridView();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hohk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlotkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttimkiemKH = new MetroFramework.Controls.MetroTextBox();
            this.btntimkiemKH = new MetroFramework.Controls.MetroButton();
            this.btnthemKH = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_KH
            // 
            this.dgv_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.hohk,
            this.tenlotkh,
            this.tenkh,
            this.gioitinhkh,
            this.ghichu});
            this.dgv_KH.Location = new System.Drawing.Point(-1, 338);
            this.dgv_KH.Name = "dgv_KH";
            this.dgv_KH.Size = new System.Drawing.Size(804, 310);
            this.dgv_KH.TabIndex = 1;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã Khách Hàng";
            this.makh.Name = "makh";
            this.makh.Width = 134;
            // 
            // hohk
            // 
            this.hohk.DataPropertyName = "hokh";
            this.hohk.HeaderText = "Họ ";
            this.hohk.Name = "hohk";
            this.hohk.Width = 110;
            // 
            // tenlotkh
            // 
            this.tenlotkh.DataPropertyName = "tenlotkh";
            this.tenlotkh.HeaderText = "Tên Lót";
            this.tenlotkh.Name = "tenlotkh";
            this.tenlotkh.Width = 110;
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "tenkh";
            this.tenkh.HeaderText = "Tên";
            this.tenkh.Name = "tenkh";
            this.tenkh.Width = 110;
            // 
            // gioitinhkh
            // 
            this.gioitinhkh.DataPropertyName = "gioitinhkh";
            this.gioitinhkh.HeaderText = "Giới Tính";
            this.gioitinhkh.Name = "gioitinhkh";
            this.gioitinhkh.Width = 110;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 230;
            // 
            // txttimkiemKH
            // 
            // 
            // 
            // 
            this.txttimkiemKH.CustomButton.Image = null;
            this.txttimkiemKH.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.txttimkiemKH.CustomButton.Name = "";
            this.txttimkiemKH.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txttimkiemKH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttimkiemKH.CustomButton.TabIndex = 1;
            this.txttimkiemKH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttimkiemKH.CustomButton.UseSelectable = true;
            this.txttimkiemKH.CustomButton.Visible = false;
            this.txttimkiemKH.Lines = new string[0];
            this.txttimkiemKH.Location = new System.Drawing.Point(466, 123);
            this.txttimkiemKH.MaxLength = 32767;
            this.txttimkiemKH.Name = "txttimkiemKH";
            this.txttimkiemKH.PasswordChar = '\0';
            this.txttimkiemKH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttimkiemKH.SelectedText = "";
            this.txttimkiemKH.SelectionLength = 0;
            this.txttimkiemKH.SelectionStart = 0;
            this.txttimkiemKH.ShortcutsEnabled = true;
            this.txttimkiemKH.Size = new System.Drawing.Size(267, 23);
            this.txttimkiemKH.TabIndex = 13;
            this.txttimkiemKH.UseSelectable = true;
            this.txttimkiemKH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttimkiemKH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btntimkiemKH
            // 
            this.btntimkiemKH.Location = new System.Drawing.Point(367, 107);
            this.btntimkiemKH.Name = "btntimkiemKH";
            this.btntimkiemKH.Size = new System.Drawing.Size(75, 39);
            this.btntimkiemKH.TabIndex = 11;
            this.btntimkiemKH.Text = "Tìm Kiếm";
            this.btntimkiemKH.UseSelectable = true;
            this.btntimkiemKH.Click += new System.EventHandler(this.btntimkiemKH_Click);
            // 
            // btnthemKH
            // 
            this.btnthemKH.Location = new System.Drawing.Point(115, 107);
            this.btnthemKH.Name = "btnthemKH";
            this.btnthemKH.Size = new System.Drawing.Size(75, 39);
            this.btnthemKH.TabIndex = 12;
            this.btnthemKH.Text = "Thêm";
            this.btnthemKH.UseSelectable = true;
            this.btnthemKH.Click += new System.EventHandler(this.btnthemKH_Click);
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 573);
            this.Controls.Add(this.txttimkiemKH);
            this.Controls.Add(this.btntimkiemKH);
            this.Controls.Add(this.btnthemKH);
            this.Controls.Add(this.dgv_KH);
            this.Name = "QuanLyKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txttimkiemKH;
        private MetroFramework.Controls.MetroButton btntimkiemKH;
        private MetroFramework.Controls.MetroButton btnthemKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn hohk;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlotkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        public System.Windows.Forms.DataGridView dgv_KH;
    }
}