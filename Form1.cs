using System.Windows.Forms.VisualStyles;

namespace modul3_103022300100
{
    public partial class Form1 : Form
    {
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            String num1 = btn1.Text;
            textBox.Text += num1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            String num2 = btn2.Text;
            textBox.Text += num2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            String num3 = btn3.Text;
            textBox.Text += num3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            String num4 = btn4.Text;
            textBox.Text += num4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            String num5 = btn5.Text;
            textBox.Text += num5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            String num6 = btn6.Text;
            textBox.Text += num6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            String num7 = btn7.Text;
            textBox.Text += num7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            String num8 = btn8.Text;
            textBox.Text += num8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            String num9 = btn9.Text;
            textBox.Text += num9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            String num0 = btn0.Text;
            textBox.Text += num0;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Text = textBox.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String add = btnAdd.Text;
            a = int.Parse(textBox.Text);

            label.Visible = true;
            textBox.Text = "";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            b = int.Parse(textBox.Text);

            int hasil = a + b;
            String result = hasil.ToString();
            textBox.Text = result;
        }
    }
}
