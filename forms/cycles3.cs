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
    public partial class cycles3 : Form
    {
        public cycles3()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                int n = Convert.ToInt32(textBox1.Text);
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    listBox1.Items.Add(i.ToString());
                    sum += i;
                }
                listBox1.Items.Add($"Сумма чисел от 1 до {n}={sum}");

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
