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
    public partial class switchcase2 : Form
    {
        public switchcase2()
        {
            InitializeComponent();
        }

        private void ansbutton_Click(object sender, EventArgs e)
        {

            int n;
            n = Convert.ToInt32(textBox1.Text);
            switch (n)
            {
                case 1: listBox1.Items.Add("Понедельник"); break;
                case 2: listBox1.Items.Add("Вторник"); break;
                case 3: listBox1.Items.Add("Среда"); break;
                case 4: listBox1.Items.Add("Четверг"); break;
                case 5: listBox1.Items.Add("Пятница"); break;
                case 6: listBox1.Items.Add("Суббота"); break;
                case 7: listBox1.Items.Add("Воскресенье"); break;
            }
            if (n > 7 || n<1)
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
