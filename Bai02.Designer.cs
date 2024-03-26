namespace Lab01
{
    partial class Bai02
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tim = new Button();
            xoa = new Button();
            thoat = new Button();
            so1 = new TextBox();
            so2 = new TextBox();
            so3 = new TextBox();
            max = new TextBox();
            min = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 83);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Số thứ 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(535, 79);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ 3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 83);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Số thứ 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 313);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "Số nhỏ nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 313);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 4;
            label5.Text = "Số lớn nhất";
            label5.Click += label5_Click;
            // 
            // tim
            // 
            tim.Location = new Point(100, 200);
            tim.Name = "tim";
            tim.Size = new Size(94, 29);
            tim.TabIndex = 5;
            tim.Text = "Tìm";
            tim.UseVisualStyleBackColor = true;
            tim.Click += tim_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(341, 200);
            xoa.Name = "xoa";
            xoa.Size = new Size(94, 29);
            xoa.TabIndex = 6;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(562, 200);
            thoat.Name = "thoat";
            thoat.Size = new Size(94, 29);
            thoat.TabIndex = 7;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // so1
            // 
            so1.Location = new Point(108, 79);
            so1.Name = "so1";
            so1.Size = new Size(125, 27);
            so1.TabIndex = 8;
            // 
            // so2
            // 
            so2.Location = new Point(351, 79);
            so2.Name = "so2";
            so2.Size = new Size(125, 27);
            so2.TabIndex = 9;
            // 
            // so3
            // 
            so3.Location = new Point(612, 80);
            so3.Name = "so3";
            so3.Size = new Size(125, 27);
            so3.TabIndex = 10;
            // 
            // max
            // 
            max.Location = new Point(128, 310);
            max.Name = "max";
            max.ReadOnly = true;
            max.Size = new Size(125, 27);
            max.TabIndex = 11;
            max.TextAlign = HorizontalAlignment.Center;
            max.TextChanged += max_TextChanged;
            // 
            // min
            // 
            min.Location = new Point(531, 310);
            min.Name = "min";
            min.ReadOnly = true;
            min.Size = new Size(125, 27);
            min.TabIndex = 12;
            min.TextAlign = HorizontalAlignment.Center;
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(min);
            Controls.Add(max);
            Controls.Add(so3);
            Controls.Add(so2);
            Controls.Add(so1);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(tim);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai02";
            Text = "Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button tim;
        private Button xoa;
        private Button thoat;
        private TextBox so1;
        private TextBox so2;
        private TextBox so3;
        private TextBox max;
        private TextBox min;
    }
}