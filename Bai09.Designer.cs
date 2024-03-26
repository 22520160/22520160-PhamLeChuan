namespace Lab01
{
    partial class Bai09
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
            monan = new TextBox();
            them = new Button();
            label2 = new Label();
            kq = new TextBox();
            chon = new Button();
            xoa = new Button();
            thoat = new Button();
            listView1 = new ListView();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 88);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập món ăn";
            label1.Click += label1_Click;
            // 
            // monan
            // 
            monan.Location = new Point(191, 85);
            monan.Name = "monan";
            monan.Size = new Size(125, 27);
            monan.TabIndex = 1;
            monan.TextAlign = HorizontalAlignment.Center;
            // 
            // them
            // 
            them.Location = new Point(222, 132);
            them.Name = "them";
            them.Size = new Size(94, 29);
            them.TabIndex = 2;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 341);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 3;
            label2.Text = "Món ăn hôm nay là:";
            // 
            // kq
            // 
            kq.Location = new Point(209, 364);
            kq.Name = "kq";
            kq.ReadOnly = true;
            kq.Size = new Size(320, 27);
            kq.TabIndex = 4;
            kq.TextAlign = HorizontalAlignment.Center;
            kq.TextChanged += kq_TextChanged;
            // 
            // chon
            // 
            chon.Location = new Point(91, 266);
            chon.Name = "chon";
            chon.Size = new Size(94, 29);
            chon.TabIndex = 5;
            chon.Text = "Chọn món ăn";
            chon.UseVisualStyleBackColor = true;
            chon.Click += chon_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(330, 266);
            xoa.Name = "xoa";
            xoa.Size = new Size(94, 29);
            xoa.TabIndex = 6;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(600, 266);
            thoat.Name = "thoat";
            thoat.Size = new Size(94, 29);
            thoat.TabIndex = 7;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(476, 71);
            listView1.Name = "listView1";
            listView1.Size = new Size(258, 174);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(240, 9);
            label3.Name = "label3";
            label3.Size = new Size(289, 44);
            label3.TabIndex = 9;
            label3.Text = "Hôm nay ăn gì ?";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Bai09
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(chon);
            Controls.Add(kq);
            Controls.Add(label2);
            Controls.Add(them);
            Controls.Add(monan);
            Controls.Add(label1);
            Name = "Bai09";
            Text = "Bai09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox monan;
        private Button them;
        private Label label2;
        private TextBox kq;
        private Button chon;
        private Button xoa;
        private Button thoat;
        private ListView listView1;
        private Label label3;
    }
}