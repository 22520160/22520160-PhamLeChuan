using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }
        private void tinh_Click(object sender, EventArgs e)
        {
            int A, B;
            int check1 = 0, check2 = 0;

            foreach (char c in a.Text)
            {
                if (c < '0' || c > '9')
                {
                    check1++;
                }
            }
            foreach (char c in b.Text)
            {
                if (c < '0' || c > '9')
                {
                    check2++;
                }
            }

            if (check1 != 0 || check2 != 0 || a.Text == null || b.Text == null || choose.Text == null)
            {
                MessageBox.Show(check1 != 0 || check2 != 0 ? "Vui lòng nhập số nguyên!" : "Vui lòng nhập lại!");
                a.Text = null;
                b.Text = null;
                choose.Text = null;
                return;
            }

            A = int.Parse(a.Text);
            B = int.Parse(b.Text);
            if (choose.Text == "Bảng Cửu Chương")
            {
                if (B < A)
                {
                    MessageBox.Show("A > B, Vui lòng nhập lại!");
                    a.Text = null;
                    b.Text = null;
                    choose.Text = null;
                    return;
                }
                int X = B - A;
                string kq = " ";
                for (int h = 1; h < 10; h++)
                {
                    kq += $"{X} x {h} = {X * h}{Environment.NewLine}   ";
                }
                this.s3.Text = kq.ToString();
                this.s.Text = null;
            }
            else if (choose.Text == "Tính Toán Giá Trị")
            {
                if (A < B)
                {
                    MessageBox.Show("A < B, Vui lòng nhập lại!");
                    a.Text = null;
                    b.Text = null;
                    choose.Text = null;
                    return;
                }
                int Y = A - B;
                long giaithua = 1, tong = 0;
                for (int k = 1; k <= Y; k++)
                {
                    giaithua *= k;
                }
                for (int l = 1; l <= B; l++)
                {
                    tong = tong + (long)Math.Pow(A, l);
                }
                this.s3.Text = "(A-B)!= " + giaithua.ToString();
                this.s.Text = "A^1 + A^2 + ... + A^B = " + tong.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập phương thức tính toán!");
            } 
                
        }




        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            a.Text = null;
            b.Text = null;
            s3.Text = null;
            s.Text = null;
            choose.Text = null;
        }
        private void a_TextChanged(object sender, EventArgs e)
        {

        }

        private void s3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
