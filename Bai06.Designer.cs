namespace Lab01
{
    partial class Bai06
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
            label1 = new Label();
            a = new TextBox();
            tinh = new Button();
            choose = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            b = new TextBox();
            xoa = new Button();
            thoat = new Button();
            s3 = new TextBox();
            s = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 45);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập A";
            // 
            // a
            // 
            a.Location = new Point(106, 42);
            a.Name = "a";
            a.Size = new Size(125, 27);
            a.TabIndex = 1;
            a.TextChanged += a_TextChanged;
            // 
            // tinh
            // 
            tinh.Location = new Point(41, 204);
            tinh.Name = "tinh";
            tinh.Size = new Size(94, 29);
            tinh.TabIndex = 2;
            tinh.Text = "Tính";
            tinh.UseVisualStyleBackColor = true;
            tinh.Click += tinh_Click;
            // 
            // choose
            // 
            choose.FormattingEnabled = true;
            choose.Items.AddRange(new object[] { "Bảng Cửu Chương", "Tính Toán Giá Trị" });
            choose.Location = new Point(312, 108);
            choose.Name = "choose";
            choose.Size = new Size(151, 28);
            choose.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 45);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 4;
            label2.Text = "Nhập B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 294);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "Kết quả";
            // 
            // b
            // 
            b.Location = new Point(510, 42);
            b.Name = "b";
            b.Size = new Size(125, 27);
            b.TabIndex = 6;
            // 
            // xoa
            // 
            xoa.Location = new Point(334, 204);
            xoa.Name = "xoa";
            xoa.Size = new Size(94, 29);
            xoa.TabIndex = 7;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(656, 204);
            thoat.Name = "thoat";
            thoat.Size = new Size(94, 29);
            thoat.TabIndex = 8;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // s3
            // 
            s3.Location = new Point(12, 329);
            s3.Name = "s3";
            s3.ReadOnly = true;
            s3.Size = new Size(776, 27);
            s3.TabIndex = 9;
            s3.TextChanged += s3_TextChanged;
            // 
            // s
            // 
            s.Location = new Point(12, 381);
            s.Name = "s";
            s.ReadOnly = true;
            s.Size = new Size(776, 27);
            s.TabIndex = 10;
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(s);
            Controls.Add(s3);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(b);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(choose);
            Controls.Add(tinh);
            Controls.Add(a);
            Controls.Add(label1);
            Name = "Bai06";
            Text = "Bai06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox a;
        private Button tinh;
        private ComboBox choose;
        private Label label2;
        private Label label3;
        private TextBox b;
        private Button xoa;
        private Button thoat;
        private TextBox s3;
        private TextBox s;
    }
}