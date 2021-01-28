using System;
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
    public partial class Task_Edit : Form
    {
        public Task_Edit()
        {
            InitializeComponent();
        }

        public Task_Edit(string Task_Name, string Task_Description)
        {
            InitializeComponent();
            textBox_Task.Text = Task_Name;
            textBox_Description.Text = Task_Description;
        }


        private void button_Edit_Item_Click(object sender, EventArgs e)
        {

        }
    }
}
