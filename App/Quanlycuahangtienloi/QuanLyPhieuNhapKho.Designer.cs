
namespace Quanlycuahangtienloi
{
    partial class QuanLyPhieuNhapKho
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
            this.dgv_PNK = new System.Windows.Forms.DataGridView();
            this.manhapkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttimkiemPNK = new MetroFramework.Controls.MetroTextBox();
            this.btntimkiemPNK = new MetroFramework.Controls.MetroButton();
            this.btnthemPNK = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PNK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PNK
            // 
            this.dgv_PNK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PNK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhapkho,
            this.manv,
            this.mancc,
            this.ngaynhap,
            this.ghichu});
            this.dgv_PNK.Location = new System.Drawing.Point(1, 242);
            this.dgv_PNK.Name = "dgv_PNK";
            this.dgv_PNK.Size = new System.Drawing.Size(804, 310);
            this.dgv_PNK.TabIndex = 1;
            this.dgv_PNK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_PNK.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // manhapkho
            // 
            this.manhapkho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.manhapkho.DataPropertyName = "manhapkho";
            this.manhapkho.HeaderText = "Mã Nhập Kho";
            this.manhapkho.Name = "manhapkho";
            this.manhapkho.Width = 162;
            // 
            // manv
            // 
            this.manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã Nhân Viên";
            this.manv.Name = "manv";
            this.manv.Width = 162;
            // 
            // mancc
            // 
            this.mancc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mancc.DataPropertyName = "mancc";
            this.mancc.HeaderText = "Mã NCC";
            this.mancc.Name = "mancc";
            this.mancc.Width = 162;
            // 
            // ngaynhap
            // 
            this.ngaynhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày Nhập";
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.Width = 162;
            // 
            // ghichu
            // 
            this.ghichu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 162;
            // 
            // txttimkiemPNK
            // 
            // 
            // 
            // 
            this.txttimkiemPNK.CustomButton.Image = null;
            this.txttimkiemPNK.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.txttimkiemPNK.CustomButton.Name = "";
            this.txttimkiemPNK.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txttimkiemPNK.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttimkiemPNK.CustomButton.TabIndex = 1;
            this.txttimkiemPNK.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttimkiemPNK.CustomButton.UseSelectable = true;
            this.txttimkiemPNK.CustomButton.Visible = false;
            this.txttimkiemPNK.Lines = new string[0];
            this.txttimkiemPNK.Location = new System.Drawing.Point(422, 115);
            this.txttimkiemPNK.MaxLength = 32767;
            this.txttimkiemPNK.Name = "txttimkiemPNK";
            this.txttimkiemPNK.PasswordChar = '\0';
            this.txttimkiemPNK.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttimkiemPNK.SelectedText = "";
            this.txttimkiemPNK.SelectionLength = 0;
            this.txttimkiemPNK.SelectionStart = 0;
            this.txttimkiemPNK.ShortcutsEnabled = true;
            this.txttimkiemPNK.Size = new System.Drawing.Size(267, 23);
            this.txttimkiemPNK.TabIndex = 13;
            this.txttimkiemPNK.UseSelectable = true;
            this.txttimkiemPNK.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttimkiemPNK.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btntimkiemPNK
            // 
            this.btntimkiemPNK.Location = new System.Drawing.Point(323, 99);
            this.btntimkiemPNK.Name = "btntimkiemPNK";
            this.btntimkiemPNK.Size = new System.Drawing.Size(75, 39);
            this.btntimkiemPNK.TabIndex = 11;
            this.btntimkiemPNK.Text = "Tìm Kiếm";
            this.btntimkiemPNK.UseSelectable = true;
            this.btntimkiemPNK.Click += new System.EventHandler(this.btntimkiemPNK_Click);
            // 
            // btnthemPNK
            // 
            this.btnthemPNK.Location = new System.Drawing.Point(96, 83);
            this.btnthemPNK.Name = "btnthemPNK";
            this.btnthemPNK.Size = new System.Drawing.Size(75, 39);
            this.btnthemPNK.TabIndex = 12;
            this.btnthemPNK.Text = "Thêm";
            this.btnthemPNK.UseSelectable = true;
            this.btnthemPNK.Click += new System.EventHandler(this.btnthemPNK_Click);
            // 
            // QuanLyPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 573);
            this.Controls.Add(this.txttimkiemPNK);
            this.Controls.Add(this.btntimkiemPNK);
            this.Controls.Add(this.btnthemPNK);
            this.Controls.Add(this.dgv_PNK);
            this.Name = "QuanLyPhieuNhapKho";
            this.Text = "Phiếu Nhập Kho";
            this.Load += new System.EventHandler(this.QuanLyPhieuNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PNK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txttimkiemPNK;
        private MetroFramework.Controls.MetroButton btntimkiemPNK;
        private MetroFramework.Controls.MetroButton btnthemPNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhapkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        public System.Windows.Forms.DataGridView dgv_PNK;
    }
}