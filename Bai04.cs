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
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }
        private void nhap_TextChanged(object sender, EventArgs e)
        {
        }
        public int CountNumber(int a)
        {
            string sochuso = a.ToString();
            return sochuso.Length;
        }
        public static int CountDigits(int number)
        {
            string numberString = number.ToString();
            return numberString.Length;
        }




        private void doc_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(nhap.Text, out int a))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return;
            }

            else
            {
                a = int.Parse(nhap.Text.Trim());
                if (a > 999999999 || a < 0)
                {
                    MessageBox.Show("Vui lòng nhập số có giá trị từ 0-999999!");
                    return;
                }
                List<string> donvi = new List<string> { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                List<string> chuc = new List<string> { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
                List<string> tram = new List<string> { "", "một trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };
                List<string> lonhon = new List<string> { "", "nghìn", "triệu", "tỷ" };

                int s1 = a / 1000; 
                int s2 = a % 1000; 

                string s = "";

                if (s1 > 0)
                {
                    int s1_tram = s1 / 100;
                    int s1_chuc = (s1 % 100) / 10;
                    int s1_donvi = s1 % 10;

                    if (s1_tram > 0)
                        s += tram[s1_tram] + " trăm ";
                    if (s1_chuc > 0)
                        s += chuc[s1_chuc] + " ";
                    if (s1_donvi > 0)
                        s += donvi[s1_donvi] + " ";
                    s += lonhon[1] + ", ";
                }

                int s2_tram = s2 / 100;
                int s2_chuc = (s2 % 100) / 10;
                int s2_donvi = s2 % 10;

                if (s2_tram > 0)
                    s += tram[s2_tram] + " trăm ";
                if (s2_chuc > 0)
                    s += chuc[s2_chuc] + " ";
                if (s2_donvi > 0)
                    s += donvi[s2_donvi] + " ";

                ketqua.Text = s.Trim();
            }
        }


        private void xoa_Click_1(object sender, EventArgs e)
        {
            nhap.Text = null;
            ketqua.Text = null;
        }

        private void thoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
