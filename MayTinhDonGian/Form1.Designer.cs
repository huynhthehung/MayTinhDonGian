namespace MayTinhDonGian
{
    partial class frmMayTinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoThu1 = new System.Windows.Forms.TextBox();
            this.txtSoThu2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChia = new System.Windows.Forms.RadioButton();
            this.btnNhan = new System.Windows.Forms.RadioButton();
            this.btnTru = new System.Windows.Forms.RadioButton();
            this.btnCong = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai";
            // 
            // txtSoThu1
            // 
            this.txtSoThu1.Location = new System.Drawing.Point(148, 40);
            this.txtSoThu1.Name = "txtSoThu1";
            this.txtSoThu1.Size = new System.Drawing.Size(100, 20);
            this.txtSoThu1.TabIndex = 2;
            // 
            // txtSoThu2
            // 
            this.txtSoThu2.Location = new System.Drawing.Point(148, 70);
            this.txtSoThu2.Name = "txtSoThu2";
            this.txtSoThu2.Size = new System.Drawing.Size(100, 20);
            this.txtSoThu2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(148, 100);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(100, 20);
            this.txtKetQua.TabIndex = 5;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(58, 156);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 6;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(160, 156);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChia);
            this.groupBox1.Controls.Add(this.btnNhan);
            this.groupBox1.Controls.Add(this.btnTru);
            this.groupBox1.Controls.Add(this.btnCong);
            this.groupBox1.Location = new System.Drawing.Point(273, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 148);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép toán";
            // 
            // btnChia
            // 
            this.btnChia.AutoSize = true;
            this.btnChia.Location = new System.Drawing.Point(8, 100);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(46, 17);
            this.btnChia.TabIndex = 3;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            this.btnNhan.AutoSize = true;
            this.btnNhan.Location = new System.Drawing.Point(8, 75);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(51, 17);
            this.btnNhan.TabIndex = 2;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnTru
            // 
            this.btnTru.AutoSize = true;
            this.btnTru.Location = new System.Drawing.Point(8, 50);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(41, 17);
            this.btnTru.TabIndex = 1;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            // 
            // btnCong
            // 
            this.btnCong.AutoSize = true;
            this.btnCong.Checked = true;
            this.btnCong.Location = new System.Drawing.Point(8, 25);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(50, 17);
            this.btnCong.TabIndex = 0;
            this.btnCong.TabStop = true;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            // 
            // frmMayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoThu2);
            this.Controls.Add(this.txtSoThu1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMayTinh";
            this.Text = "Máy tính đơn giản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoThu1;
        private System.Windows.Forms.TextBox txtSoThu2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnChia;
        private System.Windows.Forms.RadioButton btnNhan;
        private System.Windows.Forms.RadioButton btnTru;
        private System.Windows.Forms.RadioButton btnCong;
    }
}

