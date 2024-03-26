namespace Lab01
{
    partial class Bai08
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
            tinh = new Button();
            xoa = new Button();
            thoat = new Button();
            hoten = new TextBox();
            dau = new TextBox();
            diem = new TextBox();
            nhap = new TextBox();
            max = new TextBox();
            rot = new TextBox();
            xeploai = new TextBox();
            tbm = new TextBox();
            min = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // tinh
            // 
            tinh.Location = new Point(49, 172);
            tinh.Name = "tinh";
            tinh.Size = new Size(94, 29);
            tinh.TabIndex = 0;
            tinh.Text = "Tính";
            tinh.UseVisualStyleBackColor = true;
            tinh.Click += tinh_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(435, 172);
            xoa.Name = "xoa";
            xoa.Size = new Size(94, 29);
            xoa.TabIndex = 1;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(796, 172);
            thoat.Name = "thoat";
            thoat.Size = new Size(94, 29);
            thoat.TabIndex = 2;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // hoten
            // 
            hoten.Location = new Point(49, 224);
            hoten.Name = "hoten";
            hoten.ReadOnly = true;
            hoten.Size = new Size(137, 27);
            hoten.TabIndex = 3;
            // 
            // dau
            // 
            dau.Location = new Point(810, 323);
            dau.Name = "dau";
            dau.ReadOnly = true;
            dau.Size = new Size(125, 27);
            dau.TabIndex = 4;
            // 
            // diem
            // 
            diem.Location = new Point(49, 271);
            diem.Name = "diem";
            diem.ReadOnly = true;
            diem.Size = new Size(886, 27);
            diem.TabIndex = 5;
            // 
            // nhap
            // 
            nhap.Location = new Point(193, 15);
            nhap.Name = "nhap";
            nhap.Size = new Size(411, 27);
            nhap.TabIndex = 6;
            // 
            // max
            // 
            max.Location = new Point(419, 323);
            max.Name = "max";
            max.ReadOnly = true;
            max.Size = new Size(125, 27);
            max.TabIndex = 7;
            // 
            // rot
            // 
            rot.Location = new Point(810, 361);
            rot.Name = "rot";
            rot.ReadOnly = true;
            rot.Size = new Size(125, 27);
            rot.TabIndex = 8;
            // 
            // xeploai
            // 
            xeploai.Location = new Point(288, 408);
            xeploai.Name = "xeploai";
            xeploai.ReadOnly = true;
            xeploai.Size = new Size(156, 27);
            xeploai.TabIndex = 9;
            // 
            // tbm
            // 
            tbm.Location = new Point(49, 323);
            tbm.Name = "tbm";
            tbm.ReadOnly = true;
            tbm.Size = new Size(125, 27);
            tbm.TabIndex = 10;
            // 
            // min
            // 
            min.Location = new Point(419, 361);
            min.Name = "min";
            min.ReadOnly = true;
            min.Size = new Size(125, 27);
            min.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 18);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 12;
            label1.Text = "Nhập thông tin";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-6, 227);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 13;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 411);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 14;
            label3.Text = "Xếp loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(772, 364);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 15;
            label4.Text = "Rớt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(768, 326);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 16;
            label5.Text = "Đậu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 326);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 17;
            label6.Text = "Cao nhất";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 274);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 18;
            label7.Text = "Điểm";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(338, 364);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 19;
            label8.Text = "Thấp nhất";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 326);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 20;
            label9.Text = "TBM";
            // 
            // Bai08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(min);
            Controls.Add(tbm);
            Controls.Add(xeploai);
            Controls.Add(rot);
            Controls.Add(max);
            Controls.Add(nhap);
            Controls.Add(diem);
            Controls.Add(dau);
            Controls.Add(hoten);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(tinh);
            Name = "Bai08";
            Text = "Bai08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tinh;
        private Button xoa;
        private Button thoat;
        private TextBox hoten;
        private TextBox dau;
        private TextBox diem;
        private TextBox nhap;
        private TextBox max;
        private TextBox rot;
        private TextBox xeploai;
        private TextBox tbm;
        private TextBox min;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}