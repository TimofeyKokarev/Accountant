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
    public partial class switchcase4 : Form
    {
        public switchcase4()
        {
            InitializeComponent();
        }

        private void ansbutton_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(textBox1.Text);
            switch (n)
            {
                case 1: listBox1.Items.Add("Январь"); break;
                case 2: listBox1.Items.Add("Февраль"); break;
                case 3: listBox1.Items.Add("Март"); break;
                case 4: listBox1.Items.Add("Апрель"); break;
                case 5: listBox1.Items.Add("Май"); break;
                case 6: listBox1.Items.Add("Июнь"); break;
                case 7: listBox1.Items.Add("Июль"); break;
                case 8: listBox1.Items.Add("Август"); break;
                case 9: listBox1.Items.Add("Сентябрь"); break;
                case 10: listBox1.Items.Add("Октябрь"); break;
                case 11: listBox1.Items.Add("Ноябрь"); break;
                case 12: listBox1.Items.Add("Декабрь"); break;
            }
            if (n > 12 || n < 1)
            {
                listBox1.Items.Add("Такого месяца не существует");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
