using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            string userlog = textBox1.Text;
            string userpass = textBox2.Text;
            if (File.Exists(@"login.txt") == false || File.Exists(@"password.txt") == false
                || File.ReadAllText(@"login.txt").Length == 0 || File.ReadAllText(@"password.txt").Length == 0)
                MessageBox.Show("Нехватка данных логина или пароля, прежде чем выполнить вход пройдите регистрацию");
            else
            {
                if (userlog == File.ReadAllText(@"login.txt") && userpass == File.ReadAllText(@"password.txt"))
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
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void regbtn_Click(object sender, EventArgs e)
        {
            if(File.Exists(@"login.txt")==false) { File.Create(@"login.txt").Close(); }
            if (File.Exists(@"password.txt") == false) { File.Create(@"password.txt").Close(); }
            File.WriteAllText(@"login.txt", textBox1.Text);
            File.WriteAllText(@"password.txt", textBox2.Text);

        }
    }
}
