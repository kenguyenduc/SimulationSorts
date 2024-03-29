﻿using System;
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
    public partial class frmKhoiTaoNgauNhien : Form
    {
        public delegate void SendMessage(int _soPhanTu);
        public SendMessage SenderData;

        public frmKhoiTaoNgauNhien()
        {
            InitializeComponent();
        }
        public frmKhoiTaoNgauNhien(SendMessage _sender)
        {
            InitializeComponent();
            this.SenderData = _sender;
        }


        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            SenderData(Int32.Parse(numSoPhanTu.Value + ""));
            this.Close();
        }
    }
}
