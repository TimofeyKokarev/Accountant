﻿using System;
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
    public partial class MainMenu : Form
    {
        //Поля
        private Form ActiveForm;//Создание приватного поля класса Form-ActiveForm
       
        //Конструктор
        public MainMenu()
        {
            InitializeComponent();
            MoveSidePanel(btn1);//Использование метода MoveSidePanel для кнопки btn1,чтобы по умолчание полоска(SidePanel) была на 1-й кнопке
        }

        //Метод двигающий полоску
        private void MoveSidePanel(Control c)//Создание метода с параметром "с" класса Control,отвечающим за управление элементами
        {
            SidePanel.Height = c.Height;//Установка высоты элемента SidePane
            SidePanel.Top = c.Top;//Установка расстояния от верхней границы контейнера ControlMenu до верхней границы элемента SidePanel
        }
        //Метод открывающий форму
        private void OpenChildForm(Form ChildForm,object BtnSender)//Создание метода с параметрами класса Form-ChildForm и класса object-BtnSender
        {
            if (ActiveForm != null) { ActiveForm.Close();}//Если ActiveForm не 0, то закрыть ActiveForm методом Close
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;//Присваиваем свойству TopLevel значение false чтобы открывашяся форма не перекрывала основную
            ChildForm.FormBorderStyle = FormBorderStyle.None;//Присвоить значение стилям границ "никакое",т.е. нулевое значение
            ChildForm.Dock = DockStyle.Fill;//Размерам границ ChildForm присовить значение Fill(растянуть/заполнить)
            this.MainDataWindow.Controls.Add(ChildForm);//Добавляет элементы управления(кнопки и т.д.) из открывшейся формы на экран
            this.MainDataWindow.Tag = ChildForm;//Передать данные об элементах управления из ChildForm в MainDataWindow
            ChildForm.BringToFront();//Методом BringToFront перемещение открывшейся формы на передний план
            ChildForm.Show();//Методом Show показать форму
        }

        //Методы отображающие действия кнопок после нажатия
        private void btn1_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btn1);//Использование метода MoveSidePanel для кнопки btn1
            OpenChildForm(new LinearMain(),sender);//Использование метода OpenChildForm, где форма берётся из папки forms
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btn2);//Использование метода MoveSidePanel для кнопки btn2
            OpenChildForm(new BranchingMain(), sender);//Использование метода OpenChildForm, где форма берётся из папки forms
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btn3);//Использование метода MoveSidePanel для кнопки btn3
            OpenChildForm(new SwitchCaseMain(), sender);//Использование метода OpenChildForm, где форма берётся из папки forms
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btn4);//Использование метода MoveSidePanel для кнопки btn4
            OpenChildForm(new forms.CyclesMain(), sender);//Использование метода OpenChildForm, где форма берётся из папки forms
        }
    }
}
