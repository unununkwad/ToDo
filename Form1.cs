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
//using NHibernate.Linq;

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
            MessageBox.Show("click");
            Reset_Panel();
        }


        //generate a items on panel
        public void Reset_Panel()
        {

            Reset_Session();


            //MessageBox.Show("reset");
            panel3.Controls.Clear();
            position_Item = 0;
            Tasks_index = 1;
            var Items = mySession.CreateCriteria<contactDb>()
                .Add(Expression.Like("Day", label1.Text))
                .AddOrder(Order.Asc("Done"))
                .AddOrder(Order.Asc("Sort_Value"))
                .List<contactDb>();
            foreach (var s in Items)
            {
                AddItem(s.Id, s.Day, s.Sort_Value, s.Title, s.Description, s.Reminder, s.Done);
                Tasks_index++;
                //MessageBox.Show(s.Title, s.Done.ToString());
            }
        }

        public void Reset_Session()
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
        }


        //add a item to panel
        public void AddItem(int Id, string Day, int Sort_Value, string Title, string Description, bool Reminder, bool Done)
        {
            ToDo_Item item = new TODO.ToDo_Item(Id, Day, Sort_Value, Title, Description, Reminder, Done);
            panel3.Controls.Add(item);
            item.Top = position_Item;
            panel3.Show();
            position_Item = position_Item + item.Height + 10;
        }


        public void Update(int id, string day, int sort_Value, string title, string description, bool reminder, bool done)
        {
            Reset_Session();


            using (mySession.BeginTransaction())
            {
                /*if (Done == true)
                {
                    mySession.Query<contactDb>()
                        .Where(a => a.Id == id)
                        .UpdateBuilder()
                        .Set(a => a.Done, false)
                        .Update();
                }
                else
                {
                    mySession.Query<contactDb>()
                        .Where(a => a.Id == id)
                        .UpdateBuilder()
                        .Set(a => a.Done, true)
                        .Update();
                }*/
                
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

        private void Form1_Load(object sender, EventArgs e)
        {

            DateTime thisDay = DateTime.Today;
            label1.Text = thisDay.ToString("d");
            Reset_Panel();
            Reset_Session();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            Reset_Panel();
        }
    }
}