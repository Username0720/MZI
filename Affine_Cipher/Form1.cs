using System;
using System.Windows.Forms;

namespace Affine_Cipher
{
    public partial class Form1 : Form
    {
        public int m = 26;
        public int a, b, func, count;
        public string text, result;
        public string alfabet = "abcdefghijklmnopqrstuvwxyz";
        public Form1()
        {
            InitializeComponent();
            label5.Text = "m=" + Convert.ToString(m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                text = textBox3.Text;
                int k = a;
                while ((k != 0) && (m != 0))
                {
                    if (k > m) k = k % m;
                    else m = m % k;
                }
                if ((m + k) != 1)
                    MessageBox.Show("a и m - числа не взаимно простые");
                else
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        count = alfabet.IndexOf(text[i]);
                        func = a * count + b;
                        if (func > 25) func %= 26;
                        result += alfabet[func];
                    }
                    textBox4.Text = result;
                }
            }
            catch (System.FormatException) { MessageBox.Show("Неверный формат данных!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            result = "";
        }
    }
}
