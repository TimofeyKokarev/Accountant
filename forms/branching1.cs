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
    public partial class branching1 : Form
    {
        public branching1()
        {
            InitializeComponent();
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            if ((i % 3 == 0) && (i % 11 == 0)) listBox1.Items.Add("Кратно");
            else listBox1.Items.Add("Не кратно");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
