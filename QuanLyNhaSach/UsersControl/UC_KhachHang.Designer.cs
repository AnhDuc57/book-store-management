namespace QuanLyNhaSach.UsersControl
{
    partial class UC_KhachHang
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
            this.btnTimKiemKhachHang = new System.Windows.Forms.Button();
            this.txtTimKiemKhachHang = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.DGVKhachHang = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datetimengaymuakh = new System.Windows.Forms.DateTimePicker();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtgiamuakh = new System.Windows.Forms.TextBox();
            this.cbbtheloai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiemKhachHang
            // 
            this.btnTimKiemKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemKhachHang.Location = new System.Drawing.Point(1049, 358);
            this.btnTimKiemKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemKhachHang.Name = "btnTimKiemKhachHang";
            this.btnTimKiemKhachHang.Size = new System.Drawing.Size(59, 36);
            this.btnTimKiemKhachHang.TabIndex = 48;
            this.btnTimKiemKhachHang.Text = "Tìm";
            this.btnTimKiemKhachHang.UseVisualStyleBackColor = true;
            this.btnTimKiemKhachHang.Click += new System.EventHandler(this.btnTimKiemKhachHang_Click);
            // 
            // txtTimKiemKhachHang
            // 
            this.txtTimKiemKhachHang.Location = new System.Drawing.Point(807, 364);
            this.txtTimKiemKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemKhachHang.Name = "txtTimKiemKhachHang";
            this.txtTimKiemKhachHang.Size = new System.Drawing.Size(236, 22);
            this.txtTimKiemKhachHang.TabIndex = 47;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(656, 305);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 36);
            this.btnXoa.TabIndex = 46;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(421, 305);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 36);
            this.btnThem.TabIndex = 45;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DGVKhachHang
            // 
            this.DGVKhachHang.AllowUserToAddRows = false;
            this.DGVKhachHang.AllowUserToDeleteRows = false;
            this.DGVKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.DGVKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVKhachHang.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGVKhachHang.Location = new System.Drawing.Point(0, 398);
            this.DGVKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVKhachHang.Name = "DGVKhachHang";
            this.DGVKhachHang.ReadOnly = true;
            this.DGVKhachHang.RowHeadersWidth = 51;
            this.DGVKhachHang.RowTemplate.Height = 24;
            this.DGVKhachHang.Size = new System.Drawing.Size(1248, 552);
            this.DGVKhachHang.TabIndex = 44;
            this.DGVKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVKhachHang_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(469, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(356, 37);
            this.label13.TabIndex = 43;
            this.label13.Text = "Danh sách khách hàng";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(539, 305);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 36);
            this.btnSua.TabIndex = 42;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tên Sản Phẩm ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Thể Loại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(614, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(614, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Ngày Mua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(614, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Giá ";
            // 
            // datetimengaymuakh
            // 
            this.datetimengaymuakh.Location = new System.Drawing.Point(772, 148);
            this.datetimengaymuakh.Name = "datetimengaymuakh";
            this.datetimengaymuakh.Size = new System.Drawing.Size(200, 22);
            this.datetimengaymuakh.TabIndex = 55;
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(297, 71);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(210, 22);
            this.txttenkh.TabIndex = 56;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(297, 153);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(210, 22);
            this.txttensp.TabIndex = 57;
            this.txttensp.TextChanged += new System.EventHandler(this.txttensp_TextChanged);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(772, 68);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(200, 22);
            this.txtsoluong.TabIndex = 58;
            // 
            // txtgiamuakh
            // 
            this.txtgiamuakh.Location = new System.Drawing.Point(772, 229);
            this.txtgiamuakh.Name = "txtgiamuakh";
            this.txtgiamuakh.Size = new System.Drawing.Size(200, 22);
            this.txtgiamuakh.TabIndex = 59;
            // 
            // cbbtheloai
            // 
            this.cbbtheloai.FormattingEnabled = true;
            this.cbbtheloai.Items.AddRange(new object[] {
            "Khoa Học",
            "Lập Trình",
            "Tạp Chí",
            "Truyện Tranh",
            "Sách Giáo Khoa",
            "Tiểu Thuyết",
            "Tư Duy"});
            this.cbbtheloai.Location = new System.Drawing.Point(297, 230);
            this.cbbtheloai.Name = "cbbtheloai";
            this.cbbtheloai.Size = new System.Drawing.Size(210, 24);
            this.cbbtheloai.TabIndex = 60;
            this.cbbtheloai.Text = "Chọn";
            this.cbbtheloai.SelectedIndexChanged += new System.EventHandler(this.cbbtheloai_SelectedIndexChanged);
            // 
            // UC_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbbtheloai);
            this.Controls.Add(this.txtgiamuakh);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txttenkh);
            this.Controls.Add(this.datetimengaymuakh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiemKhachHang);
            this.Controls.Add(this.txtTimKiemKhachHang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DGVKhachHang);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSua);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_KhachHang";
            this.Size = new System.Drawing.Size(1248, 950);
            this.Load += new System.EventHandler(this.UC_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiemKhachHang;
        private System.Windows.Forms.TextBox txtTimKiemKhachHang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView DGVKhachHang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datetimengaymuakh;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtgiamuakh;
        private System.Windows.Forms.ComboBox cbbtheloai;
    }
}
