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
    public partial class function5 : Form
    {
        //Конструктор
        public function5()
        {
            InitializeComponent();
        }

        //Методы отображающие действия кнопок после нажатия
        private void calcbutton_Click(object sender, EventArgs e)
        {
            double a, b, c, s, p, z;
            //Присваиваем переменным преобразованное значение из полей textBox'ов
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text); ;
            p=(1.0/2.0)*(a+b+c);
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            z = s/p;
            //С помощью Add добавляем в listBox1 текст и получившиеся значение переменных
            listBox1.Items.Add($"При a = {a}");
            listBox1.Items.Add($"       b = {b}");
            listBox1.Items.Add($"       c = {c},");
            listBox1.Items.Add($"       p = {p:f2}");
            listBox1.Items.Add($"       s = {s:f2}");
            listBox1.Items.Add($"       z = {z:f2}");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();//Методом Close закрываем эту форму
        }
    }
}
