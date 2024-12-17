using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_6
{
    public partial class Form4 : Form
    {
        bool operand1 = true;
        bool operand2 = true;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            operand1 = radioButton1.Checked;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            operand2 = radioButton3.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = $"{operand1 && operand2}";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
