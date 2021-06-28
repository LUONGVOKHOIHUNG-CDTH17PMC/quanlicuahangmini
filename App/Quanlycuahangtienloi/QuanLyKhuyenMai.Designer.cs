
namespace Quanlycuahangtienloi
{
    partial class QuanLyKhuyenMai
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
            this.dgv_KM = new System.Windows.Forms.DataGridView();
            this.btnthemKM = new MetroFramework.Controls.MetroButton();
            this.btntimkiemKM = new MetroFramework.Controls.MetroButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianbatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chietkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_KM
            // 
            this.dgv_KM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.makm,
            this.thoigianbatdau,
            this.thoigianketthuc,
            this.chietkhau});
            this.dgv_KM.Location = new System.Drawing.Point(-2, 208);
            this.dgv_KM.Name = "dgv_KM";
            this.dgv_KM.Size = new System.Drawing.Size(799, 192);
            this.dgv_KM.TabIndex = 0;
            // 
            // btnthemKM
            // 
            this.btnthemKM.Location = new System.Drawing.Point(42, 53);
            this.btnthemKM.Name = "btnthemKM";
            this.btnthemKM.Size = new System.Drawing.Size(83, 39);
            this.btnthemKM.TabIndex = 1;
            this.btnthemKM.Text = "Thêm";
            this.btnthemKM.UseSelectable = true;
            this.btnthemKM.Click += new System.EventHandler(this.btnthemKM_Click);
            // 
            // btntimkiemKM
            // 
            this.btntimkiemKM.Location = new System.Drawing.Point(288, 53);
            this.btntimkiemKM.Name = "btntimkiemKM";
            this.btntimkiemKM.Size = new System.Drawing.Size(83, 39);
            this.btntimkiemKM.TabIndex = 1;
            this.btntimkiemKM.Text = "Tìm Kiếm";
            this.btntimkiemKM.UseSelectable = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(427, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 38);
            this.textBox1.TabIndex = 2;
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã Sản Phẩm";
            this.masp.Name = "masp";
            // 
            // makm
            // 
            this.makm.DataPropertyName = "makm";
            this.makm.HeaderText = "Mã Khuyến Mãi";
            this.makm.Name = "makm";
            // 
            // thoigianbatdau
            // 
            this.thoigianbatdau.DataPropertyName = "thoigianbatdau";
            this.thoigianbatdau.HeaderText = "Thời Gian Bắt Đầu";
            this.thoigianbatdau.Name = "thoigianbatdau";
            // 
            // thoigianketthuc
            // 
            this.thoigianketthuc.DataPropertyName = "thoigianketthuc";
            this.thoigianketthuc.HeaderText = "Thời Gian Kết Thúc";
            this.thoigianketthuc.Name = "thoigianketthuc";
            // 
            // chietkhau
            // 
            this.chietkhau.DataPropertyName = "chietkhau";
            this.chietkhau.HeaderText = "Chiết Khấu %";
            this.chietkhau.Name = "chietkhau";
            // 
            // QuanLyKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 400);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btntimkiemKM);
            this.Controls.Add(this.btnthemKM);
            this.Controls.Add(this.dgv_KM);
            this.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "QuanLyKhuyenMai";
            this.Text = "QuanLyKhuyenMai";
            this.Load += new System.EventHandler(this.QuanLyKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_KM;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn makm;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianbatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn chietkhau;
        private MetroFramework.Controls.MetroButton btnthemKM;
        private MetroFramework.Controls.MetroButton btntimkiemKM;
        private System.Windows.Forms.TextBox textBox1;
    }
}