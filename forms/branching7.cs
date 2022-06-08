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
    public partial class branching7 : Form
    {
        public branching7()
        {
            InitializeComponent();
        }

        private void checkbutton_Click(object sender, EventArgs e)
        {
            double a, b, c,d,r;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            d = Convert.ToDouble(textBox4.Text);
            r = Convert.ToDouble(textBox5.Text);
            if (r > a || r < b || r>c || r<d)
                MessageBox.Show("Точка C принадлежит отрезку ab");
            if (r < a || c > b || r<c || r>d)
                MessageBox.Show("Точка C не принадлежит отрезку");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
