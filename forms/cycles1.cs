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
    public partial class cycles1 : Form
    {
        public cycles1()
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
                int k = 0;
                if (A < B)
                {
                    for (int i = A; i <= B; i++)
                    {
                        listBox1.Items.Add(i.ToString());
                        k++;
                    }
                    textBox3.Text = Convert.ToString(k);
                }
                else
                    label5.Text = "Неправильно введены данные";

            }
            catch (Exception)
            {
                label5.Text = "Поля не заполнены";
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
