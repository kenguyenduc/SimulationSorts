namespace SimulationSorts
{
    partial class frmNhapDuLieuMang
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnNhapPhanTu = new System.Windows.Forms.Panel();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaoMang = new DevExpress.XtraEditors.SimpleButton();
            this.numSoPhanTu = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoPhanTu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnNhapPhanTu);
            this.pnMain.Controls.Add(this.btnXacNhan);
            this.pnMain.Controls.Add(this.btnTaoMang);
            this.pnMain.Controls.Add(this.numSoPhanTu);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(482, 352);
            this.pnMain.TabIndex = 0;
            // 
            // pnNhapPhanTu
            // 
            this.pnNhapPhanTu.Location = new System.Drawing.Point(3, 59);
            this.pnNhapPhanTu.Name = "pnNhapPhanTu";
            this.pnNhapPhanTu.Size = new System.Drawing.Size(476, 243);
            this.pnNhapPhanTu.TabIndex = 3;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(210, 317);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(341, 20);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMang.TabIndex = 2;
            this.btnTaoMang.Text = "Tạo mảng";
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // numSoPhanTu
            // 
            this.numSoPhanTu.Location = new System.Drawing.Point(221, 20);
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
            this.numSoPhanTu.TabIndex = 1;
            this.numSoPhanTu.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số phần tử của mảng (từ 2 đến 10):";
            // 
            // frmNhapDuLieuMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 352);
            this.Controls.Add(this.pnMain);
            this.Name = "frmNhapDuLieuMang";
            this.Text = "frmNhapDuLieuMang";
            this.Load += new System.EventHandler(this.frmNhapDuLieuMang_Load);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoPhanTu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private DevExpress.XtraEditors.SimpleButton btnTaoMang;
        private System.Windows.Forms.NumericUpDown numSoPhanTu;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private System.Windows.Forms.Panel pnNhapPhanTu;
    }
}