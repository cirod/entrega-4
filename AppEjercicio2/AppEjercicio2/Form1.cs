using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEjercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2, suma, resta, multiplicacion, division;
            num1 = float.Parse(txt1.Text);
            num2 = float.Parse(txt2.Text);
            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion=num1*num2;
            division = num1 / num2;
            if(rb1.Checked==true)
                lblres.Text=suma.ToString();
            if (rb2.Checked == true)
                lblres.Text = resta.ToString();
            if (rb3.Checked == true)
                lblres.Text = multiplicacion.ToString();
            if (rb4.Checked == true)
                lblres.Text = division.ToString();

        }
    }
}
