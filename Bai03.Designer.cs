namespace Lab01
{
    partial class Bai03
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
            doc = new Button();
            xoa = new Button();
            thoat = new Button();
            nhap = new TextBox();
            ketqua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(192, 83);
            label1.Name = "label1";
            label1.Size = new Size(223, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào số nguyên từ 0 đến 9";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 292);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Kết quả";
            // 
            // doc
            // 
            doc.Location = new Point(634, 79);
            doc.Name = "doc";
            doc.Size = new Size(94, 29);
            doc.TabIndex = 2;
            doc.Text = "Đọc";
            doc.UseVisualStyleBackColor = true;
            doc.Click += doc_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(634, 212);
            xoa.Name = "xoa";
            xoa.Size = new Size(94, 29);
            xoa.TabIndex = 3;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(634, 338);
            thoat.Name = "thoat";
            thoat.Size = new Size(94, 31);
            thoat.TabIndex = 4;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // nhap
            // 
            nhap.Location = new Point(430, 81);
            nhap.Name = "nhap";
            nhap.Size = new Size(125, 27);
            nhap.TabIndex = 5;
            nhap.TextChanged += nhap_TextChanged;
            // 
            // ketqua
            // 
            ketqua.Location = new Point(290, 289);
            ketqua.Name = "ketqua";
            ketqua.ReadOnly = true;
            ketqua.Size = new Size(125, 27);
            ketqua.TabIndex = 6;
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ketqua);
            Controls.Add(nhap);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(doc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai03";
            Text = "Bai03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button doc;
        private Button xoa;
        private Button thoat;
        private TextBox nhap;
        private TextBox ketqua;
    }
}