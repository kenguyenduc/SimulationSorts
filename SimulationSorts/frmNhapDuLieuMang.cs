using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationSorts
{
    public partial class frmNhapDuLieuMang : Form
    {

        public delegate void SendMessage(int[] _arr);
        public SendMessage SenderData;

        NumericUpDown[] arrNum;
        Label[] lblNum;
        int _soPhanTu;
        int[] arrDuLieuMang;
        int _space = 5;


        public frmNhapDuLieuMang()
        {
            InitializeComponent();

        }

        public frmNhapDuLieuMang(SendMessage _sender)
        {
            InitializeComponent();
            this.SenderData = _sender;
        }

        private void frmNhapDuLieuMang_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            AddNewNum();
        }

        private void AddNewNum()
        {
            _soPhanTu = Int32.Parse(numSoPhanTu.Value + "");
            arrNum = new NumericUpDown[_soPhanTu];
            lblNum = new Label[_soPhanTu];
            pnNhapPhanTu.Controls.Clear();

            arrDuLieuMang = new int[_soPhanTu];
            for (int i = 0; i < _soPhanTu; i++)
            {
                arrNum[i] = new NumericUpDown();
                lblNum[i] = new Label();
                lblNum[i].Text = "A[" + i + "] ";
                lblNum[i].Name = "A" + i;

                arrNum[i].Visible = true;
                lblNum[i].Visible = true;

                arrNum[i].Width = 40;
                arrNum[i].Height = 20;

                arrNum[i].Maximum = 100;
                arrNum[i].Minimum = 1;

                if (i < 5)
                {
                    arrNum[i].Location = new Point((pnNhapPhanTu.Width - arrNum[i].Width) / 4, _space + pnNhapPhanTu.Controls.Count * (arrNum[i].Height + _space));
                    lblNum[i].Location = new Point((pnNhapPhanTu.Width - arrNum[i].Width) / 4 - 30, _space + pnNhapPhanTu.Controls.Count * (arrNum[i].Height + _space));
                } else
                {
                    arrNum[i].Location = new Point((pnNhapPhanTu.Width - arrNum[i].Width) / 4 * 3, _space + (pnNhapPhanTu.Controls.Count - 10) * (arrNum[i].Height + _space));
                    lblNum[i].Location = new Point((pnNhapPhanTu.Width - arrNum[i].Width) / 4 * 3 - 30, _space + (pnNhapPhanTu.Controls.Count - 10) * (arrNum[i].Height + _space));
                }
                pnNhapPhanTu.Controls.Add(arrNum[i]);
                pnNhapPhanTu.Controls.Add(lblNum[i]);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            for (int i=0;i<arrNum.Length;i++)
            {
                arrDuLieuMang[i] = Int32.Parse(arrNum[i].Value + "");
            }
            //this.SenderData(Int32.Parse(numSoPhanTu.Value + ""));
            this.SenderData(arrDuLieuMang);
            this.Close();
        }
    }
}
