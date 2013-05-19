using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        Form2 mach = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            
            mach.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Form3 diagn = new Form3();
        private void button2_Click(object sender, EventArgs e)
        {
            diagn.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 p = new Form7();
            p.ShowDialog();
        }

          }
}
