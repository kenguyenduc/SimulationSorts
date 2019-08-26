namespace SimulationSorts
{
    partial class Form2
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
            this.btnForm2 = new System.Windows.Forms.Button();
            this.txtForm2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(252, 73);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(75, 23);
            this.btnForm2.TabIndex = 0;
            this.btnForm2.Text = "btnForm2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // txtForm2
            // 
            this.txtForm2.Location = new System.Drawing.Point(70, 73);
            this.txtForm2.Name = "txtForm2";
            this.txtForm2.Size = new System.Drawing.Size(125, 20);
            this.txtForm2.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 154);
            this.Controls.Add(this.txtForm2);
            this.Controls.Add(this.btnForm2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.TextBox txtForm2;
    }
}