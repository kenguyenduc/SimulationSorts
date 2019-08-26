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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetMessage(string message)
        {
            txtForm1.Text = message;
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(GetMessage);
            //frm.Sender = new Form2.SendMessage(GetMessage);
            frm.ShowDialog();
        }
    }
}
