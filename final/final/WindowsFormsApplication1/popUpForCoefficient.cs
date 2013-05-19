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
    public partial class popUpForCoefficient : Form
    {
        public popUpForCoefficient()
        {
            InitializeComponent();
            error_label.Visible = false;
        }

        public double dVal;
        public double d1Val;


        Form7 baseForm = new Form7();

        private void submit_Click(object sender, EventArgs e)
        {
            if (d.Text == "" && d1.Text == "")
            {
                error_label.Visible = true;
            }
            else
            {
                double.TryParse(d1.Text, out baseForm.dVal);
                double.TryParse(d.Text, out baseForm.d1Val);
                this.Close();
            }
        }

        private void popUpForCoefficient_Load(object sender, EventArgs e)
        {

        }
    }
}
