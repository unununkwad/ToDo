﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime thisDay = DateTime.Today;
            label1.Text = thisDay.ToString("d");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
            {
                groupBox1.Show();
            }
            else
            {
                groupBox1.Hide();
            }
        }

        //private DateTime last_mouse_down = DateTime.Now;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //last_mouse_down = DateTime.Now.Subtract(new TimeSpan(1, 0, 0));
            label1.Text = monthCalendar1.SelectionStart.ToString("d");
        }

        int position_Item = 0;
        public void addItem(string Text, bool Checked)
        {
            ToDo_Item item = new TODO.ToDo_Item(Text, Checked);
            panel3.Controls.Add(item);
            item.Top = position_Item;
            panel3.Show();
            position_Item = position_Item + item.Height + 10;
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            addItem(AddItem_Text.Text, false);
            AddItem_Text.Text = "";
            //string[] items = new string[]
            //{
            //   "coś1","coś2","coś3","coś4","coś5"
            //};
            //comboBox1.Items.AddRange(items);

        }

    }
}
