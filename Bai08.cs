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
    public partial class Bai08 : Form
    {
        public Bai08()
        {
            InitializeComponent();
        }
      

        private void tinh_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.AddRange(nhap.Text.Split(','));

            if (list.Count < 2)
            {
                MessageBox.Show("Dữ liệu không đúng format, vui lòng nhập lại!");
                return;
            }
            for (int i = 1; i < list.Count; i++)
            {
                if (!double.TryParse(list[i], out double a))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng [TÊN,điểm,điểm,điểm..]");
                    return;
                }
                if (a < 0 || a > 10)
                {
                    MessageBox.Show("Điểm không hợp lệ, vui lòng nhập lại!");
                    return;
                }

            }
            double maxdiem = 0;
            double mindiem = 10;
            int rotne = 0;
            int daune = 0;

            diem.Text = null;
            double tbm_ = 0;
            tbm.Text = null;
            for (int i = 1; i < list.Count; i++)
            {
                diem.Text += "Môn " + i + ": " + list[i] + " ";
                tbm_ += double.Parse(list[i]);
                if (double.Parse(list[i]) >= maxdiem)
                    maxdiem = double.Parse(list[i]);
                if (double.Parse(list[i]) <= mindiem)
                    mindiem = double.Parse(list[i]);
                if (double.Parse(list[i]) >= 5)
                    daune += 1;
                else rotne += 1;

            }
            hoten.Text = list[0];
            double tbm__ = (tbm_ / (list.Count - 1));
            tbm.Text = Math.Round(tbm__, 2).ToString();
            min.Text = mindiem.ToString();
            max.Text = maxdiem.ToString();
            dau.Text = daune.ToString();
            rot.Text = rotne.ToString();
            if (mindiem >= 6.5 && double.Parse(tbm.Text) >= 8)
            {
                xeploai.Text = "Giỏi";
            }
            else if (mindiem < 6.5 && mindiem > 5 && double.Parse(tbm.Text) >= 8)
            {
                xeploai.Text = "Khá";
            }
            else if (mindiem >= 5 && double.Parse(tbm.Text) >= 6.5 && double.Parse(tbm.Text) < 8)
            {
                xeploai.Text = "Khá";
            }
            else if (mindiem < 5 && mindiem > 3.5 && double.Parse(tbm.Text) >= 6.5 && double.Parse(tbm.Text) < 8)
            {
                xeploai.Text = "Trung Bình";
            }
            else if (mindiem >= 3.5 && double.Parse(tbm.Text) >= 5 && double.Parse(tbm.Text) < 6.5)
            {
                xeploai.Text = "Trung Bình";
            }
            else if (mindiem < 3.5 && mindiem > 2 && double.Parse(tbm.Text) >= 5 && double.Parse(tbm.Text) < 6.5)
            {
                xeploai.Text = "Yếu";
            }
            else if (mindiem >= 2 && double.Parse(tbm.Text) >= 3.5 && double.Parse(tbm.Text) < 5)
            {
                xeploai.Text = "Yếu";
            }
            else if (mindiem < 2 && double.Parse(tbm.Text) >= 3.5 && double.Parse(tbm.Text) < 5)
            {
                xeploai.Text = "Kém";
            }
            else xeploai.Text = "Kém";
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            nhap.Text = diem.Text = hoten.Text = tbm.Text = min.Text = max.Text = dau.Text = rot.Text = xeploai.Text = null;
        }
        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void nhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
