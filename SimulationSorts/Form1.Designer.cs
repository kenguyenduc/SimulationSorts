namespace SimulationSorts
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
            this.txtForm1 = new System.Windows.Forms.TextBox();
            this.btnForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtForm1
            // 
            this.txtForm1.Location = new System.Drawing.Point(49, 51);
            this.txtForm1.Name = "txtForm1";
            this.txtForm1.Size = new System.Drawing.Size(125, 20);
            this.txtForm1.TabIndex = 3;
            // 
            // btnForm1
            // 
            this.btnForm1.Location = new System.Drawing.Point(231, 51);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(75, 23);
            this.btnForm1.TabIndex = 2;
            this.btnForm1.Text = "btnForm1";
            this.btnForm1.UseVisualStyleBackColor = true;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 136);
            this.Controls.Add(this.txtForm1);
            this.Controls.Add(this.btnForm1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtForm1;
        private System.Windows.Forms.Button btnForm1;
    }
}