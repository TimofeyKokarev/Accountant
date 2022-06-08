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
    public partial class branching5 : Form
    {
        public branching5()
        {
            InitializeComponent();
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            double a, b, c, D, x1, x2;//Объявление переменных
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            D = ((Math.Pow(b, 2)) - (4 * a * c));
            if (D < 0)
                listBox1.Items.Add("Корней нет");
            else if (D == 0)
                listBox1.Items.Add($"x1=x2={(-b + (Math.Sqrt(D))) / (2 * a):f2}");
            else if (D > 0)
            {
                listBox1.Items.Add($"x1={(-b - (Math.Sqrt(D))) / (2 * a):f2}");
                listBox1.Items.Add($"x2={(-b + (Math.Sqrt(D))) / (2 * a):f2}");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
