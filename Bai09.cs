using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Bai09 : Form
    {
        public Bai09()
        {
            InitializeComponent();
        }

        private void them_Click(object sender, EventArgs e)
        {
            string newText = monan.Text;
            ListViewItem newItem = new ListViewItem(new string[] { newText });
            if (!string.IsNullOrEmpty(newText))
            {
                listView1.Items.Add(newItem);
                monan.Text = null;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một món ăn vào danh sách!");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chon_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, listView1.Items.Count);
                ListViewItem selectedItem = listView1.Items[randomIndex];
                kq.Text = selectedItem.SubItems[0].Text;
            }
            else
            {
                MessageBox.Show("Vui lòng thêm ít nhất một món ăn vào danh sách!");
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            kq.Text = null;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
