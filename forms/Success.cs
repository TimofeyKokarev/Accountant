﻿using System;
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
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
            do
            {
                progressBar1.Value++;
                if (progressBar1.Value == 120)
                {
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                }
            }
            while (progressBar1.Value <120);
        }
    }
}
