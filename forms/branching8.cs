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
    public partial class branching8 : Form
    {
        public branching8()
        {
            InitializeComponent();
        }

        private void checkbutton_Click(object sender, EventArgs e)
        {
            double x, y, R;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            R = Convert.ToDouble(textBox3.Text);
            if (Math.Sqrt(x*x+y*y)<R) MessageBox.Show("Точка принадлежит окружности");
            else MessageBox.Show("Точка не принадлежит окружности");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
