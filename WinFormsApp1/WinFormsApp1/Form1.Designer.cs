using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(75, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 27);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(33, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(121, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 55);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(208, 291);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 55);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(33, 370);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 55);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(121, 370);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 55);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(208, 370);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(61, 55);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(121, 451);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(61, 55);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // divButton
            // 
            this.divButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.divButton.Location = new System.Drawing.Point(336, 451);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(54, 55);
            this.divButton.TabIndex = 11;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = false;
            // 
            // sumButton
            // 
            this.sumButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sumButton.Location = new System.Drawing.Point(336, 228);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(54, 55);
            this.sumButton.TabIndex = 12;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = false;
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minusButton.Location = new System.Drawing.Point(336, 304);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(54, 55);
            this.minusButton.TabIndex = 13;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            // 
            // mulButton
            // 
            this.mulButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mulButton.Location = new System.Drawing.Point(336, 379);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(54, 55);
            this.mulButton.TabIndex = 14;
            this.mulButton.Text = "*";
            this.mulButton.UseVisualStyleBackColor = false;
            // 
            // resultButton
            // 
            this.resultButton.BackColor = System.Drawing.Color.IndianRed;
            this.resultButton.Location = new System.Drawing.Point(276, 451);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(54, 55);
            this.resultButton.TabIndex = 15;
            this.resultButton.Text = "=";
            this.resultButton.UseVisualStyleBackColor = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.LightGreen;
            this.ClearButton.Location = new System.Drawing.Point(336, 146);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(54, 55);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label.Location = new System.Drawing.Point(33, 146);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(54, 20);
            this.label.TabIndex = 17;
            this.label.Tag = "";
            this.label.Text = "XXXXX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 536);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button divButton;
        private Button sumButton;
        private Button minusButton;
        private Button mulButton;
        private Button resultButton;
        private Button ClearButton;
        private Label label;
    }
}