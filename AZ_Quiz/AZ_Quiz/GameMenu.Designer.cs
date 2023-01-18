namespace AZ_Quiz
{
    partial class GameMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.PVP = new System.Windows.Forms.Button();
            this.Solo = new System.Windows.Forms.Button();
            this.SMT = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick game mode";
            // 
            // PVP
            // 
            this.PVP.Location = new System.Drawing.Point(55, 218);
            this.PVP.Name = "PVP";
            this.PVP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PVP.Size = new System.Drawing.Size(239, 83);
            this.PVP.TabIndex = 1;
            this.PVP.Text = "PVP";
            this.PVP.UseVisualStyleBackColor = true;
            this.PVP.Click += new System.EventHandler(this.PVP_Click);
            // 
            // Solo
            // 
            this.Solo.Location = new System.Drawing.Point(55, 59);
            this.Solo.Name = "Solo";
            this.Solo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Solo.Size = new System.Drawing.Size(239, 83);
            this.Solo.TabIndex = 2;
            this.Solo.Text = "Solo";
            this.Solo.UseVisualStyleBackColor = true;
            this.Solo.Click += new System.EventHandler(this.Solo_Click);
            // 
            // SMT
            // 
            this.SMT.Location = new System.Drawing.Point(55, 369);
            this.SMT.Name = "SMT";
            this.SMT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SMT.Size = new System.Drawing.Size(239, 83);
            this.SMT.TabIndex = 3;
            this.SMT.Text = "SMT";
            this.SMT.UseVisualStyleBackColor = true;
            this.SMT.Click += new System.EventHandler(this.SMT_Click);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 503);
            this.Controls.Add(this.SMT);
            this.Controls.Add(this.Solo);
            this.Controls.Add(this.PVP);
            this.Controls.Add(this.label1);
            this.Name = "GameMenu";
            this.Text = "AZ Quiz";
            this.Load += new System.EventHandler(this.GameMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button PVP;
        private Button Solo;
        private Button SMT;
        private HelpProvider helpProvider1;
    }
}