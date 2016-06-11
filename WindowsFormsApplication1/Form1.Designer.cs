namespace WindowsFormsApplication1
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
            this.textBoxNaam = new System.Windows.Forms.TextBox();
            this.buttonHallo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNaam
            // 
            this.textBoxNaam.Location = new System.Drawing.Point(12, 12);
            this.textBoxNaam.Name = "textBoxNaam";
            this.textBoxNaam.Size = new System.Drawing.Size(260, 20);
            this.textBoxNaam.TabIndex = 0;
            // 
            // buttonHallo
            // 
            this.buttonHallo.Location = new System.Drawing.Point(159, 173);
            this.buttonHallo.Name = "buttonHallo";
            this.buttonHallo.Size = new System.Drawing.Size(75, 23);
            this.buttonHallo.TabIndex = 1;
            this.buttonHallo.Text = "Hallo";
            this.buttonHallo.UseVisualStyleBackColor = true;
            this.buttonHallo.Click += new System.EventHandler(this.buttonHallo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonHallo);
            this.Controls.Add(this.textBoxNaam);
            this.Name = "Form1";
            this.Text = "Opdrachtblz28";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNaam;
        private System.Windows.Forms.Button buttonHallo;
    }
}

