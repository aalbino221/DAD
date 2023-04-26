using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioExtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String valor1 = (textBox2.Text).Replace(".", ",");
            String valor2 = (textBox3.Text).Replace(".", ",");
            double total = double.Parse(valor1) * double.Parse(valor2);
            String text = textBox1.Text;
            listBox1.Items.Add(text + " - " + total.ToString());
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calcula();
            MessageBox.Show("Compra efetuada com sucesso", "Finalização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            calcula();
        }

        private void calcula()
        {
            float total = 0;
            foreach (String listItem in listBox1.Items)
            {
                String current = listItem.Substring(listItem.LastIndexOf('-') + 1);
                float number = float.Parse(current);
                total += number;
            }
            label5.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            calcula();
        }
    }
}
