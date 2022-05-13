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
    public partial class branching2 : Form
    {
        public branching2()
        {
            InitializeComponent();
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            double x, y, z, f;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);
            if (x > y) f = Math.Pow(x, 2);
            else f = y - x + z;
            listBox1.Items.Add("При x = " + x);
            listBox1.Items.Add(" у =" + y);
            listBox1.Items.Add(" z =" + z);
            listBox1.Items.Add(" f =" + f);
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}