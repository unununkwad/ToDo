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
        int sort_value, id;
        bool reminder, done, done2;
        public ToDo_Item()
        {
            InitializeComponent();
        }


        public ToDo_Item(int Id, string Day, int Sort_Value, string Title, string Description, bool Reminder, bool Done)
        {
            InitializeComponent();
            id = Id;
            day = Day;
            sort_value = Sort_Value;
            title = Title;
            description = Description;
            reminder = Reminder;
            done = Done;
            //MessageBox.Show(title, done.ToString());
            label_Item.Text = title;
            checkBox_Item.Checked = done;
        }

        private void ToDo_Item_DoubleClick(object sender, EventArgs e)
        {
            Show_Task show = new TODO.Show_Task(day, sort_value, title, description, reminder, done);
            show.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form1 delete = new Form1();
            delete.Delete(id, day, sort_value, title, description, reminder, done);
        }

        private void checkBox_Item_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(done.ToString());
            if (done == true)
            {
                done2 = false;
            }
            else if (done == false)
            {
                done2 = true;
            }
            Form1 reset = new Form1();
            reset.Update(id, day, sort_value, title, description, reminder, done2);
            //reset.TopLevel = false;
            //reset.panel3.Controls.Clear();
            //reset.panel3.Show();
            //reset.Reset_Panel2();

        }

        private void checkBox_Item_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ToDo_Item_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("click");
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Task_Edit edit = new TODO.Task_Edit(id, day, sort_value, title, description, reminder, done);
            edit.Show();
        }
   
        private void checkBox_Item_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(title);
            if (checkBox_Item.Checked == true)
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#85B185");
            }
            else
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#dcdcdc");
            }
        }
    }
}
