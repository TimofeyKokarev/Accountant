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
    public partial class switchcase5 : Form
    {
        public switchcase5()
        {
            InitializeComponent();
        }

        private void ansbutton_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(textBox1.Text);
            switch (n)
            {
                case 1: listBox1.Items.Add("Зима"); break;
                case 2: listBox1.Items.Add("Зима"); break;
                case 3: listBox1.Items.Add("Весна"); break;
                case 4: listBox1.Items.Add("Весна"); break;
                case 5: listBox1.Items.Add("Весна"); break;
                case 6: listBox1.Items.Add("Лето"); break;
                case 7: listBox1.Items.Add("Лето"); break;
                case 8: listBox1.Items.Add("Лето"); break;
                case 9: listBox1.Items.Add("Осень"); break;
                case 10: listBox1.Items.Add("Осень"); break;
                case 11: listBox1.Items.Add("Осень"); break;
                case 12: listBox1.Items.Add("Зима"); break;
            }
            if (n > 12 || n < 1)
            {
                listBox1.Items.Add("Неправильно введено число");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
