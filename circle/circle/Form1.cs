using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circle
{
    public partial class Form1 : Form
    {
        int count = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            C.cc = (int)numericUpDown1.Value;
            //C.cc = int.Parse(textBox1.Text);
            //textBox1.Text = "";
           
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            string j = "";
            string p = @"[A-Z][a-z]*";
            Regex regex2 = new Regex(p);
            Match match = regex2.Match(textBox2.Text);
            if (match.Success || textBox2.Text == null)
            {
                C.g.Add(count, textBox2.Text);
                count++;
                textBox2.Text = "";
            }
            else
                MessageBox.Show("Error");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string j = "";
            string p = @"[A-Z][a-z]*";
            Regex regex2 = new Regex(p);
            Match match = regex2.Match(textBox3.Text);
            if (match.Success || textBox3.Text == null)
            {
                C.start = textBox3.Text;
                textBox3.Enabled = false;
            }
            else
                MessageBox.Show("Error");
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Starp.Startpop();
            label1.Text = genetic.aaa;
            label6.Text = genetic.bbb;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Maps map = new Maps();
            map.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
