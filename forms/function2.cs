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
    public partial class function2 : Form
    {
        //Конструктор
        public function2()
        {
            InitializeComponent();
        }

        //Методы отображающие действия кнопок после нажатия
        private void calcbutton_Click(object sender, EventArgs e)
        {
            double a, r, h, s, z;
            //Присваиваем переменным преобразованное значение из полей textBox'ов
            a = Convert.ToDouble(textBox1.Text);
            r = Convert.ToDouble(textBox2.Text);
            h = 2 * a;
            s = Math.PI * Math.Pow(r, 2);
            z = Math.PI * r * h + s;
            //С помощью Add добавляем в listBox1 текст и получившиеся значение переменных
            listBox1.Items.Add($"При а = {a}");
            listBox1.Items.Add($"       R = {r},");
            listBox1.Items.Add($"       h = {h}");
            listBox1.Items.Add($"       S = {s:f3}");
            listBox1.Items.Add($"       z = {z:f3}");
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();//Методом Close закрываем эту форму
        }
    }
}
