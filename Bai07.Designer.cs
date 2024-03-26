namespace Lab01
{
    partial class Bai07
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
            ngay = new TextBox();
            thang = new TextBox();
            nam = new TextBox();
            zodiac = new TextBox();
            tim = new Button();
            xoa = new Button();
            thoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // ngay
            // 
            ngay.Location = new Point(62, 96);
            ngay.Name = "ngay";
            ngay.Size = new Size(125, 27);
            ngay.TabIndex = 0;
            ngay.TextChanged += ngay_TextChanged;
            // 
            // thang
            // 
            thang.Location = new Point(303, 96);
            thang.Name = "thang";
            thang.Size = new Size(125, 27);
            thang.TabIndex = 1;
            // 
            // nam
            // 
            nam.Location = new Point(573, 96);
            nam.Name = "nam";
            nam.Size = new Size(125, 27);
            nam.TabIndex = 2;
            // 
            // zodiac
            // 
            zodiac.Location = new Point(166, 349);
            zodiac.Name = "zodiac";
            zodiac.Size = new Size(138, 27);
            zodiac.TabIndex = 3;
            // 
            // tim
            // 
            tim.Location = new Point(62, 200);
            tim.Name = "tim";
            tim.Size = new Size(94, 29);
            tim.TabIndex = 4;
            tim.Text = "Tìm";
            tim.UseVisualStyleBackColor = true;
            tim.Click += tim_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(303, 200);
            xoa.Name = "xoa";
            xoa.Size = new Size(94, 29);
            xoa.TabIndex = 5;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(582, 200);
            thoat.Name = "thoat";
            thoat.Size = new Size(94, 29);
            thoat.TabIndex = 6;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 99);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 7;
            label1.Text = "Ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 99);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "Tháng";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(526, 99);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 9;
            label3.Text = "Năm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 352);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 10;
            label4.Text = "Cung hoàng đạo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 29);
            label5.Name = "label5";
            label5.Size = new Size(184, 28);
            label5.TabIndex = 11;
            label5.Text = "Thông tin ngày sinh";
            // 
            // Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(tim);
            Controls.Add(zodiac);
            Controls.Add(nam);
            Controls.Add(thang);
            Controls.Add(ngay);
            Name = "Bai07";
            Text = "Bai07";
            Load += Bai07_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ngay;
        private TextBox thang;
        private TextBox nam;
        private TextBox zodiac;
        private Button tim;
        private Button xoa;
        private Button thoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}