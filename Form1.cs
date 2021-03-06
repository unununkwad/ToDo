﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;

namespace TODO
{
    public partial class Form1 : Form
    {
        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;
        int position_Item = 0;
        int Tasks_index = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            label1.Text = thisDay.ToString("d");
            Reset_Panel();
            Reset_Session();
        }

        private void pictureBox_Calendar_Click(object sender, EventArgs e)
        {
            //show and hide a panel with calendar
            if (groupBox1.Visible == false)
            {
                groupBox1.Show();
            }
            else
            {
                groupBox1.Hide();
            }
        }

        private void Add_Task_Click(object sender, EventArgs e)
        {
            Add_Task_To_Database();
        }

        private void pictureBox_Refresh_Click(object sender, EventArgs e)
        {
            Reset_Panel();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            label1.Text = monthCalendar1.SelectionStart.ToString("d");
            groupBox1.Hide();
            Reset_Panel();
        }

        private void AddItem_Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add_Task_To_Database();
            }
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void pictureBox_Refresh_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Refresh a page", pictureBox_Refresh);
        }


        private void pictureBox_Calendar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Calendar", pictureBox_Calendar);
        }

        private void AddItem_Text_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Type here a task title", AddItem_Text);
        }
        //end of events











        public void Reset_Session()
        {
            //restart a connect with a database
            if (mySession != null && mySession.IsOpen)
            {
                mySession.Close();
            }
            if (mySessionFactory != null && !mySessionFactory.IsClosed)
            {
                mySessionFactory.Close();
            }

            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();
        }

        public void Reset_Panel()
        {
            //reset panel and selecting a tasks from database
            Reset_Session();
            panel3.Controls.Clear();
            position_Item = 0;
            Tasks_index = 1;

            var Items = mySession.CreateCriteria<contactDb>()
                .Add(Expression.Like("Day", label1.Text))
                .AddOrder(Order.Asc("Done"))
                .AddOrder(Order.Asc("Sort_Value"))
                .List<contactDb>();

            DateTime thisDay = DateTime.Today;
            foreach (var s in Items)
            {
                //if user set a reminder, it will be displayed here
                if (s.Day == thisDay.ToString("d") && s.Reminder == false)
                {
                    Reminder reminder_form = new TODO.Reminder(s.Id, s.Day, s.Sort_Value, s.Title, s.Description, s.Reminder, s.Done);
                    reminder_form.Show();
                    s.Reminder = true;
                    Update(s.Id, s.Day, s.Sort_Value, s.Title, s.Description, s.Reminder, s.Done);
                }

                AddItem(s.Id, s.Day, s.Sort_Value, s.Title, s.Description, s.Reminder, s.Done);
                Tasks_index++;
            }
        }

        public void AddItem(int Id, string Day, int Sort_Value, string Title, string Description, bool Reminder, bool Done)
        {
            //add a item to panel
            ToDo_Item item = new TODO.ToDo_Item(Id, Day, Sort_Value, Title, Description, Reminder, Done);
            panel3.Controls.Add(item);
            item.Top = position_Item;
            position_Item = position_Item + item.Height + 10;
        }

        public void Add_Task_To_Database()
        {
            //check text and add new task in database
            if (AddItem_Text.Text == "")
            {
                MessageBox.Show("First type a text.");
            }
            else if (AddItem_Text.Text.Length > 99)
            {
                MessageBox.Show("The text must be less than 100 letters.");
            }
            else
            {
                Reset_Session();
                using (mySession.BeginTransaction())
                {
                    contactDb db = new contactDb
                    {
                        Day = label1.Text,
                        Sort_Value = Tasks_index,
                        Title = AddItem_Text.Text,
                        Reminder = true,
                        Done = false
                    };
                    mySession.Save(db);
                    mySession.Transaction.Commit();
                }
                Reset_Panel();
            }
            AddItem_Text.Text = "";
        }

        public void Update(int id, string day, int sort_Value, string title, string description, bool reminder, bool done)
        {
            //save change of task in database
            Reset_Session();
            using (mySession.BeginTransaction())
            {
                contactDb db = new contactDb
                {
                    Id = id,
                    Day = day,
                    Sort_Value = sort_Value,
                    Title = title,
                    Description = description,
                    Reminder = reminder,
                    Done = done
                };
                mySession.SaveOrUpdate(db);
                mySession.Transaction.Commit();
            }
        }

        public void Delete(int id, string day, int sort_Value, string title, string description, bool reminder, bool done)
        {
            //delete a task
            Reset_Session();
            using (mySession.BeginTransaction())
            {
                contactDb db = new contactDb
                {
                    Id = id,
                    Day = day,
                    Sort_Value = sort_Value,
                    Title = title,
                    Description = description,
                    Reminder = reminder,
                    Done = done
                };
                mySession.Delete(db);
                mySession.Transaction.Commit();
            }
        }
    }
}