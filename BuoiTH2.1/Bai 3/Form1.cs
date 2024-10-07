using System.Diagnostics.Eventing.Reader;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int result;
            if (x >= 2)
            {
                result = -8 * x * x * x - 12 * x - 1;
            }
            else if (1 < x && x < 2)
            {
                result = x * x - 6 * x - 10;
            }
            else
            {
                result = 7 * x;
            }
            textBox2.Text = result.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textBox3.Text);

            if (month >= 1 && month <= 3)
            {
                MessageBox.Show("Mùa xuân");
            }
            else if (month >= 4 && month <= 6)
            {
                MessageBox.Show("Mùa hạ");
            }
            else if (month >= 7 && month <= 9)
            {
                MessageBox.Show("Mùa thu");
            }
            else if (month >= 10 && month <= 12)
            {
                MessageBox.Show("Mùa đông");
            }
            else
            {
                MessageBox.Show("Tháng không hợp lệ");
            }
        }
    }
}
