﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string question;
        public string answer;
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = answer;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        public void show()
        {
            label1.Text = question;
        }
    }
}