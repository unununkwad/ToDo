using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;

namespace TODO
{
    public partial class Form1 : Form
    {

        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;
        public Form1()
        {
            InitializeComponent();
            DateTime thisDay = DateTime.Today;
            label1.Text = thisDay.ToString("d");

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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text = monthCalendar1.SelectionStart.ToString("d");
            groupBox1.Hide();

            ICriteria crit = mySession.CreateCriteria<contactDb>();
            var Items = crit.List<contactDb>();
            foreach (var s in Items)
            {
                AddItem(s.Day, s.Sort_Value, s.Title, s.Description, s.Reminder, s.Done);

            }
        }


        //generate a item
        int position_Item = 0;
        public void AddItem(string Day, int Sort_Value, string Title, string Description, bool Reminder, bool Done)
        {
            ToDo_Item item = new TODO.ToDo_Item(Day, Sort_Value, Title, Description, Reminder, Done);
            panel3.Controls.Add(item);
            item.Top = position_Item;
            //panel3.Show();
            position_Item = position_Item + item.Height + 10;
        }



        private void Add_Task_Click(object sender, EventArgs e)
        {
            //AddItem(AddItem_Text.Text, false);
            




            using (mySession.BeginTransaction())
            {
                contactDb db = new contactDb
                {
                    Day = label1.Text,
                    Sort_Value = 5,
                    Title = AddItem_Text.Text,
                    Reminder = false,
                    Done = false
                };

                mySession.Save(db);

                mySession.Transaction.Commit();

            }
            AddItem_Text.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
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

            using (mySession.BeginTransaction())
            {
                contactDb db = new contactDb
                {

                };

                mySession.Save(db);

                mySession.Transaction.Commit();
            }
        }

       
    }
}
