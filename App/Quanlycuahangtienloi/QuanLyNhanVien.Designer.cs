
namespace Quanlycuahangtienloi
{
    partial class QuanLyNhanVien
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
            this.dgv_NV = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.honv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayvaolam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttimkiemNV = new MetroFramework.Controls.MetroTextBox();
            this.btntimkiemNV = new MetroFramework.Controls.MetroButton();
            this.btnthemNV = new MetroFramework.Controls.MetroButton();
            this.CBsudung = new MetroFramework.Controls.MetroCheckBox();
            this.CBkhongsudung = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_NV
            // 
            this.dgv_NV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.taikhoan,
            this.matkhau,
            this.honv,
            this.tenlot,
            this.tennv,
            this.gioitinh,
            this.ngaysinh,
            this.diachi,
            this.sdt,
            this.ngayvaolam,
            this.chucvu,
            this.email,
            this.trangthai});
            this.dgv_NV.Location = new System.Drawing.Point(-20, 250);
            this.dgv_NV.Name = "dgv_NV";
            this.dgv_NV.Size = new System.Drawing.Size(1207, 543);
            this.dgv_NV.TabIndex = 2;
            this.dgv_NV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NV_CellDoubleClick);
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã Nhân Viên";
            this.manv.Name = "manv";
            // 
            // taikhoan
            // 
            this.taikhoan.DataPropertyName = "taikhoan";
            this.taikhoan.HeaderText = "Tài Khoản";
            this.taikhoan.Name = "taikhoan";
            // 
            // matkhau
            // 
            this.matkhau.DataPropertyName = "matkhau";
            this.matkhau.HeaderText = "Mật Khẩu";
            this.matkhau.Name = "matkhau";
            // 
            // honv
            // 
            this.honv.DataPropertyName = "honv";
            this.honv.HeaderText = "Họ";
            this.honv.Name = "honv";
            // 
            // tenlot
            // 
            this.tenlot.DataPropertyName = "tenlot";
            this.tenlot.HeaderText = "Tên Lót";
            this.tenlot.Name = "tenlot";
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Tên";
            this.tennv.Name = "tennv";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            // 
            // ngayvaolam
            // 
            this.ngayvaolam.DataPropertyName = "ngayvaolam";
            this.ngayvaolam.HeaderText = "Ngày Vào Làm";
            this.ngayvaolam.Name = "ngayvaolam";
            // 
            // chucvu
            // 
            this.chucvu.DataPropertyName = "chucvu";
            this.chucvu.HeaderText = "Chức Vụ";
            this.chucvu.Name = "chucvu";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.Name = "trangthai";
            // 
            // txttimkiemNV
            // 
            // 
            // 
            // 
            this.txttimkiemNV.CustomButton.Image = null;
            this.txttimkiemNV.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.txttimkiemNV.CustomButton.Name = "";
            this.txttimkiemNV.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txttimkiemNV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttimkiemNV.CustomButton.TabIndex = 1;
            this.txttimkiemNV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttimkiemNV.CustomButton.UseSelectable = true;
            this.txttimkiemNV.CustomButton.Visible = false;
            this.txttimkiemNV.Lines = new string[0];
            this.txttimkiemNV.Location = new System.Drawing.Point(469, 112);
            this.txttimkiemNV.MaxLength = 32767;
            this.txttimkiemNV.Name = "txttimkiemNV";
            this.txttimkiemNV.PasswordChar = '\0';
            this.txttimkiemNV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttimkiemNV.SelectedText = "";
            this.txttimkiemNV.SelectionLength = 0;
            this.txttimkiemNV.SelectionStart = 0;
            this.txttimkiemNV.ShortcutsEnabled = true;
            this.txttimkiemNV.Size = new System.Drawing.Size(267, 23);
            this.txttimkiemNV.TabIndex = 13;
            this.txttimkiemNV.UseSelectable = true;
            this.txttimkiemNV.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttimkiemNV.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btntimkiemNV
            // 
            this.btntimkiemNV.Location = new System.Drawing.Point(370, 96);
            this.btntimkiemNV.Name = "btntimkiemNV";
            this.btntimkiemNV.Size = new System.Drawing.Size(75, 39);
            this.btntimkiemNV.TabIndex = 11;
            this.btntimkiemNV.Text = "Tìm Kiếm";
            this.btntimkiemNV.UseSelectable = true;
            this.btntimkiemNV.Click += new System.EventHandler(this.btntimkiemNV_Click);
            // 
            // btnthemNV
            // 
            this.btnthemNV.Location = new System.Drawing.Point(118, 96);
            this.btnthemNV.Name = "btnthemNV";
            this.btnthemNV.Size = new System.Drawing.Size(75, 39);
            this.btnthemNV.TabIndex = 12;
            this.btnthemNV.Text = "Thêm";
            this.btnthemNV.UseSelectable = true;
            this.btnthemNV.Click += new System.EventHandler(this.btnthemNV_Click);
            // 
            // CBsudung
            // 
            this.CBsudung.AutoSize = true;
            this.CBsudung.Location = new System.Drawing.Point(469, 156);
            this.CBsudung.Name = "CBsudung";
            this.CBsudung.Size = new System.Drawing.Size(68, 15);
            this.CBsudung.TabIndex = 14;
            this.CBsudung.Text = "Sử Dụng";
            this.CBsudung.UseSelectable = true;
            // 
            // CBkhongsudung
            // 
            this.CBkhongsudung.AutoSize = true;
            this.CBkhongsudung.Location = new System.Drawing.Point(622, 156);
            this.CBkhongsudung.Name = "CBkhongsudung";
            this.CBkhongsudung.Size = new System.Drawing.Size(106, 15);
            this.CBkhongsudung.TabIndex = 14;
            this.CBkhongsudung.Text = "Không Sử Dụng";
            this.CBkhongsudung.UseSelectable = true;
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 543);
            this.Controls.Add(this.CBkhongsudung);
            this.Controls.Add(this.CBsudung);
            this.Controls.Add(this.txttimkiemNV);
            this.Controls.Add(this.btntimkiemNV);
            this.Controls.Add(this.btnthemNV);
            this.Controls.Add(this.dgv_NV);
            this.Name = "QuanLyNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txttimkiemNV;
        private MetroFramework.Controls.MetroButton btntimkiemNV;
        private MetroFramework.Controls.MetroButton btnthemNV;
        public System.Windows.Forms.DataGridView dgv_NV;
        public MetroFramework.Controls.MetroCheckBox CBsudung;
        public MetroFramework.Controls.MetroCheckBox CBkhongsudung;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn honv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayvaolam;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}

