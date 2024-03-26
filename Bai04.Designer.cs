namespace Lab01
{
    partial class Bai04
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
            nhap = new TextBox();
            ketqua = new TextBox();
            doc = new Button();
            xoa = new Button();
            thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(34, 68);
            label1.Name = "label1";
            label1.Size = new Size(242, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào số nguyên có 6 chữ số ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 234);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Kết Quả";
            // 
            // nhap
            // 
            nhap.Location = new Point(282, 66);
            nhap.Name = "nhap";
            nhap.Size = new Size(213, 27);
            nhap.TabIndex = 2;
            nhap.TextChanged += nhap_TextChanged;
            // 
            // ketqua
            // 
            ketqua.Location = new Point(12, 257);
            ketqua.Name = "ketqua";
            ketqua.ReadOnly = true;
            ketqua.Size = new Size(468, 27);
            ketqua.TabIndex = 3;
            // 
            // doc
            // 
            doc.Location = new Point(666, 66);
            doc.Name = "doc";
            doc.Size = new Size(94, 29);
            doc.TabIndex = 4;
            doc.Text = "Đọc";
            doc.UseVisualStyleBackColor = true;
            doc.Click += doc_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(666, 144);
            xoa.Name = "xoa";
            xoa.Size = new Size(94, 29);
            xoa.TabIndex = 5;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click_1;
            // 
            // thoat
            // 
            thoat.Location = new Point(666, 216);
            thoat.Name = "thoat";
            thoat.Size = new Size(94, 29);
            thoat.TabIndex = 6;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click_1;
            // 
            // Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(doc);
            Controls.Add(ketqua);
            Controls.Add(nhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai04";
            Text = "Bai04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nhap;
        private TextBox ketqua;
        private Button doc;
        private Button xoa;
        private Button thoat;
    }
}