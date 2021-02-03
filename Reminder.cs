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
    public partial class Reminder : Form
    {
        string day, title, description;
        int sort_value, id;
        bool reminder, done;

        public Reminder(int Id, string Day, int Sort_Value, string Title, string Description, bool Reminder, bool Done)
        {
            InitializeComponent();
            id = Id;
            day = Day;
            sort_value = Sort_Value;
            title = Title;
            description = Description;
            reminder = Reminder;
            done = Done;

            label_Title.Text = title;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            Show_Task show = new TODO.Show_Task(id, day, sort_value, title, description, reminder, done);
            show.Show();
            this.Close();
        }

    }
}
