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
    public partial class Show_Task : Form
    {
        string day, title, description;
        int sort_value, id;
        bool reminder, done, done2;

        public Show_Task(int Id, string Day, int Sort_Value, string Title, string Description, bool Reminder, bool Done)
        {
            InitializeComponent();
            id = Id;
            day = Day;
            sort_value = Sort_Value;
            title = Title;
            description = Description;
            reminder = Reminder;
            done = Done;

            label_Title.Text = "Title: " + title;
            label_Description.Text = "Description: " + description;
            label_Date.Text = "Date: " + day;

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Are you sure that you would delete a task?", "Delete a task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (question == DialogResult.Yes)
            {
                Form1 delete = new Form1();
                delete.Delete(id, day, sort_value, title, description, reminder, done);
                MessageBox.Show("Task deleted. Please refresh the main page of application.", "Delete a task");
                this.Close();
            }
        }

        private void button_Reminder_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            if (day == thisDay.ToString("d"))
            {
                MessageBox.Show("This task is today. You don't need a reminder.");
            }
            else
            {
                Form1 reset = new Form1();
                reset.Update(id, day, sort_value, title, description, false, done);
                MessageBox.Show("Reminder is set. Please refresh the main page of application.");
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            Task_Edit edit = new TODO.Task_Edit(id, day, sort_value, title, description, reminder, done);
            edit.Show();
            this.Close();
        }

        private void button_Done_Click(object sender, EventArgs e)
        {
            if (done == true)
            {
                MessageBox.Show("You can't complete a completed task", "Completed Task");
            }
            else if (done == false)
            {
                Form1 reset = new Form1();
                reset.Update(id, day, sort_value, title, description, reminder, true);
                MessageBox.Show("Task Done. Please refresh the main page of application.", "Completed task");
                this.Close();
            }
        }


    }
}
