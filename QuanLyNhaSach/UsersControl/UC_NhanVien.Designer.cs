namespace QuanLyNhaSach.UsersControl
{
    partial class UC_NhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTimNhanVien = new System.Windows.Forms.Button();
            this.txtTimKiemTen = new System.Windows.Forms.TextBox();
            this.btnSuaNhanVien = new System.Windows.Forms.Button();
            this.dTPNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.btnXoaRongNhanVien = new System.Windows.Forms.Button();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVNhanVien = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLuuNhanVien = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimNhanVien
            // 
            this.btnTimNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNhanVien.Location = new System.Drawing.Point(1103, 324);
            this.btnTimNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimNhanVien.Name = "btnTimNhanVien";
            this.btnTimNhanVien.Size = new System.Drawing.Size(59, 36);
            this.btnTimNhanVien.TabIndex = 59;
            this.btnTimNhanVien.Text = "Tìm";
            this.btnTimNhanVien.UseVisualStyleBackColor = true;
            this.btnTimNhanVien.Click += new System.EventHandler(this.btnTimNhanVien_Click);
            // 
            // txtTimKiemTen
            // 
            this.txtTimKiemTen.Location = new System.Drawing.Point(861, 332);
            this.txtTimKiemTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Size = new System.Drawing.Size(236, 22);
            this.txtTimKiemTen.TabIndex = 58;
            // 
            // btnSuaNhanVien
            // 
            this.btnSuaNhanVien.Location = new System.Drawing.Point(1241, 324);
            this.btnSuaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaNhanVien.Name = "btnSuaNhanVien";
            this.btnSuaNhanVien.Size = new System.Drawing.Size(59, 36);
            this.btnSuaNhanVien.TabIndex = 57;
            this.btnSuaNhanVien.Text = "Sửa";
            this.btnSuaNhanVien.UseVisualStyleBackColor = true;
            this.btnSuaNhanVien.Click += new System.EventHandler(this.btnSuaNhanVien_Click);
            // 
            // dTPNgaySinh
            // 
            this.dTPNgaySinh.Location = new System.Drawing.Point(967, 59);
            this.dTPNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPNgaySinh.Name = "dTPNgaySinh";
            this.dTPNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dTPNgaySinh.TabIndex = 54;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(332, 187);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(265, 22);
            this.txtLuong.TabIndex = 53;
            // 
            // btnXoaRongNhanVien
            // 
            this.btnXoaRongNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaRongNhanVien.Location = new System.Drawing.Point(1064, 245);
            this.btnXoaRongNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaRongNhanVien.Name = "btnXoaRongNhanVien";
            this.btnXoaRongNhanVien.Size = new System.Drawing.Size(103, 48);
            this.btnXoaRongNhanVien.TabIndex = 52;
            this.btnXoaRongNhanVien.Text = "Xóa ";
            this.btnXoaRongNhanVien.UseVisualStyleBackColor = true;
            this.btnXoaRongNhanVien.Click += new System.EventHandler(this.btnXoaRongNhanVien_Click);
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(967, 128);
            this.cbbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(200, 24);
            this.cbbGioiTinh.TabIndex = 51;
            this.cbbGioiTinh.Text = "Chọn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(819, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 50;
            this.label4.Text = "Giới tính";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DGVNhanVien
            // 
            this.DGVNhanVien.AllowUserToAddRows = false;
            this.DGVNhanVien.AllowUserToDeleteRows = false;
            this.DGVNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.DGVNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNhanVien.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGVNhanVien.Location = new System.Drawing.Point(0, 359);
            this.DGVNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVNhanVien.Name = "DGVNhanVien";
            this.DGVNhanVien.ReadOnly = true;
            this.DGVNhanVien.RowHeadersWidth = 51;
            this.DGVNhanVien.RowTemplate.Height = 24;
            this.DGVNhanVien.Size = new System.Drawing.Size(1233, 591);
            this.DGVNhanVien.TabIndex = 49;
            this.DGVNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVNhanVien_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(1, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(323, 37);
            this.label13.TabIndex = 48;
            this.label13.Text = "Danh sách nhân viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(819, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 19);
            this.label11.TabIndex = 47;
            this.label11.Text = "Ngày sinh";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(154, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 46;
            this.label7.Text = "Lương ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnLuuNhanVien
            // 
            this.btnLuuNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuNhanVien.Location = new System.Drawing.Point(915, 245);
            this.btnLuuNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuNhanVien.Name = "btnLuuNhanVien";
            this.btnLuuNhanVien.Size = new System.Drawing.Size(103, 48);
            this.btnLuuNhanVien.TabIndex = 45;
            this.btnLuuNhanVien.Text = "Lưu";
            this.btnLuuNhanVien.UseVisualStyleBackColor = true;
            this.btnLuuNhanVien.Click += new System.EventHandler(this.btnLuuNhanVien_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(154, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Số điện thoại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(154, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tên nhân viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(332, 128);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(265, 22);
            this.txtSoDienThoai.TabIndex = 42;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(332, 64);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(265, 22);
            this.txtTenNhanVien.TabIndex = 41;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(763, 245);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 48);
            this.btnSua.TabIndex = 60;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // UC_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTimNhanVien);
            this.Controls.Add(this.txtTimKiemTen);
            this.Controls.Add(this.btnSuaNhanVien);
            this.Controls.Add(this.dTPNgaySinh);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.btnXoaRongNhanVien);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVNhanVien);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLuuNhanVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtTenNhanVien);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_NhanVien";
            this.Size = new System.Drawing.Size(1200, 950);
            this.Load += new System.EventHandler(this.UC_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimNhanVien;
        private System.Windows.Forms.TextBox txtTimKiemTen;
        private System.Windows.Forms.Button btnSuaNhanVien;
        private System.Windows.Forms.DateTimePicker dTPNgaySinh;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Button btnXoaRongNhanVien;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVNhanVien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLuuNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Button btnSua;
    }
}
