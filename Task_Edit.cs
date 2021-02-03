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
        string day, title, description;
        int sort_value, id;
        bool reminder, done;

        public Task_Edit(int Id, string Day, int Sort_Value, string Title, string Description, bool Reminder, bool Done)
        {
            InitializeComponent();

            id = Id;
            day = Day;
            sort_value = Sort_Value;
            title = Title;
            description = Description;
            reminder = Reminder;
            done = Done;

            textBox_Task.Text = title;
            textBox_Description.Text = description;
            label_Date_Value.Text = day;
            button_Edit_Item.Enabled = false;
        }

        private void textBox_Description_TextChanged(object sender, EventArgs e)
        {
            button_Edit_Item.Enabled = true;
        }

        private void label_Date_TextChanged(object sender, EventArgs e)
        {
            button_Edit_Item.Enabled = true;
        }

        private void textBox_Task_TextChanged(object sender, EventArgs e)
        {
            button_Edit_Item.Enabled = true;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            label_Date_Value.Text = monthCalendar1.SelectionStart.ToString("d");
        }

        private void button_Edit_Item_Click(object sender, EventArgs e)
        {
            Form1 reset = new Form1();
            reset.Update(id, label_Date_Value.Text, sort_value, textBox_Task.Text, textBox_Description.Text, reminder, done);
            MessageBox.Show("The task has bin edited. Please refresh the main page of application.", "Task edited");
            Show_Task show = new TODO.Show_Task(id, day, sort_value, title, description, reminder, done);
            show.Show();
            this.Close();
        }
    }
}
