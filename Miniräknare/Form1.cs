using System.Numerics;

namespace Miniräknare
{
    public partial class Form1 : Form
    {
        double forsta_talet = 0;
        string raknesatt = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
            raknesatt = "+";
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
            raknesatt = "-";
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
            raknesatt = "*";
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
            raknesatt = "/";
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3,141";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
            forsta_talet = Math.Sqrt(forsta_talet);
            textBox1.Text = forsta_talet.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double summa = forsta_talet / 100 * Convert.ToDouble(textBox1.Text);
            if (raknesatt == "+")
            {
                textBox1.Text = (forsta_talet + summa).ToString();
            }
            if (raknesatt == "-")
            {
                textBox1.Text = (forsta_talet - summa).ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (raknesatt == "+")
                textBox1.Text = (forsta_talet + Convert.ToDouble(textBox1.Text)).ToString();
            if (raknesatt == "-")
            {
                textBox1.Text = (forsta_talet - Convert.ToDouble(textBox1.Text)).ToString();
            }
            if (raknesatt == "*")
            {
                textBox1.Text = (forsta_talet * Convert.ToDouble(textBox1.Text)).ToString();
            }
            if (raknesatt == "/")
            {
                textBox1.Text = (forsta_talet / Convert.ToDouble(textBox1.Text)).ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            forsta_talet = 0;
            textBox1.Text = "";
        }
        double minne = 0;
        private void button20_Click(object sender, EventArgs e)
        {
            minne = Convert.ToDouble(textBox1.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (minne != 0)
            { textBox1.Text = minne.ToString(); }
            else
            { textBox1.Text = ""; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            minne = 0;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            forsta_talet = Convert.ToDouble(textBox1.Text);
            forsta_talet = Math.Pow(forsta_talet, 2);
            textBox1.Text = forsta_talet.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}