
namespace Quanlycuahangtienloi
{
    partial class QuanLySanPham
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
            this.dgv_QLSP = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttimkiemSP = new MetroFramework.Controls.MetroTextBox();
            this.btntimkiemSP = new MetroFramework.Controls.MetroButton();
            this.btnthemSP = new MetroFramework.Controls.MetroButton();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_QLSP
            // 
            this.dgv_QLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.mancc,
            this.mota,
            this.donvitinh,
            this.soluong,
            this.dongia,
            this.ghichu,
            this.trangthai});
            this.dgv_QLSP.Location = new System.Drawing.Point(9, 239);
            this.dgv_QLSP.Name = "dgv_QLSP";
            this.dgv_QLSP.ReadOnly = true;
            this.dgv_QLSP.Size = new System.Drawing.Size(947, 573);
            this.dgv_QLSP.TabIndex = 1;
            this.dgv_QLSP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã SP";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "tensp";
            this.tensp.HeaderText = "Tên SP";
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // mancc
            // 
            this.mancc.DataPropertyName = "mancc";
            this.mancc.HeaderText = "Mã NCC";
            this.mancc.Name = "mancc";
            this.mancc.ReadOnly = true;
            // 
            // mota
            // 
            this.mota.DataPropertyName = "mota";
            this.mota.HeaderText = "Mô Tả";
            this.mota.Name = "mota";
            this.mota.ReadOnly = true;
            // 
            // donvitinh
            // 
            this.donvitinh.DataPropertyName = "donvitinh";
            this.donvitinh.HeaderText = "Đơn Vị Tính";
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn Giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // txttimkiemSP
            // 
            // 
            // 
            // 
            this.txttimkiemSP.CustomButton.Image = null;
            this.txttimkiemSP.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.txttimkiemSP.CustomButton.Name = "";
            this.txttimkiemSP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txttimkiemSP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttimkiemSP.CustomButton.TabIndex = 1;
            this.txttimkiemSP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttimkiemSP.CustomButton.UseSelectable = true;
            this.txttimkiemSP.CustomButton.Visible = false;
            this.txttimkiemSP.Lines = new string[0];
            this.txttimkiemSP.Location = new System.Drawing.Point(456, 119);
            this.txttimkiemSP.MaxLength = 32767;
            this.txttimkiemSP.Name = "txttimkiemSP";
            this.txttimkiemSP.PasswordChar = '\0';
            this.txttimkiemSP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttimkiemSP.SelectedText = "";
            this.txttimkiemSP.SelectionLength = 0;
            this.txttimkiemSP.SelectionStart = 0;
            this.txttimkiemSP.ShortcutsEnabled = true;
            this.txttimkiemSP.Size = new System.Drawing.Size(267, 23);
            this.txttimkiemSP.TabIndex = 13;
            this.txttimkiemSP.UseSelectable = true;
            this.txttimkiemSP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttimkiemSP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btntimkiemSP
            // 
            this.btntimkiemSP.Location = new System.Drawing.Point(357, 103);
            this.btntimkiemSP.Name = "btntimkiemSP";
            this.btntimkiemSP.Size = new System.Drawing.Size(75, 39);
            this.btntimkiemSP.TabIndex = 11;
            this.btntimkiemSP.Text = "Tìm Kiếm";
            this.btntimkiemSP.UseSelectable = true;
            this.btntimkiemSP.Click += new System.EventHandler(this.btntimkiemSP_Click);
            // 
            // btnthemSP
            // 
            this.btnthemSP.Location = new System.Drawing.Point(105, 103);
            this.btnthemSP.Name = "btnthemSP";
            this.btnthemSP.Size = new System.Drawing.Size(75, 39);
            this.btnthemSP.TabIndex = 12;
            this.btnthemSP.Text = "Thêm";
            this.btnthemSP.UseSelectable = true;
            this.btnthemSP.Click += new System.EventHandler(this.btnthemSP_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(456, 163);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(68, 15);
            this.metroCheckBox1.TabIndex = 14;
            this.metroCheckBox1.Text = "Sử Dụng";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(609, 163);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(106, 15);
            this.metroCheckBox2.TabIndex = 14;
            this.metroCheckBox2.Text = "Không Sử Dụng";
            this.metroCheckBox2.UseSelectable = true;
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 573);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.txttimkiemSP);
            this.Controls.Add(this.btntimkiemSP);
            this.Controls.Add(this.btnthemSP);
            this.Controls.Add(this.dgv_QLSP);
            this.Name = "QuanLySanPham";
            this.Text = "Quản Lý Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txttimkiemSP;
        private MetroFramework.Controls.MetroButton btntimkiemSP;
        private MetroFramework.Controls.MetroButton btnthemSP;
        public System.Windows.Forms.DataGridView dgv_QLSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
    }
}