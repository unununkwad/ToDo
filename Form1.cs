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
using NHibernate.Criterion;

namespace TODO
{
    public partial class Form1 : Form
    {

        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;
        int position_Item = 0;
        int Tasks_index = 0;
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



            Reset_Panel();
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

            Reset_Panel();
        }


        //generate a items on panel
        public void Reset_Panel()
        {
            panel3.Controls.Clear();
            position_Item = 0;
            Tasks_index = 1;
            var Items = mySession.CreateCriteria<contactDb>()
                .Add(Expression.Like("Day", label1.Text))
                .AddOrder(Order.Asc("Done"))
                .List<contactDb>();
            foreach (var s in Items)
            {
                AddItem(s.Day, s.Sort_Value, s.Title, s.Description, s.Reminder, s.Done);
                Tasks_index++;
            }
        }


        //add a item to panel
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
            
            if(AddItem_Text.Text == "")
            {
                MessageBox.Show("First type a text.");
            }
            else
            {
                using (mySession.BeginTransaction())
                {
                    contactDb db = new contactDb
                    {
                        Day = label1.Text,
                        Sort_Value = Tasks_index,
                        Title = AddItem_Text.Text,
                        Reminder = false,
                        Done = false
                    };
                    mySession.Save(db);
                    mySession.Transaction.Commit();
                }
                AddItem_Text.Text = "";
                Reset_Panel();
            }
        }
    }
}