
namespace Quanlycuahangtienloi
{
    partial class QuanLyChiTietPhieuNhapKho
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.manhapkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhethan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthemCTPNK = new MetroFramework.Controls.MetroButton();
            this.btntimCTPNK = new MetroFramework.Controls.MetroButton();
            this.txttimCTPNK = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhapkho,
            this.masp,
            this.soluong,
            this.dongia,
            this.thanhtien,
            this.ngayhethan});
            this.dataGridView2.Location = new System.Drawing.Point(-1, 279);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(807, 561);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // manhapkho
            // 
            this.manhapkho.DataPropertyName = "manhapkho";
            this.manhapkho.HeaderText = "Mã Nhập Kho";
            this.manhapkho.Name = "manhapkho";
            this.manhapkho.ReadOnly = true;
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã Sản Phẩm";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
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
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành Tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // ngayhethan
            // 
            this.ngayhethan.DataPropertyName = "ngayhethan";
            this.ngayhethan.HeaderText = "Ngày Hết Hạn";
            this.ngayhethan.Name = "ngayhethan";
            this.ngayhethan.ReadOnly = true;
            // 
            // btnthemCTPNK
            // 
            this.btnthemCTPNK.Location = new System.Drawing.Point(68, 98);
            this.btnthemCTPNK.Name = "btnthemCTPNK";
            this.btnthemCTPNK.Size = new System.Drawing.Size(75, 23);
            this.btnthemCTPNK.TabIndex = 3;
            this.btnthemCTPNK.Text = "Thêm";
            this.btnthemCTPNK.UseSelectable = true;
            this.btnthemCTPNK.Click += new System.EventHandler(this.btnthemCTPNK_Click);
            // 
            // btntimCTPNK
            // 
            this.btntimCTPNK.Location = new System.Drawing.Point(330, 98);
            this.btntimCTPNK.Name = "btntimCTPNK";
            this.btntimCTPNK.Size = new System.Drawing.Size(75, 23);
            this.btntimCTPNK.TabIndex = 4;
            this.btntimCTPNK.Text = "Tìm Kiếm";
            this.btntimCTPNK.UseSelectable = true;
            this.btntimCTPNK.Click += new System.EventHandler(this.btntimCTPNK_Click);
            // 
            // txttimCTPNK
            // 
            // 
            // 
            // 
            this.txttimCTPNK.CustomButton.Image = null;
            this.txttimCTPNK.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.txttimCTPNK.CustomButton.Name = "";
            this.txttimCTPNK.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txttimCTPNK.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttimCTPNK.CustomButton.TabIndex = 1;
            this.txttimCTPNK.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttimCTPNK.CustomButton.UseSelectable = true;
            this.txttimCTPNK.CustomButton.Visible = false;
            this.txttimCTPNK.Lines = new string[0];
            this.txttimCTPNK.Location = new System.Drawing.Point(475, 97);
            this.txttimCTPNK.MaxLength = 32767;
            this.txttimCTPNK.Name = "txttimCTPNK";
            this.txttimCTPNK.PasswordChar = '\0';
            this.txttimCTPNK.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttimCTPNK.SelectedText = "";
            this.txttimCTPNK.SelectionLength = 0;
            this.txttimCTPNK.SelectionStart = 0;
            this.txttimCTPNK.ShortcutsEnabled = true;
            this.txttimCTPNK.Size = new System.Drawing.Size(254, 23);
            this.txttimCTPNK.TabIndex = 5;
            this.txttimCTPNK.UseSelectable = true;
            this.txttimCTPNK.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttimCTPNK.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QuanLyChiTietPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 573);
            this.Controls.Add(this.txttimCTPNK);
            this.Controls.Add(this.btntimCTPNK);
            this.Controls.Add(this.btnthemCTPNK);
            this.Controls.Add(this.dataGridView2);
            this.Name = "QuanLyChiTietPhieuNhapKho";
            this.Text = "Quản Lý Chi Tiết Phiếu Nhập Kho";
            this.Load += new System.EventHandler(this.QuanLyChiTietPhieuNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnthemCTPNK;
        private MetroFramework.Controls.MetroButton btntimCTPNK;
        private MetroFramework.Controls.MetroTextBox txttimCTPNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhapkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhethan;
        public System.Windows.Forms.DataGridView dataGridView2;
    }
}