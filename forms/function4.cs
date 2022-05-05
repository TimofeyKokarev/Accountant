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
    public partial class function4 : Form
    {
        //Конструктор
        public function4()
        {
            InitializeComponent();
        }

        //Методы отображающие действия кнопок после нажатия
        private void calcbutton_Click(object sender, EventArgs e)
        {
            double f, k, p, q, z;
            //Присваиваем переменным преобразованное значение из полей textBox'ов
            f = Convert.ToDouble(textBox1.Text);
            k = Convert.ToDouble(textBox2.Text);
            p = Convert.ToDouble(textBox3.Text);;
            q = f / k;
            z = (p / 2.0) * Math.Sqrt(1 + (1 / (((16.0 / 3.0) * (Math.Pow(q, 2)) * (1 + (4.0 / 3.0) * Math.Pow(q, 2))))));
            //С помощью Add добавляем в listBox1 текст и получившиеся значение переменных
            listBox1.Items.Add($"При f = {f}");
            listBox1.Items.Add($"       k = {k}");
            listBox1.Items.Add($"       p = {p},");
            listBox1.Items.Add($"       c = {q:f2}");
            listBox1.Items.Add($"       z = {z:f2}");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();//Методом Close закрываем эту форму
        }
    }
}
