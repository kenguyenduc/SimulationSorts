namespace SimulationSorts
{
    partial class frmKhoiTaoNgauNhien
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
            this.numSoPhanTu = new System.Windows.Forms.NumericUpDown();
            this.btnTaoMang = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.numSoPhanTu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập số phần tử của mảng (từ 2 đến 10):";
            // 
            // numSoPhanTu
            // 
            this.numSoPhanTu.Location = new System.Drawing.Point(232, 29);
            this.numSoPhanTu.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSoPhanTu.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSoPhanTu.Name = "numSoPhanTu";
            this.numSoPhanTu.Size = new System.Drawing.Size(64, 20);
            this.numSoPhanTu.TabIndex = 3;
            this.numSoPhanTu.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(334, 26);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMang.TabIndex = 4;
            this.btnTaoMang.Text = "Tạo mảng";
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // frmKhoiTaoNgauNhien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 88);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.numSoPhanTu);
            this.Controls.Add(this.label1);
            this.Name = "frmKhoiTaoNgauNhien";
            this.Text = "frmKhoiTaoNgauNhien";
            ((System.ComponentModel.ISupportInitialize)(this.numSoPhanTu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSoPhanTu;
        private DevExpress.XtraEditors.SimpleButton btnTaoMang;
    }
}