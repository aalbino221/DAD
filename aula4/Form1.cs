using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Comic Sans MS", 16, FontStyle.Bold);
            label1.Text = textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = "";
            if (checkBox1.Checked) text += checkBox1.Text + " - ";
            if (checkBox2.Checked) text += checkBox2.Text + " - ";
            if (checkBox3.Checked) text += checkBox3.Text + " - ";
            if (checkBox4.Checked) text += checkBox4.Text + " - ";
            text = text.Remove(text.Length - 2);
            label4.Text = text;
        }
    }
}
