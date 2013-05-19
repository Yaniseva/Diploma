using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class popUpForCoefficient : Form
    {
        public Form7 _form;

        public popUpForCoefficient(Form7 form)
        {
            InitializeComponent();
            error_label.Visible = false;
            _form = form;
        }

        
        Form7 baseForm = new Form7();

        private void submit_Click(object sender, EventArgs e)
        {
            if (d.Text == "" && d1.Text == "")
            {
                error_label.Visible = true;
            }
            else
            {
                
                double.TryParse(d1.Text, out _form.dVal);
                double.TryParse(d.Text, out _form.d1Val);
                this.Close();
            }
        }

        private void popUpForCoefficient_Load(object sender, EventArgs e)
        {

        }
    }
}
