using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apptexbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double numero1, numero2, suma;
            numero1 = double.Parse(txt1.Text);
            numero2 = double.Parse(txt2.Text);
            suma = numero1 + numero2;
            lblres.Text = "Resultado: " + suma;

        }
    }
}
