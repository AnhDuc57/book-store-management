namespace QuanLyNhaSach.UsersControl
{
    partial class UC_ThongKe
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
            this.dtHoadon = new System.Windows.Forms.DataGridView();
            this.dtChitiet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnKiemtra = new System.Windows.Forms.Button();
            this.lb_Tong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtChitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtHoadon
            // 
            this.dtHoadon.AllowUserToAddRows = false;
            this.dtHoadon.AllowUserToDeleteRows = false;
            this.dtHoadon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHoadon.Location = new System.Drawing.Point(55, 142);
            this.dtHoadon.Name = "dtHoadon";
            this.dtHoadon.ReadOnly = true;
            this.dtHoadon.RowHeadersWidth = 51;
            this.dtHoadon.RowTemplate.Height = 24;
            this.dtHoadon.Size = new System.Drawing.Size(536, 280);
            this.dtHoadon.TabIndex = 0;
            this.dtHoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtHoadon_CellClick);
            // 
            // dtChitiet
            // 
            this.dtChitiet.AllowUserToAddRows = false;
            this.dtChitiet.AllowUserToDeleteRows = false;
            this.dtChitiet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtChitiet.Location = new System.Drawing.Point(613, 142);
            this.dtChitiet.Name = "dtChitiet";
            this.dtChitiet.ReadOnly = true;
            this.dtChitiet.RowHeadersWidth = 51;
            this.dtChitiet.RowTemplate.Height = 24;
            this.dtChitiet.Size = new System.Drawing.Size(530, 280);
            this.dtChitiet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bảng Thống Kê Doanh Thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 593);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 593);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đến";
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(333, 593);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(243, 22);
            this.dtBegin.TabIndex = 5;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(715, 592);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(244, 22);
            this.dtEnd.TabIndex = 6;
            // 
            // btnKiemtra
            // 
            this.btnKiemtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemtra.Location = new System.Drawing.Point(758, 688);
            this.btnKiemtra.Name = "btnKiemtra";
            this.btnKiemtra.Size = new System.Drawing.Size(124, 48);
            this.btnKiemtra.TabIndex = 7;
            this.btnKiemtra.Text = "Xem";
            this.btnKiemtra.UseVisualStyleBackColor = true;
            this.btnKiemtra.Click += new System.EventHandler(this.btnKiemtra_Click);
            // 
            // lb_Tong
            // 
            this.lb_Tong.AutoSize = true;
            this.lb_Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tong.Location = new System.Drawing.Point(328, 694);
            this.lb_Tong.Name = "lb_Tong";
            this.lb_Tong.Size = new System.Drawing.Size(140, 29);
            this.lb_Tong.TabIndex = 8;
            this.lb_Tong.Text = "Doanh Thu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bảng Thống Kê Hoá Đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bảng Hoá Đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(799, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Chi Tiết Hoá Đơn";
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_Tong);
            this.Controls.Add(this.btnKiemtra);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtBegin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtChitiet);
            this.Controls.Add(this.dtHoadon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(1200, 950);
            ((System.ComponentModel.ISupportInitialize)(this.dtHoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtChitiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtHoadon;
        private System.Windows.Forms.DataGridView dtChitiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Button btnKiemtra;
        private System.Windows.Forms.Label lb_Tong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
