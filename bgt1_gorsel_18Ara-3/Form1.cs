﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt1_gorsel_18Ara_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi= Convert.ToInt32(textBox1.Text);
            for (int i=1; i <=10; i++)
            {
                listBox1.Items.Add(sayi+"x"+i+"="+sayi*i);
            }                       
                                    
        }
    }
}
