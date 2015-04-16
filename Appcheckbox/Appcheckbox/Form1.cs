using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appcheckbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            Text=" ";
            if (chk1.Checked == true)
            {
                Text += "Google Chrome";
            }
            if (chk2.Checked == true)
            {
                Text += "Mozilla Firefox";
            }
            if (chk3.Checked == true)
            {
                Text += "Spartan";
            }
        }
    }
}
