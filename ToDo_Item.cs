using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TODO.Form1;

namespace TODO
{
    public partial class ToDo_Item : UserControl
    {
        string day, title, description;
        int sort_value;
        bool reminder, done;
        public ToDo_Item()
        {
            InitializeComponent();
        }


        public ToDo_Item(string Day, int Sort_Value, string Title, string Description, bool Reminder, bool Done)
        {
            InitializeComponent();
            day = Day;
            sort_value = Sort_Value;
            title = Title;
            description = Description;
            reminder = Reminder;
            done = Done;

            label_Item.Text = Title;
            checkBox_Item.Checked = Done;
        }

        private void ToDo_Item_DoubleClick(object sender, EventArgs e)
        {
            Show_Task show = new TODO.Show_Task(day, sort_value, title, description, reminder, done);
            show.Show();
        }

        private void ToDo_Item_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("click");
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Task_Edit edit = new TODO.Task_Edit(day, sort_value, title, description, reminder, done);
            edit.Show();
        }

        private void checkBox_Item_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Item.Checked == true)
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#85B185");
                //Form1 reset = new Form1();
                //reset.Reset_Panel();


            }
            else
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#dcdcdc");
            }
        }
    }
}
