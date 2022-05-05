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
    public partial class function3 : Form
    {
        //Конструктор
        public function3()
        {
            InitializeComponent();
        }

        //Методы отображающие действия кнопок после нажатия
        private void calcbutton_Click(object sender, EventArgs e)
        {
            double a, m, n, u, v, c, z;
            //Присваиваем переменным преобразованное значение из полей textBox'ов
            a = Convert.ToDouble(textBox1.Text);
            m = Convert.ToDouble(textBox2.Text);
            n = Convert.ToDouble(textBox3.Text);
            u = Convert.ToDouble(textBox4.Text);
            v = Convert.ToDouble(textBox5.Text);
            c = ((u - v) / 2) * Math.Sin(2 * a);
            z = (1.0 / 2.0) * (m + n + Math.Sqrt(Math.Pow(m - n, 2) + 4 * Math.Pow(c, 2)));
            //С помощью Add добавляем в listBox1 текст и получившиеся значение переменных
            listBox1.Items.Add($"При а = {a}");
            listBox1.Items.Add($"       m = {m}");
            listBox1.Items.Add($"       n = {n}");
            listBox1.Items.Add($"       U = {u}");
            listBox1.Items.Add($"       V = {v},");
            listBox1.Items.Add($"       c = {c:f2}");
            listBox1.Items.Add($"       z = {z:f2}");
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();//Методом Close закрываем эту форму
        }
    }
}
