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
        bool reminder, done;

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

            label_Item.Text = title;
            checkBox_Item.Checked = done;
        }

        private void ToDo_Item_DoubleClick(object sender, EventArgs e)
        {
            Show_Task show = new TODO.Show_Task(id, day, sort_value, title, description, reminder, done);
            show.Show();
        }

        private void label_Item_DoubleClick(object sender, EventArgs e)
        {
            Show_Task show = new TODO.Show_Task(id, day, sort_value, title, description, reminder, done);
            show.Show();
        }

        private void pictureBox_Delete_Click(object sender, EventArgs e)
        {
            //detele a task
            var question = MessageBox.Show("Are you sure that you would delete a task?", "Delete a task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                Form1 delete = new Form1();
                delete.Delete(id, day, sort_value, title, description, reminder, done);
                MessageBox.Show("Task deleted. Please refresh the main page of application.", "Delete a task");
            }
        }

        private void pictureBox_Delete_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Delete", pictureBox_Delete);
        }

        private void pictureBox_Edit_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Edit", pictureBox_Edit);
        }

        private void label_Item_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Double click to show a task", label_Item);
        }

        private void checkBox_Item_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Complete a task", checkBox_Item);
        }

        private void pictureBox_Edit_Click(object sender, EventArgs e)
        {
            Task_Edit edit = new TODO.Task_Edit(id, day, sort_value, title, description, reminder, done);
            edit.Show();
        }

        private void checkBox_Item_Click(object sender, EventArgs e)
        {
            //complete a task
            done = !done;
            Form1 reset = new Form1();
            reset.Update(id, day, sort_value, title, description, reminder, done);
        }

        private void checkBox_Item_CheckedChanged(object sender, EventArgs e)
        {
            //set a color for completed task
            if (checkBox_Item.Checked == true)
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#85B185");
            }
            else
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#dcdcdc");
            }
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
    }
}
