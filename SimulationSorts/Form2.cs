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
    public partial class Form2 : Form
    {
        public delegate void SendMessage(string message);
        public SendMessage Sender;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(SendMessage _sender)
        {
            InitializeComponent();
            this.Sender = _sender;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Sender(txtForm2.Text.ToString());
            this.Close();
        }
    }
}
