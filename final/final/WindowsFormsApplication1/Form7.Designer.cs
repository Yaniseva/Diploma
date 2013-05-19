namespace WindowsFormsApplication1
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.d1_label = new System.Windows.Forms.Label();
            this.d_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.TextBox();
            this.CircularRb = new System.Windows.Forms.RadioButton();
            this.RoundRb = new System.Windows.Forms.RadioButton();
            this.SquareRb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hbBox_label = new System.Windows.Forms.Label();
            this.VidStali = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.strainBox = new System.Windows.Forms.TextBox();
            this.strait = new System.Windows.Forms.Label();
            this.Ccp = new System.Windows.Forms.TextBox();
            this.sn = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dlinaShlic = new System.Windows.Forms.TextBox();
            this.labelS = new System.Windows.Forms.Label();
            this.diamSh = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // d1_label
            // 
            this.d1_label.AutoSize = true;
            this.d1_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d1_label.Location = new System.Drawing.Point(269, 183);
            this.d1_label.Name = "d1_label";
            this.d1_label.Size = new System.Drawing.Size(32, 15);
            this.d1_label.TabIndex = 30;
            this.d1_label.Text = "d1 = ";
            // 
            // d_label
            // 
            this.d_label.AutoSize = true;
            this.d_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_label.Location = new System.Drawing.Point(269, 156);
            this.d_label.Name = "d_label";
            this.d_label.Size = new System.Drawing.Size(26, 15);
            this.d_label.TabIndex = 29;
            this.d_label.Text = "d = ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(458, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(727, 177);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(100, 20);
            this.res.TabIndex = 9;
            // 
            // CircularRb
            // 
            this.CircularRb.AutoSize = true;
            this.CircularRb.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CircularRb.Location = new System.Drawing.Point(6, 99);
            this.CircularRb.Name = "CircularRb";
            this.CircularRb.Size = new System.Drawing.Size(80, 19);
            this.CircularRb.TabIndex = 0;
            this.CircularRb.Text = "Кольцевой";
            this.CircularRb.UseVisualStyleBackColor = true;
            this.CircularRb.CheckedChanged += new System.EventHandler(this.CircularRb_CheckedChanged);
            this.CircularRb.Click += new System.EventHandler(this.rbClick);
            // 
            // RoundRb
            // 
            this.RoundRb.AutoSize = true;
            this.RoundRb.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoundRb.Location = new System.Drawing.Point(4, 33);
            this.RoundRb.Name = "RoundRb";
            this.RoundRb.Size = new System.Drawing.Size(72, 19);
            this.RoundRb.TabIndex = 1;
            this.RoundRb.Text = "Круглый";
            this.RoundRb.UseVisualStyleBackColor = true;
            this.RoundRb.CheckedChanged += new System.EventHandler(this.RoundRb_CheckedChanged);
            this.RoundRb.Click += new System.EventHandler(this.rbClick);
            // 
            // SquareRb
            // 
            this.SquareRb.AutoSize = true;
            this.SquareRb.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SquareRb.Location = new System.Drawing.Point(6, 174);
            this.SquareRb.Name = "SquareRb";
            this.SquareRb.Size = new System.Drawing.Size(110, 19);
            this.SquareRb.TabIndex = 2;
            this.SquareRb.Text = "Прямоугольный";
            this.SquareRb.UseVisualStyleBackColor = true;
            this.SquareRb.CheckedChanged += new System.EventHandler(this.SquareRb_CheckedChanged);
            this.SquareRb.Click += new System.EventHandler(this.rbClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SquareRb);
            this.groupBox1.Controls.Add(this.RoundRb);
            this.groupBox1.Controls.Add(this.CircularRb);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(31, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 216);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Профиль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Сталь закаленная, обработанная дробью и предварительно обжатая",
            "Сталь закаленная, обработанная дробью,без предварительно обжатая",
            "Сталь закаленная, без обработки дробью и слегка предварительно обжатая"});
            this.comboBox1.Location = new System.Drawing.Point(34, 335);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 23);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox_Click);
            // 
            // hbBox_label
            // 
            this.hbBox_label.AutoSize = true;
            this.hbBox_label.Font = new System.Drawing.Font("MS Mincho", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hbBox_label.Location = new System.Drawing.Point(270, 256);
            this.hbBox_label.Name = "hbBox_label";
            this.hbBox_label.Size = new System.Drawing.Size(40, 12);
            this.hbBox_label.TabIndex = 12;
            this.hbBox_label.Text = "h/b =";
            // 
            // VidStali
            // 
            this.VidStali.AutoSize = true;
            this.VidStali.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VidStali.Location = new System.Drawing.Point(27, 316);
            this.VidStali.Name = "VidStali";
            this.VidStali.Size = new System.Drawing.Size(165, 19);
            this.VidStali.TabIndex = 14;
            this.VidStali.Text = "Вид обработки стали:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(695, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "K =";
            // 
            // GBox
            // 
            this.GBox.Location = new System.Drawing.Point(728, 201);
            this.GBox.Name = "GBox";
            this.GBox.Size = new System.Drawing.Size(99, 20);
            this.GBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(695, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "G =";
            // 
            // strainBox
            // 
            this.strainBox.Location = new System.Drawing.Point(727, 227);
            this.strainBox.Name = "strainBox";
            this.strainBox.Size = new System.Drawing.Size(100, 20);
            this.strainBox.TabIndex = 18;
            // 
            // strait
            // 
            this.strait.AutoSize = true;
            this.strait.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strait.Location = new System.Drawing.Point(633, 229);
            this.strait.Name = "strait";
            this.strait.Size = new System.Drawing.Size(88, 15);
            this.strait.TabIndex = 19;
            this.strait.Text = "Напряжение =";
            // 
            // Ccp
            // 
            this.Ccp.Location = new System.Drawing.Point(324, 27);
            this.Ccp.Name = "Ccp";
            this.Ccp.Size = new System.Drawing.Size(100, 20);
            this.Ccp.TabIndex = 20;
            // 
            // sn
            // 
            this.sn.Location = new System.Drawing.Point(324, 57);
            this.sn.Name = "sn";
            this.sn.Size = new System.Drawing.Size(100, 20);
            this.sn.TabIndex = 21;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(324, 92);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Сср =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Sn =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "A =";
            // 
            // L
            // 
            this.L.Location = new System.Drawing.Point(727, 151);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(100, 20);
            this.L.TabIndex = 26;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(696, 151);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(25, 15);
            this.label.TabIndex = 27;
            this.label.Text = "L =";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "3",
            "4",
            "6",
            "8",
            "10"});
            this.comboBox2.Location = new System.Drawing.Point(324, 256);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 28;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit.Location = new System.Drawing.Point(257, 201);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(82, 33);
            this.edit.TabIndex = 31;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(850, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "МПа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(850, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "МПа";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "H/m";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(573, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 15);
            this.label10.TabIndex = 35;
            this.label10.Text = "Длина шлицевой части =";
            // 
            // dlinaShlic
            // 
            this.dlinaShlic.Location = new System.Drawing.Point(727, 262);
            this.dlinaShlic.Name = "dlinaShlic";
            this.dlinaShlic.Size = new System.Drawing.Size(100, 20);
            this.dlinaShlic.TabIndex = 36;
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelS.Location = new System.Drawing.Point(560, 299);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(161, 15);
            this.labelS.TabIndex = 37;
            this.labelS.Text = "Диаметр шлицевой части =";
            // 
            // diamSh
            // 
            this.diamSh.Location = new System.Drawing.Point(727, 294);
            this.diamSh.Name = "diamSh";
            this.diamSh.Size = new System.Drawing.Size(100, 20);
            this.diamSh.TabIndex = 38;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 446);
            this.Controls.Add(this.diamSh);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.dlinaShlic);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.d1_label);
            this.Controls.Add(this.d_label);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.L);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.a);
            this.Controls.Add(this.sn);
            this.Controls.Add(this.Ccp);
            this.Controls.Add(this.strait);
            this.Controls.Add(this.strainBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VidStali);
            this.Controls.Add(this.hbBox_label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.res);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form7";
            this.Text = "Определение размеров торсиона";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.RadioButton CircularRb;
        private System.Windows.Forms.RadioButton RoundRb;
        private System.Windows.Forms.RadioButton SquareRb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label hbBox_label;
        private System.Windows.Forms.Label VidStali;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox strainBox;
        private System.Windows.Forms.Label strait;
        private System.Windows.Forms.TextBox Ccp;
        private System.Windows.Forms.TextBox sn;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox L;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label d_label;
        private System.Windows.Forms.Label d1_label;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dlinaShlic;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.TextBox diamSh;
    }
}