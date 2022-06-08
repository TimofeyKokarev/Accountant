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
    public partial class cycles8 : Form
    {
        public cycles8()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            int x, y;//Объявление переменных
            x = 1;//Переменной x присвоить значение равное 1
            y = 0;//Переменной y присвоить значение равное 0
            listBox1.Items.Add("Постфиксная форма y = y + x++");//Вывод предложения на экран
            for (int i = 0; i < 5; i++)//Объявление переменной i целочисленного типа; i = i + 1; i = 0 - инициализация,i & lt; 10 - условие,i++ -итерация
            {
                y = y + x++;//Вычисление y;x++ - постфиксная форма;
                listBox1.Items.Add("y ="+y);//Вывод предложения на экран со значением y
            }
            x = 1;//Переменной x присвоить значение равное 1
            y = 0;//Переменной y присвоить значение равное 0
            listBox1.Items.Add("Префиксная форма y = y + ++x");//Вывод предложения на экран
            for (int i = 0; i < 5; i++)//Объявление переменной i целочисленного типа; i = i + 1; i = 0 - инициализация,i & lt; 10 - условие,i++ - итерация
            {
                y = y + ++x;//Вычисление y;++x - префиксная форма;
                listBox1.Items.Add("y =" + y);//Вывод предложения на экран со значением y
            }
        }
    }
}
