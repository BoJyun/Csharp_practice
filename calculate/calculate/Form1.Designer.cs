﻿namespace calculate
{
    partial class Form1
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
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Result
            // 
            this.textBox_Result.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Result.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Result.Location = new System.Drawing.Point(23, 59);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(325, 43);
            this.textBox_Result.TabIndex = 0;
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Result.TextChanged += new System.EventHandler(this.textBox_Result_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 60);
            this.button3.TabIndex = 1;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(236, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 60);
            this.button4.TabIndex = 1;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Formula);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(300, 129);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 60);
            this.button5.TabIndex = 1;
            this.button5.Text = "CE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 195);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 60);
            this.button6.TabIndex = 1;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(99, 195);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 60);
            this.button7.TabIndex = 1;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(172, 204);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(58, 60);
            this.button8.TabIndex = 1;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(236, 204);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 60);
            this.button9.TabIndex = 1;
            this.button9.Text = "*";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Formula);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(300, 204);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(58, 60);
            this.button10.TabIndex = 1;
            this.button10.Text = "C";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(23, 273);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(58, 60);
            this.button11.TabIndex = 1;
            this.button11.Text = "1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(99, 273);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(58, 60);
            this.button12.TabIndex = 1;
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(172, 273);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(58, 60);
            this.button13.TabIndex = 1;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(236, 273);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(58, 60);
            this.button14.TabIndex = 1;
            this.button14.Text = "-";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Formula);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(300, 270);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(58, 138);
            this.button15.TabIndex = 1;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(23, 348);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(134, 60);
            this.button16.TabIndex = 1;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(172, 348);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(58, 60);
            this.button17.TabIndex = 1;
            this.button17.Text = ".";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(236, 348);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(58, 60);
            this.button18.TabIndex = 1;
            this.button18.Text = "+";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Formula);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 425);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        public System.Windows.Forms.Button button11;
    }
}