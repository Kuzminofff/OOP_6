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
    public partial class Form2 : Form
        
    {
        bool operand1 = true;
        bool operand2 = true;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Промахнулся");
            }
            
        }
        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink2();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Попал");
            }
        }
        private void VisitLink2()
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://learn.microsoft.com/ru-ru/dotnet/desktop/winforms/controls/link-to-an-object-or-web-page-with-wf-linklabel-control?view=netframeworkdesktop-4.8");
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            operand1 = radioButton1.Checked;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            operand2 = radioButton3.Checked;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (operand1 == true)
            {
                Console.WriteLine("1) wew");
            }
            else
            {
                Console.WriteLine("1) 123");
            }
            if (operand2 == true)
            {
                Console.WriteLine("2) wew" + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("2) 123" + Environment.NewLine);
            }
        }
        
    }
}