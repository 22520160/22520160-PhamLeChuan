namespace Lab01
{
    partial class Bai01
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Tinhtong2songuyen = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            so2 = new TextBox();
            so1 = new TextBox();
            kq = new TextBox();
            button1 = new Button();
            xoa = new Button();
            thoat = new Button();
            SuspendLayout();
            // 
            // Tinhtong2songuyen
            // 
            Tinhtong2songuyen.Location = new Point(258, 85);
            Tinhtong2songuyen.Name = "Tinhtong2songuyen";
            Tinhtong2songuyen.Size = new Size(187, 23);
            Tinhtong2songuyen.TabIndex = 0;
            Tinhtong2songuyen.Text = "TÍNH TỔNG 2 SỐ NGUYÊN";
            Tinhtong2songuyen.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 158);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ nhất";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 220);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Số thứ hai";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 319);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "TỔNG";
            // 
            // so2
            // 
            so2.Location = new Point(347, 217);
            so2.Name = "so2";
            so2.Size = new Size(125, 27);
            so2.TabIndex = 4;
            // 
            // so1
            // 
            so1.Location = new Point(347, 158);
            so1.Name = "so1";
            so1.Size = new Size(125, 27);
            so1.TabIndex = 5;
            so1.TextChanged += txtSothu1_TextChanged;
            // 
            // kq
            // 
            kq.Location = new Point(347, 316);
            kq.Name = "kq";
            kq.ReadOnly = true;
            kq.Size = new Size(125, 27);
            kq.TabIndex = 6;
            kq.TextChanged += txtKq_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(245, 260);
            button1.Name = "button1";
            button1.Size = new Size(227, 32);
            button1.TabIndex = 7;
            button1.Text = "TÍNH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // xoa
            // 
            xoa.Location = new Point(164, 370);
            xoa.Name = "xoa";
            xoa.Size = new Size(81, 32);
            xoa.TabIndex = 8;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(469, 370);
            thoat.Name = "thoat";
            thoat.Size = new Size(81, 32);
            thoat.TabIndex = 9;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(button1);
            Controls.Add(kq);
            Controls.Add(so1);
            Controls.Add(so2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Tinhtong2songuyen);
            Name = "Bai01";
            Text = "Bai01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tinhtong2songuyen;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox so2;
        private TextBox so1;
        private TextBox kq;
        private Button button1;
        
        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            num1 = Int32.Parse(so2.Text.Trim());
            num2 = Int32.Parse(so1.Text.Trim());
            sum = num1 + num2;
            kq.Text = sum.ToString();

        }

        private Button xoa;
        private Button thoat;
    }

}
