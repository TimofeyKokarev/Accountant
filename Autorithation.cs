using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кокарев_формы
{
    public partial class Autorithation : Form
    {
        public Autorithation()
        {
            InitializeComponent();
        }
        int k = 0;
        private void loginbutton_Click(object sender, EventArgs e)
        {
            string login = "login";
            string password = "password";
            string userlog = textBox1.Text;
            string userpass = textBox2.Text;
            if (userlog == login && userpass == password)
            {
                forms.Success success = new forms.Success();
                success.Show();
            }
            else
            {
                MessageBox.Show("Логин или пароль введены неверно\nДля повторного ввода нажмите «Ок»");
                k++;
            }
            if (k >= 3)
            {
                loginbutton.Visible = false;
                forms.Error error = new forms.Error();
                error.Show();
            }
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
