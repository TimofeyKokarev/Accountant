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
    public partial class cycles5 : Form
    {
        public cycles5()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                int A = Convert.ToInt32(textBox1.Text);
                int B = Convert.ToInt32(textBox2.Text);
                if (A < B)
                {
                    for (int i = A; i <= B; i++)
                    {
                        listBox1.Items.Add(i.ToString()+"°C="+((i*(9.0/5.0))+32)+ "°F");
                    }
                }
                else
                    listBox1.Items.Add("Неправильно введены данные");

            }
            catch (Exception)
            {
                listBox1.Items.Add("Поля не заполнены");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
