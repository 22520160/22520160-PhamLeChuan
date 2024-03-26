using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
        }
        private void tim_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ngay.Text, out int a))
            {
                MessageBox.Show("Vui lòng nhập lại!");
                return;
            }
            if (!int.TryParse(thang.Text, out int b))
            {
                MessageBox.Show("Vui lòng nhập lại!");
                return;
            }
            if (!int.TryParse(nam.Text, out int c))
            {
                MessageBox.Show("Vui lòng nhập lại!");
                return;
            }
            else
            {
                a = int.Parse(ngay.Text.Trim());
                b = int.Parse(thang.Text.Trim());
                c = int.Parse(nam.Text.Trim());
                if (b > 0 && b <= 12)
                {
                    if (b != 2)
                    {
                        if (b <= 7)
                        {
                            if (b % 2 != 0)
                            {
                                if (a > 31 || a < 1)
                                {
                                    MessageBox.Show("Vui lòng nhập lại!");
                                    return;
                                }
                            }
                            else
                            {
                                if (a > 31 || a < 1)
                                {
                                    MessageBox.Show("Vui lòng nhập lại!");
                                    return;
                                }
                            }
                        }
                        else
                        {
                            if (b % 2 == 0)
                            {
                                if (a > 31 || a < 1)
                                {
                                    MessageBox.Show("Vui lòng nhập lại!");
                                    return;
                                }
                            }
                            else
                            {
                                if (a > 31 || a < 1)
                                {
                                    MessageBox.Show("Vui lòng nhập lại!");
                                    return;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (c % 400 == 0 || (c % 100 != 0 && c % 4 == 0))
                        {
                            if (a > 29 || a < 1)
                            {
                                MessageBox.Show("Vui lòng nhập lại!");
                                return;
                            }
                        }
                        else
                        {
                            if (a > 28 || a < 1)
                            {
                                MessageBox.Show("Vui lòng nhập lại!");
                                return;
                            }
                        }
                    }
                }
                string result = "";

                switch (b)
                {
                    case 1:
                        if (a >= 20)
                        {
                            result = "Bảo Bình";
                        }
                        else
                        {
                            result = "Ma Kết";
                        }
                        break;

                    case 2:
                        if (a >= 19)
                        {
                            result = "Song Ngư";
                        }
                        else
                        {
                            result = "Bảo Bình";
                        }
                        break;

                    case 3:
                        if (a >= 21)
                        {
                            result = "Bạch Dương";
                        }
                        else
                        {
                            result = "Song Ngư";
                        }
                        break;

                    case 4:
                        if (a < 20)
                        {
                            result = "Bạch Dương";
                        }
                        else
                        {
                            result = "Kim Ngưu";
                        }
                        break;

                    case 5:
                        if (a >= 21)
                        {
                            result = "Song Tử";
                        }
                        else
                        {
                            result = "Kim Ngưu";
                        }
                        break;

                    case 6:
                        if (a < 21)
                        {
                            result = "Song Tử";
                        }
                        else
                        {
                            result = "Cự Giải";
                        }
                        break;

                    case 7:
                        if (a >= 23)
                        {
                            result = "Sư Tử";
                        }
                        else
                        {
                            result = "Cự Giải";
                        }
                        break;

                    case 8:
                        if (a < 23)
                        {
                            result = "Sư Tử";
                        }
                        else
                        {
                            result = "Xử Nữ";
                        }
                        break;

                    case 9:
                        if (a >= 23)
                        {
                            result = "Thiên Bình";
                        }
                        else
                        {
                            result = "Xử Nữ";
                        }
                        break;

                    case 10:
                        if (a < 23)
                        {
                            result = "Thiên Bình";
                        }
                        else
                        {
                            result = "Thiên Yết";
                        }
                        break;

                    case 11:
                        if (a >= 22)
                        {
                            result = "Nhân Mã";
                        }
                        else
                        {
                            result = "Thiên Yết";
                        }
                        break;

                    case 12:
                        if (a < 22)
                        {
                            result = "Nhân Mã";
                        }
                        else
                        {
                            result = "Ma Kết";
                        }
                        break;
                }
                this.zodiac.Text = result.ToString();
            }


        }
        private void Bai07_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            ngay.Text = null;
            thang.Text = null;
            nam.Text = null;
            zodiac.Text = null;
        }

        private void ngay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
