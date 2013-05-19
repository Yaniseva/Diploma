using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public string profileType;
        public Form7()
        {
            InitializeComponent();
        }

        public double coefficient;
        public double diametr1, diametr2, hb1;
        public double G;
        public double strain;
        public int n;
        public double dlina;
        public double stiffness;
        public double area;
        public double deff;

        public void parse() {
            double.TryParse(a.Text, out area);
        }

        private void rbClick(object sender, EventArgs e)
        {
            switch (n)
            {
                
                case 2: //RoundRb
                    {
                        coefficient = 1;
                    }
                    break;

                case 1: //CircularRb
                    {
                        //double.TryParse(d1.Text, out diametr1);
                        //double.TryParse(d.Text, out diametr2);
                        //double.TryParse(Ccp.Text, out stiffness);
                        //double.TryParse(sn.Text, out deff);
                        //double sum = diametr1 + diametr2;
                        //coefficient = 1 + Math.Pow(sum, 2);
                        coefficient = 2;
                        dlina = (stiffness*Math.Pow(deff,2)*2*G);
                        //dlina = (stiffness * Math.Pow(deff, 2) * 2 * G) / (area * coefficient * strain);

                    }
                    break;

                

                case 3: //SquareRb
                    {
                        string hb1;
                        hb1 = hbBox.Text;
                        switch (hb1)
                        {
                            case "1":
                                coefficient = 0.618;
                                break;
                            case "1,5":
                                coefficient = 0.546;
                                break;
                            case "2":
                                coefficient = 0.529;
                                break;
                            case "3":
                                coefficient = 0.542;
                                break;
                            case "4":
                                coefficient = 0.567;
                                break;

                        }
                        
                    }

                    break;
            }

        }

        private void comboBox_Click(object sender, EventArgs e)
        {
            string text = comboBox1.SelectedItem.ToString();
            text = comboBox1.Text;

            if (String.IsNullOrEmpty(text))
            {
                return;
            }
            switch (text)
            {
                case "Сталь закаленная, обработанная дробью и предварительно обжатая":
                    G = 74000;
                    strain = 1050;
                    break;

                case "Сталь закаленная, обработанная дробью,без предварительно обжатая":
                    G = 78000;
                    strain = 807;
                    break;

                case "Сталь закаленная, без обработки дробью и слегка предварительно обжатая":
                    G = 78000;
                    strain = 800;
                    break;

            }

        }

        private void CircularRb_CheckedChanged(object sender, EventArgs e)
        {
            n = 1;
        }

        private void RoundRb_CheckedChanged(object sender, EventArgs e)
        {
            n = 2;
        }

        private void SquareRb_CheckedChanged(object sender, EventArgs e)
        {
            n = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res.Text = Convert.ToString(coefficient);
            GBox.Text = Convert.ToString(G);
            strainBox.Text = Convert.ToString(strain);
            L.Text = Convert.ToString(dlina);
        }

       }
}


    
