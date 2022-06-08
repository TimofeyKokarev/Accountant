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
    public partial class switchcase1 : Form
    {
        public switchcase1()
        {
            InitializeComponent();
        }

        private void ansbutton_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(textBox1.Text);
            switch (n)
            {
                case 1: listBox1.Items.Add("Стол"); break;
                case 2: listBox1.Items.Add("Чашка"); break;
                case 3: listBox1.Items.Add("Тарелка"); break;
                case 4: listBox1.Items.Add("Кружка"); break;
            }
            if (n>4||n<1)
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
