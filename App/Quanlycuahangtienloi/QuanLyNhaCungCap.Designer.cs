
namespace Quanlycuahangtienloi
{
    partial class QuanLyNhaCungCap
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
            this.dgv_QLNCC = new System.Windows.Forms.DataGridView();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthemNCC = new MetroFramework.Controls.MetroButton();
            this.btntimkiemNCC = new MetroFramework.Controls.MetroButton();
            this.txttimkiemNCC = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_QLNCC
            // 
            this.dgv_QLNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mancc,
            this.tenncc,
            this.diachi,
            this.email,
            this.sdt,
            this.trangthai});
            this.dgv_QLNCC.Location = new System.Drawing.Point(-3, 210);
            this.dgv_QLNCC.Name = "dgv_QLNCC";
            this.dgv_QLNCC.ReadOnly = true;
            this.dgv_QLNCC.Size = new System.Drawing.Size(807, 573);
            this.dgv_QLNCC.TabIndex = 1;
            this.dgv_QLNCC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLNCC_CellDoubleClick);
            // 
            // mancc
            // 
            this.mancc.DataPropertyName = "mancc";
            this.mancc.HeaderText = "Mã NCC";
            this.mancc.Name = "mancc";
            this.mancc.ReadOnly = true;
            this.mancc.Width = 110;
            // 
            // tenncc
            // 
            this.tenncc.DataPropertyName = "tenncc";
            this.tenncc.HeaderText = "Tên NCC";
            this.tenncc.Name = "tenncc";
            this.tenncc.ReadOnly = true;
            this.tenncc.Width = 110;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            this.diachi.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 110;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            this.trangthai.Width = 127;
            // 
            // btnthemNCC
            // 
            this.btnthemNCC.Location = new System.Drawing.Point(79, 100);
            this.btnthemNCC.Name = "btnthemNCC";
            this.btnthemNCC.Size = new System.Drawing.Size(75, 39);
            this.btnthemNCC.TabIndex = 9;
            this.btnthemNCC.Text = "Thêm";
            this.btnthemNCC.UseSelectable = true;
            this.btnthemNCC.Click += new System.EventHandler(this.btnthemNCC_Click);
            // 
            // btntimkiemNCC
            // 
            this.btntimkiemNCC.Location = new System.Drawing.Point(331, 100);
            this.btntimkiemNCC.Name = "btntimkiemNCC";
            this.btntimkiemNCC.Size = new System.Drawing.Size(75, 39);
            this.btntimkiemNCC.TabIndex = 9;
            this.btntimkiemNCC.Text = "Tìm Kiếm";
            this.btntimkiemNCC.UseSelectable = true;
            this.btntimkiemNCC.Click += new System.EventHandler(this.btntimkiemNCC_Click);
            // 
            // txttimkiemNCC
            // 
            // 
            // 
            // 
            this.txttimkiemNCC.CustomButton.Image = null;
            this.txttimkiemNCC.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.txttimkiemNCC.CustomButton.Name = "";
            this.txttimkiemNCC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txttimkiemNCC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttimkiemNCC.CustomButton.TabIndex = 1;
            this.txttimkiemNCC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttimkiemNCC.CustomButton.UseSelectable = true;
            this.txttimkiemNCC.CustomButton.Visible = false;
            this.txttimkiemNCC.Lines = new string[0];
            this.txttimkiemNCC.Location = new System.Drawing.Point(430, 116);
            this.txttimkiemNCC.MaxLength = 32767;
            this.txttimkiemNCC.Name = "txttimkiemNCC";
            this.txttimkiemNCC.PasswordChar = '\0';
            this.txttimkiemNCC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttimkiemNCC.SelectedText = "";
            this.txttimkiemNCC.SelectionLength = 0;
            this.txttimkiemNCC.SelectionStart = 0;
            this.txttimkiemNCC.ShortcutsEnabled = true;
            this.txttimkiemNCC.Size = new System.Drawing.Size(267, 23);
            this.txttimkiemNCC.TabIndex = 10;
            this.txttimkiemNCC.UseSelectable = true;
            this.txttimkiemNCC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttimkiemNCC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(430, 155);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(68, 15);
            this.metroCheckBox1.TabIndex = 11;
            this.metroCheckBox1.Text = "Sử Dụng";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(582, 155);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(106, 15);
            this.metroCheckBox2.TabIndex = 12;
            this.metroCheckBox2.Text = "Không Sử Dụng";
            this.metroCheckBox2.UseSelectable = true;
            // 
            // QuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 573);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.txttimkiemNCC);
            this.Controls.Add(this.btntimkiemNCC);
            this.Controls.Add(this.btnthemNCC);
            this.Controls.Add(this.dgv_QLNCC);
            this.Name = "QuanLyNhaCungCap";
            this.Load += new System.EventHandler(this.QuanLyNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnthemNCC;
        private MetroFramework.Controls.MetroButton btntimkiemNCC;
        private MetroFramework.Controls.MetroTextBox txttimkiemNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        public System.Windows.Forms.DataGridView dgv_QLNCC;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
    }
}