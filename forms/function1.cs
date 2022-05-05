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
    public partial class function1 : Form
    {
        //Конструктор
        public function1()
        {
            InitializeComponent();
        }

        //Методы отображающие действия кнопок после нажатия
        private void calcbutton_Click(object sender, EventArgs e)
        {
            double a, b, h, p, z;
            //Присваиваем переменным преобразованное значение из полей textBox'ов
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            h = Convert.ToDouble(textBox3.Text);
            p = 3 * (Math.Pow(a, 2) + Math.Pow(b, 2));
            z = ((Math.PI * h) / 6) * (p + Math.Pow(h, 2));
            //С помощью Add добавляем в listBox1 текст и получившиеся значение переменных
            listBox1.Items.Add($"При а = {a}");
            listBox1.Items.Add($"       b = {b}");
            listBox1.Items.Add($"       H = {h},");
            listBox1.Items.Add($"       p = {p:f3}");
            listBox1.Items.Add($"       z = {z:f3}");
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();//Методом Close закрываем эту форму
        }
    }
}
