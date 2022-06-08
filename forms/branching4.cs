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
    public partial class branching4 : Form
    {
        public branching4()
        {
            InitializeComponent();
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            double x, y = 0;
            x = Convert.ToDouble(textBox1.Text);
            if (x <=0)
                y = 5 * Math.Pow(x, 2) + 6;
            if (0 < x && x <= Math.PI)
                y = Math.Cos(x);
            if (x>Math.PI)
                y = Math.Pow(Math.E, x/10.0);
            listBox1.Items.Add("При x = " + x);
            listBox1.Items.Add($" у = {y:f2}");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
