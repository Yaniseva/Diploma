﻿namespace WindowsFormsApplication1
{
    partial class popUpForCoefficient
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
            this.components = new System.ComponentModel.Container();
            this.submit = new System.Windows.Forms.Button();
            this.d_label = new System.Windows.Forms.Label();
            this.d1_label = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.TextBox();
            this.d1 = new System.Windows.Forms.TextBox();
            this.error_label = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(176, 127);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 0;
            this.submit.Text = "Cохранить";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // d_label
            // 
            this.d_label.AutoSize = true;
            this.d_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_label.Location = new System.Drawing.Point(43, 29);
            this.d_label.Name = "d_label";
            this.d_label.Size = new System.Drawing.Size(26, 15);
            this.d_label.TabIndex = 1;
            this.d_label.Text = "d = ";
            this.toolTip1.SetToolTip(this.d_label, "Внешний диаметр сечения");
            // 
            // d1_label
            // 
            this.d1_label.AutoSize = true;
            this.d1_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d1_label.Location = new System.Drawing.Point(43, 74);
            this.d1_label.Name = "d1_label";
            this.d1_label.Size = new System.Drawing.Size(32, 15);
            this.d1_label.TabIndex = 2;
            this.d1_label.Text = "d1 = ";
            this.toolTip1.SetToolTip(this.d1_label, "Внутренний диаметр сечения");
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(97, 27);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(100, 20);
            this.d.TabIndex = 3;
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(97, 72);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(100, 20);
            this.d1.TabIndex = 4;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(17, 132);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(153, 13);
            this.error_label.TabIndex = 5;
            this.error_label.Text = "Вы не заполнили поля!!!";
            // 
            // popUpForCoefficient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 156);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.d);
            this.Controls.Add(this.d1_label);
            this.Controls.Add(this.d_label);
            this.Controls.Add(this.submit);
            this.Name = "popUpForCoefficient";
            this.Text = "Диаметры";
            this.Load += new System.EventHandler(this.popUpForCoefficient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label d_label;
        private System.Windows.Forms.Label d1_label;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.TextBox d1;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}