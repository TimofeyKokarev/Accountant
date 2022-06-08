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
    public partial class switchcase3 : Form
    {
        public switchcase3()
        {
            InitializeComponent();
        }

        private void ansbutton_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(textBox1.Text);
            if(n>=1 && n<=5 ) listBox1.Items.Add("Это рабочий день");
            switch (n)
            {
                case 6: listBox1.Items.Add("Это суббота"); break;
                case 7: listBox1.Items.Add("Это воскресенье"); break;
            }
            if (n > 7 || n < 1)
            {
                listBox1.Items.Add("Такого дня недели нет");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
