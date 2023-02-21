namespace QuanLyNhaSach.UsersControl
{
    partial class UC_HoaDon
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
            this.btnTimKiemHoaDon = new System.Windows.Forms.Button();
            this.txtTimKiemHoaDon = new System.Windows.Forms.TextBox();
            this.DGVHoaDon = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtgiamua = new System.Windows.Forms.TextBox();
            this.datetimengaymua = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiemHoaDon
            // 
            this.btnTimKiemHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemHoaDon.Location = new System.Drawing.Point(794, 287);
            this.btnTimKiemHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemHoaDon.Name = "btnTimKiemHoaDon";
            this.btnTimKiemHoaDon.Size = new System.Drawing.Size(69, 22);
            this.btnTimKiemHoaDon.TabIndex = 47;
            this.btnTimKiemHoaDon.Text = "Tìm";
            this.btnTimKiemHoaDon.UseVisualStyleBackColor = true;
            this.btnTimKiemHoaDon.Click += new System.EventHandler(this.btnTimKiemHoaDon_Click);
            // 
            // txtTimKiemHoaDon
            // 
            this.txtTimKiemHoaDon.Location = new System.Drawing.Point(612, 287);
            this.txtTimKiemHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiemHoaDon.Name = "txtTimKiemHoaDon";
            this.txtTimKiemHoaDon.Size = new System.Drawing.Size(178, 22);
            this.txtTimKiemHoaDon.TabIndex = 46;
            // 
            // DGVHoaDon
            // 
            this.DGVHoaDon.AllowUserToAddRows = false;
            this.DGVHoaDon.AllowUserToDeleteRows = false;
            this.DGVHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.DGVHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHoaDon.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGVHoaDon.Location = new System.Drawing.Point(2, 320);
            this.DGVHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.DGVHoaDon.Name = "DGVHoaDon";
            this.DGVHoaDon.ReadOnly = true;
            this.DGVHoaDon.RowHeadersWidth = 51;
            this.DGVHoaDon.RowTemplate.Height = 24;
            this.DGVHoaDon.Size = new System.Drawing.Size(933, 452);
            this.DGVHoaDon.TabIndex = 41;
            this.DGVHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVHoaDon_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(356, 10);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(301, 37);
            this.label13.TabIndex = 40;
            this.label13.Text = "Danh sách hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mã Hoá Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tên Sản Phẩm ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Ngày Mua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Giá";
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(213, 104);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(191, 22);
            this.txtmahd.TabIndex = 54;
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(213, 145);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(191, 22);
            this.txttenkh.TabIndex = 55;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(213, 193);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(191, 22);
            this.txttensp.TabIndex = 56;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(608, 147);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(200, 22);
            this.txtsoluong.TabIndex = 57;
            // 
            // txtgiamua
            // 
            this.txtgiamua.Location = new System.Drawing.Point(608, 202);
            this.txtgiamua.Name = "txtgiamua";
            this.txtgiamua.Size = new System.Drawing.Size(200, 22);
            this.txtgiamua.TabIndex = 58;
            // 
            // datetimengaymua
            // 
            this.datetimengaymua.Location = new System.Drawing.Point(608, 110);
            this.datetimengaymua.Name = "datetimengaymua";
            this.datetimengaymua.Size = new System.Drawing.Size(200, 22);
            this.datetimengaymua.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(184, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 35);
            this.button1.TabIndex = 60;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(304, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 35);
            this.button2.TabIndex = 61;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(422, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 35);
            this.button3.TabIndex = 62;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UC_HoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datetimengaymua);
            this.Controls.Add(this.txtgiamua);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txttenkh);
            this.Controls.Add(this.txtmahd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiemHoaDon);
            this.Controls.Add(this.txtTimKiemHoaDon);
            this.Controls.Add(this.DGVHoaDon);
            this.Controls.Add(this.label13);
            this.Name = "UC_HoaDon";
            this.Size = new System.Drawing.Size(887, 772);
            ((System.ComponentModel.ISupportInitialize)(this.DGVHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiemHoaDon;
        private System.Windows.Forms.TextBox txtTimKiemHoaDon;
        private System.Windows.Forms.DataGridView DGVHoaDon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtgiamua;
        private System.Windows.Forms.DateTimePicker datetimengaymua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
