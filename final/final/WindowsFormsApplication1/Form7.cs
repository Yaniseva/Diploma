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
            clearFrom();
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
        public double dVal;
        public double d1Val;

        public void parse()
        {
            double.TryParse(a.Text, out area);
        }

        public void clearFrom()
        {
            // текстовое поле и label для d1  
            d1.Visible = false;
            d1_label.Visible = false;

            // текстовое поле и label для d
            d.Visible = false;
            d_label.Visible = false;

            // текстовое поле и label для hbBox
            comboBox2.Visible = false;
            hbBox_label.Visible = false;
        }

        public void showD1D()
        {
            // текстовое поле и label для d1  
            d1.Visible = true;
            d1_label.Visible = true;

            // текстовое поле и label для d
            d.Visible = true;
            d_label.Visible = true;
        }

        public void showHb()
        {
            // текстовое поле и label для hbBox
            comboBox2.Visible = true;
            //.Visible = true;
            hbBox_label.Visible = true;
        }

        private void rbClick(object sender, EventArgs e)
        {
            switch (n)
            {
                case 2: //RoundRb
                    {
                        clearFrom();
                        coefficient = 1;
                    }
                    break;
                case 1: //CircularRb
                    {
                        // очищаем форму
                        clearFrom();
                        // показываем то что нам надо
                        // showD1D();

                        popUpForCoefficient popUpForm = new popUpForCoefficient();
                        popUpForm.ShowDialog();


                        coefficient = 1 + (Math.Pow((d1Val/dVal), 2));

                        //if ((d1.Text != "") && (d.Text != ""))
                        //{
                        //    double.TryParse(d1.Text, out diametr1);
                        //    double.TryParse(d.Text, out diametr2);
                        //}

                        //double.TryParse(Ccp.Text, out stiffness);
                        //double.TryParse(sn.Text, out deff);
                        //coefficient = 2;
                        //dlina = (stiffness * Math.Pow(deff, 2) * 2 * G);
                    }
                    break;
                case 3: //SquareRb
                    {
                        // очищаем форму
                        clearFrom();
                        // показываем то что нам надо
                        showHb();
                        break;

                    }
            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            string tmp = comboBox2.SelectedItem.ToString();
            tmp = comboBox2.Text;
            if (String.IsNullOrEmpty(tmp))
            {
                MessageBox.Show("Error", "ВЫБЕРИ H/B!");
            }
            switch (tmp)
            {
                case "1":
                    coefficient = 0.658;
                    break;

                case "1.5":
                    coefficient = 0.852;
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



