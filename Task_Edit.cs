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
        public Task_Edit()
        {
            InitializeComponent();
        }

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
        }



        private void button_Edit_Item_Click(object sender, EventArgs e)
        {
            Form1 reset = new Form1();
            reset.Update(id, label_Date_Value.Text, sort_value, textBox_Task.Text, textBox_Description.Text, reminder, done);
            reset.Reset_Panel();
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label_Date_Value.Text = monthCalendar1.SelectionStart.ToString("d");
        }

    }
}
