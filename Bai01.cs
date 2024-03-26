namespace Lab01
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(this.so1.Text, out int a))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return;
            }
            if (!int.TryParse(this.so2.Text, out int b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return;
            }
            int so1 = Convert.ToInt32(this.so1.Text);
            int so2 = Convert.ToInt32(this.so2.Text);
            int kq = so1 + so2;
            this.kq.Text = kq.ToString();
        }
        private void xoa_Click(object sender, EventArgs e)
        {
            so1.Text = null;
            so2.Text = null;
            kq.Text = null;
        }
        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtSothu1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
