namespace DoAnK18_2020.PresentationLayer
{
    partial class EditProduct
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
            this.giamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daDuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ndTomTat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.giaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.ds_SanPham = new System.Windows.Forms.DataGridView();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtDaDuyet = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.txtNgayDang = new System.Windows.Forms.TextBox();
            this.txtNhaSX = new System.Windows.Forms.TextBox();
            this.txtNoiDungTT = new System.Windows.Forms.TextBox();
            this.txtHinhDD = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // giamGia
            // 
            this.giamGia.DataPropertyName = "giamGia";
            this.giamGia.HeaderText = "giảm giá";
            this.giamGia.Name = "giamGia";
            // 
            // daDuyet
            // 
            this.daDuyet.DataPropertyName = "daDuyet";
            this.daDuyet.HeaderText = "Đã Duyệt";
            this.daDuyet.Name = "daDuyet";
            // 
            // taiKhoan
            // 
            this.taiKhoan.DataPropertyName = "taiKhoan";
            this.taiKhoan.HeaderText = "Tài Khoản ";
            this.taiKhoan.Name = "taiKhoan";
            // 
            // noiDung
            // 
            this.noiDung.DataPropertyName = "noiDung";
            this.noiDung.HeaderText = "Nội Dung";
            this.noiDung.Name = "noiDung";
            // 
            // maLoai
            // 
            this.maLoai.DataPropertyName = "maLoai";
            this.maLoai.HeaderText = "Mã Loại";
            this.maLoai.Name = "maLoai";
            // 
            // ngayDang
            // 
            this.ngayDang.DataPropertyName = "ngayDang";
            this.ngayDang.HeaderText = "NgayDang";
            this.ngayDang.Name = "ngayDang";
            // 
            // nhaSanXuat
            // 
            this.nhaSanXuat.DataPropertyName = "nhaSanXuat";
            this.nhaSanXuat.HeaderText = "NhaSX";
            this.nhaSanXuat.Name = "nhaSanXuat";
            // 
            // ndTomTat
            // 
            this.ndTomTat.DataPropertyName = "ndTomTat";
            this.ndTomTat.HeaderText = "NộiDungTT";
            this.ndTomTat.Name = "ndTomTat";
            // 
            // hinhDD
            // 
            this.hinhDD.DataPropertyName = "hinhDD";
            this.hinhDD.HeaderText = "HinhDD";
            this.hinhDD.Name = "hinhDD";
            // 
            // tenSP
            // 
            this.tenSP.DataPropertyName = "tenSP";
            this.tenSP.HeaderText = "Tên Sản Phẩm ";
            this.tenSP.Name = "tenSP";
            // 
            // maSP
            // 
            this.maSP.DataPropertyName = "maSP";
            this.maSP.HeaderText = "Mã sản phẩm";
            this.maSP.Name = "maSP";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(617, 202);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 42);
            this.btnClose.TabIndex = 79;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // giaBan
            // 
            this.giaBan.DataPropertyName = "giaBan";
            this.giaBan.HeaderText = "Giá Bán";
            this.giaBan.Name = "giaBan";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnEdit.Location = new System.Drawing.Point(129, 202);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(306, 50);
            this.btnEdit.TabIndex = 78;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ds_SanPham
            // 
            this.ds_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ds_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSP,
            this.tenSP,
            this.hinhDD,
            this.ndTomTat,
            this.nhaSanXuat,
            this.ngayDang,
            this.maLoai,
            this.noiDung,
            this.taiKhoan,
            this.daDuyet,
            this.giaBan,
            this.giamGia});
            this.ds_SanPham.Location = new System.Drawing.Point(4, 269);
            this.ds_SanPham.Name = "ds_SanPham";
            this.ds_SanPham.Size = new System.Drawing.Size(808, 184);
            this.ds_SanPham.TabIndex = 77;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(617, 164);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(135, 20);
            this.txtGiamGia.TabIndex = 76;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(617, 114);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(135, 20);
            this.txtGiaBan.TabIndex = 75;
            // 
            // txtDaDuyet
            // 
            this.txtDaDuyet.Location = new System.Drawing.Point(617, 58);
            this.txtDaDuyet.Name = "txtDaDuyet";
            this.txtDaDuyet.Size = new System.Drawing.Size(135, 20);
            this.txtDaDuyet.TabIndex = 74;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(617, 15);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(135, 20);
            this.txtTaiKhoan.TabIndex = 73;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(388, 164);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(135, 20);
            this.txtNoiDung.TabIndex = 72;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(388, 110);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(135, 20);
            this.txtMaLoai.TabIndex = 71;
            // 
            // txtNgayDang
            // 
            this.txtNgayDang.Location = new System.Drawing.Point(388, 65);
            this.txtNgayDang.Name = "txtNgayDang";
            this.txtNgayDang.Size = new System.Drawing.Size(135, 20);
            this.txtNgayDang.TabIndex = 70;
            // 
            // txtNhaSX
            // 
            this.txtNhaSX.Location = new System.Drawing.Point(388, 15);
            this.txtNhaSX.Name = "txtNhaSX";
            this.txtNhaSX.Size = new System.Drawing.Size(135, 20);
            this.txtNhaSX.TabIndex = 69;
            // 
            // txtNoiDungTT
            // 
            this.txtNoiDungTT.Location = new System.Drawing.Point(129, 160);
            this.txtNoiDungTT.Name = "txtNoiDungTT";
            this.txtNoiDungTT.Size = new System.Drawing.Size(135, 20);
            this.txtNoiDungTT.TabIndex = 68;
            // 
            // txtHinhDD
            // 
            this.txtHinhDD.Location = new System.Drawing.Point(129, 110);
            this.txtHinhDD.Name = "txtHinhDD";
            this.txtHinhDD.Size = new System.Drawing.Size(135, 20);
            this.txtHinhDD.TabIndex = 67;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(129, 58);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(135, 20);
            this.txtTenSP.TabIndex = 66;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(129, 11);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(135, 20);
            this.txtMaSP.TabIndex = 65;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(541, 167);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "GiamGia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(541, 117);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "GiaBan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(541, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "DaDuyet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(541, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "TaiKhoan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "NoiDung";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "MaLoai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "NgayDang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "NhaSX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "NộiDungTT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "HinhDD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "TenSP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "MaSP";
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 539);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.ds_SanPham);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtDaDuyet);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.txtNgayDang);
            this.Controls.Add(this.txtNhaSX);
            this.Controls.Add(this.txtNoiDungTT);
            this.Controls.Add(this.txtHinhDD);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn giamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn daDuyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndTomTat;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSP;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView ds_SanPham;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtDaDuyet;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtNgayDang;
        private System.Windows.Forms.TextBox txtNhaSX;
        private System.Windows.Forms.TextBox txtNoiDungTT;
        private System.Windows.Forms.TextBox txtHinhDD;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}