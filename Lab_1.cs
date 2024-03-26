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
    public partial class Lab_1 : Form
    {
        public Lab_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bai1_Click(object sender, EventArgs e)
        {
            Bai01 f = new Bai01();
            f.Show();
        }

        private void bai2_Click(object sender, EventArgs e)
        {
            Bai02 f = new Bai02();
            f.Show();
        }

        private void bai3_Click(object sender, EventArgs e)
        {
            Bai03 f = new Bai03();
            f.Show();
        }
        private void bai4_Click(object sender, EventArgs e)
        {
            Bai04 f = new Bai04();
            f.Show();
        }
        private void bai6_Click(object sender, EventArgs e)
        {
            Bai06 f = new Bai06();
            f.Show();
        }
        private void bai7_Click(object sender, EventArgs e)
        {
            Bai07 f = new Bai07();
            f.Show();
        }

        private void bai8_Click(object sender, EventArgs e)
        {
            Bai08 f = new Bai08();
            f.Show();
        }

        private void bai9_Click(object sender, EventArgs e)
        {
            Bai09 f = new Bai09();
            f.Show();
        }
    }
}
