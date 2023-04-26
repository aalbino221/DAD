using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula4_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String texto = "";
            short serie = 0;

            if (radioButton1.Checked) texto += "Desenvolvimento de Sistema  - ";
            else if (radioButton2.Checked) texto += "Edificações - ";
            else if (radioButton3.Checked) texto += "Geodésia e Cartografia - ";

            if (radioButton6.Checked) serie = 1;
            else if (radioButton5.Checked) serie = 2;
            else if (radioButton4.Checked) serie = 3;

            if (texto.Equals("") || serie == 0) MessageBox.Show("Escolha um curso e uma série");
            else label1.Text = "Curso: " + texto + " - Série: " + serie + "º";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
        }
    }
}
