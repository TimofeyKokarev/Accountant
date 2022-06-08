using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кокарев_формы.forms
{
    public partial class branching3 : Form
    {
        public branching3()
        {
            InitializeComponent();
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            double x,y=0;
            x = Convert.ToDouble(textBox1.Text);
            if (x >=1) 
                y = Math.Log(x);
            if (x <= 0)
                y = Math.Sqrt(4 + (Math.Pow(x, 2)));
            if (0<x && x<1)
                y = Math.Pow(Math.E, -3 * x);
            listBox1.Items.Add("При x = " + x);
            listBox1.Items.Add($" у = {y:f3}");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
